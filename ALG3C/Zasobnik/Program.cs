using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zasobnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();

            q.Push(5);
            q.Push(7);
            q.Push(11);

            Console.WriteLine("Přidal jsem 5, 7, 11:");
            Console.WriteLine("Zásobník (poslední dovnitř, první ven - tedy v obráceném pořadí):");
            Console.WriteLine(q.WriteAll());

            Console.WriteLine("Tento popnu:");
            Console.WriteLine(q.Pop().Value);

            Console.WriteLine("\nZásobník:");
            Console.WriteLine(q.WriteAll());

            Console.WriteLine("Jen peeknu:");
            Console.WriteLine(q.Peek());

            Console.WriteLine("\nZásobník:");
            Console.WriteLine(q.WriteAll());

        }
    }
}
