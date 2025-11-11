using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAttribute
{
    internal class ClassB
    {
        ClassA c = new ClassA();

        public ClassB()
        {
            Console.WriteLine(c.s);
        }
    }
}
