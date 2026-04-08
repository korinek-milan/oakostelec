using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnaj
{
    internal class Tournament
    {
        List<Game> gameList = new List<Game>();
        List<Team> teamList = new List<Team>();

        public void pridejTeamj(Team t)
        {
            teamList.Add(t);
        }

        public bool CreateAndPlaGame1()
        {
            List<Team> neprohrali = new List<Team>();
            foreach (Team item in teamList)
            {
                if (item.hasLost == false)
                {
                    neprohrali.Add(item);
                }

                if (neprohrali.Count == 2)
                {
                    break;
                }
            }

            if (neprohrali.Count < 2)
            {
                return false;
            }

            Game g = new Game(neprohrali[0], neprohrali[1]);
            gameList.Add(g);


            return true;
        }
    }
}
