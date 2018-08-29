using PokefamCore.Factory.Abilities;
using PokefamCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokefamCore.Factory.Pokefams
{
    public class PokeFactory
    {
        public static List<Pokefam> GetAll => new List<Pokefam>() { PokeFactory.BlackPsuedodragon };

        public static Pokefam BlackPsuedodragon => new Pokefam()
        {
            Name = "Black Pseudodragon",
            Id = 0,
            BaseHealth = 30,
            PrimaryType = TypeOf.Acid,
            SecondaryType = TypeOf.Psychic,
            Initiative = 2,
            AC = 7,
            Level = 1,
            ImageUrl= "https://vignette.wikia.nocookie.net/forgottenrealms/images/d/d6/Pseudodragon-5e.png/revision/latest?cb=20161123234755",
            Abilities = new Ability[] {
                AbilityFactory.Bite, AbilityFactory.PoisonSting, AbilityFactory.Confusion, AbilityFactory.AcidBreath
            }
        };

        public static Pokefam FlyingSnake => new Pokefam()
        {
            Name = "Flying Snake",
            Id = 1,
            BaseHealth = 26,
            PrimaryType = TypeOf.Poison,
            SecondaryType = TypeOf.Radiant,
            Initiative = 4,
            AC = 7,
            Level = 1,
            ImageUrl = "https://scontent-sea1-1.cdninstagram.com/vp/76fdedd62bd9843b1bae3435fb3f599e/5BA26A03/t51.2885-15/s480x480/e35/c0.120.966.966/20688131_1858163401166945_8123120034026356736_n.jpg",
            Abilities = new Ability[]
            {
                AbilityFactory.PoisonSting, AbilityFactory.SunBlessing, AbilityFactory.BlindingLight,
                AbilityFactory.Flyby
            }
        };
    }
}
