using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Před výjimkou");
            //int i = 0;
            //// Neošetřená výjimka
            //int result = 10 / i; // Tohle způsobí chybu dělení nulou

            //Console.WriteLine("Toto se nikdy nevytiskne");

            

            

            try
            {
                Console.WriteLine("Zadejte hodnotu od 1 do 5");
                int i = Int32.Parse(Console.ReadLine());

                if (i <= 0 || i > 5)
                {
                    //mnou vyhozená výjimka typu ArgumentOutOfRangeException
                    throw new ArgumentOutOfRangeException("Vstupní hodnota, Hodnota mimo rozsah 1 - 5");
                }
                int result = 10 / i; // Tohle způsobí dělení nulou
                Console.WriteLine(result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Dělil jsi nulou, zadej číslo větší rovno 1");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nastala neočekávaná chyba");
                Console.WriteLine(ex.Message.ToString());

            }
            finally
            {
                Console.WriteLine("Toto se vykoná vždy buď po dokončení try nebo po dokončení catch");
            }

            try
            {
                int x = Int32.Parse(Console.ReadLine());
                int y = Int32.Parse(Console.ReadLine());

                //zde vyskočí ručně vyhozená výjimka a proto bude ošetřena pomocí catch
                nasobeni(1, 2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Zadejte prosím číslo");
            }

            //x a y neexistuji mimo tělo try - platnost je od závorky k závorce
            //nasobeni(x, y);

            //zde bude ručně vyhozená výjimka, která není ošetřena try/catch a program spadne
            nasobeni(1, 2);

        }

        public static int nasobeni(int x, int y)
        {
            //toto throw vyskočí o úroveň výš,
            throw new Exception("chyba");
            return x * y;
        }
    }
}
