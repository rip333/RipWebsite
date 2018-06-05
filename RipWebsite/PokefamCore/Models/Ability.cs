using System;
using System.Collections.Generic;
using System.Text;

namespace PokefamCore.Models
{
    public class Ability
    {
        public string Name = "";
        public int Id = 0;
        public TypeOf Type = TypeOf.Pure;
        public int ToHit = 1;
        public int Targets = 1;
        public string Text = "";
        public int Cooldown = 0;
        public bool ShouldRollToHit = true;
        public bool ShouldRollEffect = true;
        public int EffectRollNumber = 1;
        public int EffectRollConstant = 0;
        public int LevelLearned = 1;
        public bool Learned = true;

        public int RollToHit()
        {
            return Roll.Dice(2, 6, ToHit);
        }

        public int RollEffect()
        {
            return Roll.Dice(EffectRollNumber, 6, EffectRollConstant);
        }
    }
}
