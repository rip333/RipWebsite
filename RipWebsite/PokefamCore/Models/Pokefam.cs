
using System.Collections.Generic;
using System.Linq;

namespace PokefamCore.Models
{
    public class Pokefam
    {
        public string Name = "";
        public int Id = 0;
        public string Nickname = "";
        public int AC = 5;
        public int Initiative = 1;
        public TypeOf PrimaryType, SecondaryType;
        public int Level = 1;
        public int Health = 25;
        public Ability[] Abilities = { };
        public int BaseHealth = 25;
        public string ImageUrl = "";
        public bool PlayerControlled = false;
        public int PlayerId = -1;
        public int Square = 1;

        public int HealthGain = 5;
        

        public void CalculateHealth()
        {
            Health = BaseHealth + Level * HealthGain;
        }

        public List<Ability> GetLearnedAbilities() => Abilities.Where(x => x.Learned).ToList();

    }
}
