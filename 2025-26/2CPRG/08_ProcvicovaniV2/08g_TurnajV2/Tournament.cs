using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnajV2
{
    internal class Tournament
    {
        string Name;
        List<Game> GameList = new List<Game>();
        List<Team> TeamList = new List<Team>();

        public void addTeam(Team t)
        {
            TeamList.Add(t);
        }

        public bool CreateAndPlayGame()
        {
            //TODO - NENÍ DOPSÁNO
            //nějak vyberu dva týmy
            Game g = new Game(TeamList[0], TeamList[1]);
            GameList.Add(g);


            return false;
        }
    }
}
