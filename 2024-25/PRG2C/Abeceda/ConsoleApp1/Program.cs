// See https://aka.ms/new-console-template for more information

Console.WriteLine("zadejte počet požadovaných znaků");
string input = (Console.ReadLine());

int x = Convert.ToInt32(input)+65;//pocatecni hodnota pismen v ASCII

while (x<65 || x> 91)
{
    Console.WriteLine("zadal jsi cislo mimo 1 - 26");
    x = Convert.ToInt32(Console.ReadLine()) + 65;
}

for (int i = 0+65; i < x; i++)
{
    Console.WriteLine((char)(i));
}




//Napište konzolovou aplikaci, která
//zeptá se uživatele na celé číslo od 1 do 26
//po napsání čísla vypíše tolik písmen abecedy, kolik je číslo
//př. input: 5, output: A B C D E
//abeceda nebude nikde natvrdo uložená (např. v poli)