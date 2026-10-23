namespace bitovyPosun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 00000101
            Console.WriteLine(5);
            //000001010
            Console.WriteLine(5 << 1);

            //0000010100
            Console.WriteLine(5 << 2);

            //1010
            Console.WriteLine(Convert.ToString(10, 2));

            //1010 = 10
            //1100 = 12
            // | = 1110
            // & = 1000

            Console.WriteLine(10 | 12);
            Console.WriteLine(10 & 12);
        }
    }
}
