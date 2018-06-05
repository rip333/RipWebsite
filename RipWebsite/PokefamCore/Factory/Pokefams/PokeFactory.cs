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
            Abilities = new Ability[] {
                AbilityFactory.Bite, AbilityFactory.PoisonSting, AbilityFactory.Confusion, AbilityFactory.AcidBreath
            }
        };
    }
}
