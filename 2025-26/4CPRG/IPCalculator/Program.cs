using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ip = "";
            string[] binaryIP = new string[4];
            while (true)
            {
                Console.WriteLine("Zadejte ip adresu");
                ip = Console.ReadLine();
                if (isValidIP(ip, out binaryIP))
                {
                    break;
                }
            }

            int mask;
            Console.WriteLine("Zadejte platnou hodnotu pro masku");
            while (!int.TryParse(Console.ReadLine(), out mask) || mask < 0 || mask > 32)
            {
                Console.WriteLine("Zadejte platnou hodnotu pro masku");
            }

            int tmp = 0;
            foreach (string s in binaryIP)
            {
                Console.Write(s);
                if(tmp != 3)
                {
                    Console.Write(".");
                }
                tmp++;
            }

        }

        static bool isValidIP(string ip, out string[] binary)
        {
            binary = new string[4];
            string[] parts = ip.Split('.');
            if (parts.Length != 4)
            {
                return false;
            }

            int i = 0;
            foreach (string s in parts)
            {
                if (!byte.TryParse(s, out byte part))
                {
                    return false;
                }
                else
                {
                    binary[i] = Convert.ToString(part, 2).PadLeft(8, '0');
                    i++;
                }
            }

            return true;
        }
    }
}
