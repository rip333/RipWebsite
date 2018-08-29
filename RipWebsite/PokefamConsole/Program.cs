using PokefamCore.Utility;
using System;

namespace PokefamConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokefamGame = new Pk_Game();
            
            while(pokefamGame.Playing)
            {
                pokefamGame.NextTurn();
            }
        }
    }
}
