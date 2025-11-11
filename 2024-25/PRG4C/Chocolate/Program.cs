using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Chocolate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DatabaseManager manager = new DatabaseManager();
            ChocolateFactory factory = new ChocolateFactory();

            while (true)
            {
                Console.WriteLine(mainMenu());
                int menuId;
                while (!Int32.TryParse(Console.ReadLine(), out menuId) && (menuId>6 || menuId < 1))
                {
                    Console.WriteLine("Špatné číslo, zkus to znovu");
                    Console.WriteLine(mainMenu());
                }
                int chocolateId;
                string chocolateName = "";
                switch (menuId)
                {
                    case 1:
                        Console.WriteLine(ChocolateMenu());
                        
                        while (!Int32.TryParse(Console.ReadLine(), out chocolateId) && (chocolateId > 5 || chocolateId < 1))
                        {
                            Console.WriteLine(ChocolateMenu());
                        }
                        chocolateName = ChocolateSelect(chocolateId);
                        factory.MakeChocolate(chocolateName);

                        break;
                    case 2:
                        Console.WriteLine(factory.getMadeChocolates());
                        break;
                    case 3:
                        Console.WriteLine(ChocolateMenu());
                        while (!Int32.TryParse(Console.ReadLine(), out chocolateId) && (chocolateId > 5 || chocolateId < 1))
                        {
                            Console.WriteLine(ChocolateMenu());
                        }
                        chocolateName = ChocolateSelect(chocolateId);
                        factory.eatChocolate(chocolateName);
                        break;
                    case 4:
                        Console.WriteLine(IngredientMenu());
                        int ingredientId;
                        int amount;
                        while (!Int32.TryParse(Console.ReadLine(), out ingredientId) && (ingredientId > 5 || ingredientId < 1))
                        {
                            Console.WriteLine("Špatné číslo, zkus to znovu");
                            Console.WriteLine(IngredientMenu());
                        }
                        Console.WriteLine("Množství?");
                        while (!Int32.TryParse(Console.ReadLine(), out amount))
                        {
                            Console.WriteLine("Špatné množství");
                            Console.WriteLine(IngredientMenu());
                        }
                        Console.WriteLine("celkem po doplnění: " + factory.RestockIngredient(IngredientSelect(ingredientId),amount).ToString());
                        break;
                    case 5:
                        Console.WriteLine(factory.getAllIngredients());
                        break;
                    case 6:
                        factory.RestockAll();
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default :
                        Console.WriteLine("Špatná volba");
                        break;
                }
            }
        }

        public static string ChocolateSelect(int chocolateId)
        {
            string chocolateName = "";
            switch (chocolateId)
            {
                case 1:
                    chocolateName = "Dark";
                    break;
                case 2:
                    chocolateName = "Milky";
                    break;
                case 3:
                    chocolateName = "White";
                    break;
                case 4:
                    chocolateName = "Light";
                    break;
                case 5:
                    chocolateName = "Extra";
                    break;
                default:
                    Console.WriteLine("Bude vybrána první volba");
                    chocolateName = "Dark";
                    break;
            }

            return chocolateName;
        }

        public static string IngredientSelect(int ingredientId)
        {
            string ingredientName = "";
            switch (ingredientId)
            {
                case 1:
                    ingredientName = "CocoaBeans";
                    break;
                case 2:
                    ingredientName = "Sugar";
                    break;
                case 3:
                    ingredientName = "Milk";
                    break;
                case 4:
                    ingredientName = "CocoaButter";
                    break;
                case 5:
                    ingredientName = "Vanilla";
                    break;
                default:
                    Console.WriteLine("Bude vybrána první volba");
                    ingredientName = "CocoaBeans";
                    break;
            }

            return ingredientName;
        }

        public static string IngredientMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1 - CocoaBeans");
            sb.AppendLine("2 - Sugar");
            sb.AppendLine("3 - Milk");
            sb.AppendLine("4 - CocoaButter");
            sb.AppendLine("5 - Vanilla");
            return sb.ToString();
        }

        public static string ChocolateMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1 - Dark");
            sb.AppendLine("2 - Milky");
            sb.AppendLine("3 - White");
            sb.AppendLine("4 - Light");
            sb.AppendLine("5 - Extra");
            return sb.ToString();
        }

        public static string mainMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1 - Vyrob čokoládu");
            sb.AppendLine("2 - Vypiš vyrobené čokolády");
            sb.AppendLine("3 - Sníst čokoládu");
            sb.AppendLine("4 - Doplnit surovinu");
            sb.AppendLine("5 - Vypsat suroviny");
            sb.AppendLine("6 - Doplnit všechny suroviny");
            sb.AppendLine("7 - Ukončit program");
            return sb.ToString();
        }
    }
}
