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
        private string Nazev;

        public Tournament(string _Nazev)
        {
            Nazev = _Nazev;
        }


        public void pridejTeam(Team t)
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
            g.PlayGame();

            return true;
        }

        public bool CreateAndPlaGame2()
        {
            Team t1 = null;
            Team t2 = null;

            foreach (Team item in teamList)
            {
                if (item.hasLost == false)
                {
                    if (t1 == null)
                    {
                        t1 = item;
                    }
                    else
                    {
                        t2 = item;
                        break;
                    }
                }
            }
 
            if (t1 == null || t2 == null)
            {
                return false;
            }

            Game g = new Game(t1, t2);
            gameList.Add(g);
            g.PlayGame();

            return true;


        }

        public string getWinner()
        {
            int pocetHrajicich = 0;
            Team t = null;
            foreach (Team item in teamList)
            {
                if (item.hasLost == false)
                {
                    pocetHrajicich++;
                    t = item;
                }

                if (pocetHrajicich > 1)
                {
                    return "Turnaj ještě není dohraný";
                }
            }

            return t.Nazev;
        }

        public string getWinner2()
        {
            List<Team> neprohrali = new List<Team>();
            foreach (Team item in teamList)
            {
                if (item.hasLost == false)
                {
                    neprohrali.Add(item);
                }

                if (neprohrali.Count > 1)
                {
                    return "Turnaj ještě není dohraný";
                }
            }

            return neprohrali[0].Nazev;
        }

    }
}
