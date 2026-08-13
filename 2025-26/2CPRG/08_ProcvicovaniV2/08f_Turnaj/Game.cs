using System;

namespace Turnaj
{
    internal class Game
    {
        Team t1;
        Team t2;

        public Game(Team _t1, Team _t2)
        {
            t1 = _t1;
            t2 = _t2;
        }

        public void PlayGame()
        {
            Random r = new Random();
            if (r.Next(2) == 0)
            {
                t1.nastavHasLost();
            }
            else
            {
                t2.nastavHasLost();
            }
        }
    }
}
