using PokefamCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokefamCore.Factory.Abilities
{
    public class AbilityFactory
    {
        public static Ability Bite => new Ability()
        {
            Name = "Bite",
            Id = 0,
            Type = TypeOf.Pure,
            Targets = 1,
            ShouldRollEffect = true,
            ShouldRollToHit = true,
            ToHit = 3,
            EffectRollNumber = 1,
            EffectRollConstant = 5
        };

        public static Ability PoisonSting => new Ability()
        {
            Name = "Poison Sting",
            Id = 1,
            Type = TypeOf.Poison,
            Targets = 1,
            ShouldRollEffect = true,
            ShouldRollToHit = true,
            ToHit = 3,
            EffectRollNumber = 1,
            EffectRollConstant = 5
        };

        public static Ability Confusion => new Ability()
        {
            Name = "Confusion",
            Id = 2,
            Type = TypeOf.Psychic,
            Targets = 1,
            ShouldRollEffect = true,
            ShouldRollToHit = true,
            ToHit = 1,
            EffectRollNumber = 1,
            EffectRollConstant = 5,
            Cooldown = 1,
            Text = "Target is confused."
        };

        public static Ability AcidBreath => new Ability()
        {
            Name = "Acid Breath",
            Id = 3,
            Type = TypeOf.Acid,
            Targets = 3,
            ShouldRollEffect = true,
            ShouldRollToHit = true,
            ToHit = 3,
            EffectRollNumber = 2,
            EffectRollConstant = 3,
            Cooldown = 2
        };

        public static Ability SunBlessing => new Ability()
        {
            Name = "Sun Blessing",
            Id = 4,
            Type = TypeOf.Radiant,
            Targets = 1,
            ShouldRollEffect = true,
            ShouldRollToHit = false,
            ToHit = 0,
            EffectRollNumber = 1,
            EffectRollConstant = 7,
            Cooldown = 2
        };
    }
}
