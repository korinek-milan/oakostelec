using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnajV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tournament t = new Tournament();
            Player p1 = new Player();
            Player p2 = new Player();

            Team t1 = new Team();
            t1.AddPlayer(p1);
            t1.AddPlayer(p2);

            Player p3 = new Player();
            Player p4 = new Player();

            Team t2 = new Team();
            t2.AddPlayer(p3);
            t2.AddPlayer(p4);

            t.addTeam(t1);
            t.addTeam(t2);

           
        }
    }
}
