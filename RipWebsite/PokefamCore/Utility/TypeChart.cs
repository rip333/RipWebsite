using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using PokefamCore.Models;

namespace PokefamCore.Utility
{
    public class TypeChart
    {
        public List<AbilityType> abilityTypes;

        public TypeChart()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "PokefamCore.TypeChart.json";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                string json = reader.ReadToEnd();
                abilityTypes = JsonConvert.DeserializeObject<List<AbilityType>>(json);
            }
        }

        public double GetModifier(string attackType, string defenderPrimaryType,
            string defenderSecondaryType = "Pure")
        {
            var abilityType = getFrom(attackType);
            return attackTypeModifier(abilityType, defenderPrimaryType) * attackTypeModifier(abilityType, defenderSecondaryType);
        }

        private double attackTypeModifier(AbilityType attackType, string defenderType)
        {
            if (attackType.Double.Contains(defenderType))
            {
                return 2;
            }
            if (attackType.Half.Contains(defenderType))
            {
                return 0.5;
            }
            if (attackType.Zero.Contains(defenderType))
            {
                return 0;
            }
            return 1;
        }

        private AbilityType getFrom(string type)
        {
            return abilityTypes.First(x => x.Type == type);
        }
    }
}
