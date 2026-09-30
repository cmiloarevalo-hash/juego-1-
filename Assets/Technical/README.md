# Technical Unity scaffold — Issue #73

Allowed scope only: bootstrap/instrumentation/synthetic experiments.

## On first verified Unity open
1. Open with Unity 6000.3.25f1.
2. Resolve packages and commit generated Packages/packages-lock.json.
3. Commit generated .meta files.
4. Create and save:
   - Assets/Technical/Scenes/BootstrapScene.unity
   - Assets/Technical/Scenes/SyntheticTestScene.unity
5. Add Stage2RuntimeProbe to one empty GameObject in each technical scene.
6. Configure Android PlayerSettings from BOOTSTRAP_BASELINE.md and record serialized settings.
7. Verify clean compile before changing #73 from BLOCKED.

No gameplay domain, Santa, army, gate, combat, boss, production level or final art belongs in this scaffold.
