using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PraceSeSoubory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\korinek\\Desktop\\";
            string fileName = "myTxtFile.docx";

            string celaCesta = path + fileName;

            //pokud soubor neexistuje, aplikace vyhodí chybu
            string text = File.ReadAllText(celaCesta);
            Console.WriteLine("Obsah souboru:");
            Console.WriteLine(text);

            StreamWriter writer = null;
            try
            {
                // Otevřeme soubor pro zápis (vytvoříme nový nebo přepíšeme existující)
                writer = new StreamWriter(celaCesta);

                // Zapíšeme řádky do souboru
                writer.Write("text na jednom");
                writer.Write(" řádku\n");
                writer.WriteLine("První řádek");
                writer.WriteLine("Druhý řádek");
                writer.WriteLine("Třetí řádek");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Chyba při práci se souborem: " + ex.Message);
            }
            finally
            {
                // Pokud je objekt `writer` vytvořený, zavřeme soubor
                if (writer != null)
                {
                    writer.Close();
                    Console.WriteLine("Soubor byl zavřen.");
                }
            }
        }
    }
}
