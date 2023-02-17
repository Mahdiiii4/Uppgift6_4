using System;
namespace uppgift6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ner nummert och potensen. skriv först nummert och sen potensen. Var en på sin rad");
            Console.Write("Nummer: ");
            int nummer = int.Parse(Console.ReadLine());
            Console.Write("potens: ");
            int potens = int.Parse(Console.ReadLine());
            upphöjd(nummer, potens);
        }
        static void upphöjd(int tal, int tal2)
        {
            for(int i = 0; i < tal2-1; i++)
            {
                tal = tal * tal;
            }

            Console.WriteLine("Den resultat är: " + tal + ".");
        }
    }
}
