using MelonLoader;
using UnityEngine;

namespace modthatclosesthegamewhenitopens
{
    public class ModMain : MelonMod
    {
        public ModMain()
        {
            var c =MelonPreferences.CreateCategory("modthatclosesthegamewhenitopens");
            var entryValue = c.CreateEntry("chanceitclosesthegamewhenitopens", 1, description: "0 to 1.")?.Value ?? 1;
            c.SaveToFile(false);
            if (System.Random.Shared.NextDouble() < entryValue)
            {
                Environment.Exit(0);
            }
        }
    }
}
