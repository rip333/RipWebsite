using System;

namespace PokefamCore.Models
{
    public class Roll
    {
        private static Random random = new Random();

        public static int Dice(int number, int diceType, int constant)
        {
            return number * random.Next(1, diceType + 1) + constant;
        }
    }
}
