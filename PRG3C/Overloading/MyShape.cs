using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    internal class MyShape
    {
        public string shapeType;

        /// <summary>
        /// Gets the username associated with the specified ID.
        /// </summary>
        /// <param name="id">The unique user ID.</param>
        /// <returns>Nothing</returns>
        public MyShape()
        {
            shapeType = "neurčeno";
        }

        /// <summary>
        /// Gets the username associated with the specified ID.
        /// </summary>
        /// <param name="id">The unique user ID.</param>
        /// <returns>Nothing</returns>
        public MyShape(int x)
        {
            shapeType = "ctverec";
        }

        /// <summary>
        /// Gets the username associated with the specified ID.
        /// </summary>
        /// <param name="id">The unique user ID.</param>
        /// <returns>Nothing</returns>
        public MyShape(int x, int y)
        {
            shapeType = "obdelnik";
        }

        /// <summary>
        /// Gets the username associated with the specified ID.
        /// </summary>
        /// <param name="x">first value</param>
        /// <returns>Void</returns>
        public MyShape(int x, int y, int z)
        {
            shapeType = "kvádr";
        }

        public static int operator ++(MyShape x)
        {
            return "cokoliv";
        }

        public override string ToString()
        {
            return shapeType;
        }

    }
}
