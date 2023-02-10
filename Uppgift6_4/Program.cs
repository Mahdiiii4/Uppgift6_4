using System;

namespace uppgift6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            upphöjd(2);
        }
        static void upphöjd(int tal)
        {
            tal = tal * tal;
            Console.WriteLine("Den resultat är: " +tal+ ".");
        }
    }
}