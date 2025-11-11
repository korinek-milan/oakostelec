using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    internal class Program
    {

        static void Main(string[] args)
        {
            MyShape m = new MyShape();
            Console.WriteLine(m.shapeType);

            MyShape m2 = new MyShape(4,5);
            Console.WriteLine(m.shapeType);
             
            Console.WriteLine(m2.ToString());
            Console.WriteLine(m + m2);

            "a" + "4" a4
            "5" + "4" "54"

            MyShape m3 = new MyShape()

            int x = 10;
            int y = 20;
            float xd = 20.5f;
            float yd = 1.0f;

            int souceti = soucet(x,y);
            float soucetf = soucet(xd, yd);
        }

        /// <summary>
        /// Gets the username associated with the specified ID.
        /// </summary>
        /// <param name="id">The unique user ID.</param>
        /// <returns>Nothing</returns>
        public static int soucet(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// Gets the username associated with the specified ID.
        /// </summary>
        /// <param name="id">The unique user ID.</param>
        /// <returns>Nothing</returns>
        public static int soucet(int x, int y, int z)
        {
            return x + y + z;
        }

        /// <summary>
        /// Gets the username associated with the specified ID.
        /// </summary>
        /// <param name="id">The unique user ID.</param>
        /// <returns>Nothing</returns>
        public static int soucet(float x, float y)
        { 
            return (int)(x + y);
        }



    }
}
