using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnihovnaDB
{
    internal class Book
    {
        string Name;
        string Author;
        int Year;

        public Book(string Name, string Author, int Year)
        {
            this.Name = Name;
            this.Author = Author;
            this.Year = Year;
            
        }
    }
}
