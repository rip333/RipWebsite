
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
        public Ability AbilityA, AbilityB, AbilityC, AbilityD;
        public int BaseHealth = 25;

        public int HealthGain = 5;
        
    }
}
