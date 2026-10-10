using System.Collections.Generic;

namespace ChristmasRunner.Gameplay.Localization
{
    public enum Language { ES, EN }

    public sealed class Localizer
    {
        private readonly Dictionary<string, string> _es = new Dictionary<string, string>
        {
            ["onboarding.move"] = "Desliza para moverte",
            ["result.victory"] = "¡Victoria!",
            ["result.defeat"] = "Derrota",
            ["result.helpersRemaining"] = "Ayudantes restantes",
            ["hud.helpers"] = "Ayudantes",
            ["gate.add"] = "Sumar",
            ["gate.multiply"] = "Multiplicar",
            ["boss"] = "Jefe final"
        };

        private readonly Dictionary<string, string> _en = new Dictionary<string, string>
        {
            ["onboarding.move"] = "Swipe to move",
            ["result.victory"] = "Victory!",
            ["result.defeat"] = "Defeat",
            ["result.helpersRemaining"] = "Helpers remaining",
            ["hud.helpers"] = "Helpers",
            ["gate.add"] = "Add",
            ["gate.multiply"] = "Multiply",
            ["boss"] = "Final boss"
        };

        public Language Current { get; private set; } = Language.ES;
        public void SetLanguage(Language language) => Current = language;

        public string Get(string key)
        {
            Dictionary<string, string> table = Current == Language.ES ? _es : _en;
            return table.TryGetValue(key, out string value) ? value : key;
        }
    }
}
