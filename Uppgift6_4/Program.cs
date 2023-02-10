using System;
namespace uppgift6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ner nummert");
            int nummer = int.Parse(Console.ReadLine());
            upphöjd(nummer);
        }
        static void upphöjd(int tal)
        {
            tal = tal * tal;
            Console.WriteLine("Den resultat är: " + tal + ".");
        }
    }
}
