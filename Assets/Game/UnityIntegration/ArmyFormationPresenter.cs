using System.Collections.Generic;
using UnityEngine;

namespace ChristmasRunner.UnityIntegration
{
    /// <summary>Visual-only elf formation. Domain helper count remains authoritative.</summary>
    public sealed class ArmyFormationPresenter : MonoBehaviour
    {
        [SerializeField] private GameSessionBehaviour session;
        [SerializeField] private Transform santa;
        [SerializeField] private GameObject elfPrefab;
        [SerializeField, Min(1)] private int maxRenderedElves = 24;
        [SerializeField, Min(0.1f)] private float columnSpacing = 1.15f;
        [SerializeField, Min(0.1f)] private float rowSpacing = 1.35f;
        [SerializeField, Min(1)] private int columns = 5;
        [SerializeField] private float trailingDistance = 1.8f;

        private readonly List<GameObject> elves = new List<GameObject>();

        private void LateUpdate()
        {
            if (session == null || santa == null || elfPrefab == null) return;
            int visibleCount = Mathf.Min(session.HelperCount, maxRenderedElves);
            EnsurePool(visibleCount);

            for (int i = 0; i < elves.Count; i++)
            {
                bool active = i < visibleCount;
                if (elves[i].activeSelf != active) elves[i].SetActive(active);
                if (!active) continue;

                int row = i / columns;
                int column = i % columns;
                float centeredColumn = column - (columns - 1) * 0.5f;
                Vector3 local = new Vector3(centeredColumn * columnSpacing, 0f, -trailingDistance - row * rowSpacing);
                elves[i].transform.position = santa.TransformPoint(local);
                elves[i].transform.rotation = santa.rotation;
            }
        }

        private void EnsurePool(int count)
        {
            while (elves.Count < count && elves.Count < maxRenderedElves)
            {
                GameObject elf = Instantiate(elfPrefab, transform);
                elf.name = "ElfVisual_" + elves.Count;
                elves.Add(elf);
            }
        }
    }
}
