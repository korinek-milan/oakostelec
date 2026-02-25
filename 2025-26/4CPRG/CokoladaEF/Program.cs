namespace CokoladaEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DatabaseManager dbm = new DatabaseManager();

            dbm.GetAllIngredients();
        }
    }
}
