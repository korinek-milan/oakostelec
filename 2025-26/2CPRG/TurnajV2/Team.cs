using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnajV2
{
    internal class Team
    {
        string Name;
        bool HasLost;
        List<Player> PlayerList = new List<Player>();

        public void AddPlayer(Player p)
        {
            if (PlayerList.Count < 2)
            {
                PlayerList.Add(p);
            }
        }

        //public void AddPlayerV2(Player p)
        //{
        //    if (PlayerList.Count == 2)
        //    {
        //        return;
        //    }

        //    PlayerList.Add(p);
        //}
    }
}
