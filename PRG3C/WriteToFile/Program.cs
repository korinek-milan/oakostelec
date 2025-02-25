using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteToFile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string myText = "toto je muj text,\nco chci zapsat do souboru";
            string path = "L:\\Kantori\\Kořínek\\ALG-3C\\tmp\\";
            string fileName = "myFile.txt";


            StreamWriter sw = new StreamWriter(path+fileName,true);                                                
            sw.WriteLine(myText);
            sw.Close();
            Console.ReadLine();

            StreamReader sr = new StreamReader(path+fileName);
            string line = sr.ReadLine();

            while (line != null)
            {
                Console.WriteLine(line);
                
                line = sr.ReadLine();
            }
            sr.Close();


            Console.ReadLine();





        }
    }
}
