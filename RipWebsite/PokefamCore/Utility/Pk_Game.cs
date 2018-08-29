using PokefamCore.Factory.Pokefams;
using PokefamCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokefamCore.Utility
{
    public class Pk_Game
    {
        public int Turn = -1;
        public int Round = -1;
        public bool Playing = true;

        public List<Pokefam> Combatants;

        public Pk_Game()
        {
            Combatants = new List<Pokefam>()
            {
                PokeFactory.BlackPsuedodragon,
                PokeFactory.FlyingSnake
            };

            for(int i = 1; i < 9; i++)
            {
                Combatants[i].Square = i;
            }
            Round = 1;
            Turn = 1;
        }

        public void NextTurn()
        {
            if(Turn > 8)
            {
                Round++;
                Turn = 1;
            }



            Turn++;
        }
        

    }
}
