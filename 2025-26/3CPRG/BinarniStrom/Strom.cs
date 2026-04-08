using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarniStrom
{
    internal class Strom
    {
        Node Root = null;

        public void Add(int value)
        {
            Node n = new Node(value);

            

            if (Root == null)
            {
                Root = n;
            }
            else
            {
                Node tmp = Root;
                if (tmp.Value == n.Value)
                {
                    throw new Exception("Hodnota existuje");
                }
                else if (tmp.Value < n.Value)
                {
                    //jdeme doprava
                }
                else
                {
                    //jdeme doleva
                }
                
                //porovnání jestli jde doleva nebo doprava nebo konec
            }
        }
    }
}
