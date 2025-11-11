using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace JsonParsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonRaw = File.ReadAllText("L:\\Kantori\\Kořínek\\oakostelec-repo\\ALG3C\\JsonParsing\\json01.json");

            try
            {
                Console.WriteLine(MyJsonParser.Parse(jsonRaw));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //funguje od .net 5
            //User u = MyJsonParser.ParseToClass(jsonRaw);
            //Console.WriteLine(u.WriteInfo());
        }
    }
}
