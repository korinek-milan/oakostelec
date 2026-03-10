using Knihovna;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kniohovna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DatabaseManager db = new DatabaseManager();
            Book b = new Book("name", "a", 2025);

            Book b2 = new Book("nove jmeno", "a", 2025);

            //db.insertNewBook(b);

            //db.updateByID(2, b2);

            Console.WriteLine(db.getAllBooks());

        }
    }
}
