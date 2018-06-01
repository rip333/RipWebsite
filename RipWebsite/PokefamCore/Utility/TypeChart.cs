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
            var dir = Path.GetDirectoryName(path: Assembly.GetExecutingAssembly().Location);
            var filePath = dir + @"\TypeChart.json";
            using (StreamReader r = new StreamReader(filePath))
            {
                string json = r.ReadToEnd();
                abilityTypes = JsonConvert.DeserializeObject<List<AbilityType>>(json);
            }
        }

        public double GetModifier(TypeOf attackType, TypeOf defenderPrimaryType,
            TypeOf defenderSecondaryType = TypeOf.Pure)
        {
            var abilityType = getFrom(attackType);
            return attackTypeModifier(abilityType, defenderPrimaryType) * attackTypeModifier(abilityType, defenderSecondaryType);
        }

        private double attackTypeModifier(AbilityType attackType, TypeOf defenderType)
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

        private AbilityType getFrom(TypeOf type)
        {
            return abilityTypes.First(x => x.Type == type);
        }
    }
}
