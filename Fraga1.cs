using System;

namespace RobertTenta
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ange ett heltal mellan 1-10");
            int svar = int.Parse(Console.ReadLine());
            Mulitplikation(svar);
        }
            public static int Mulitplikation(int svar)
            {
            
                int resultat = 0;
                for (int i = 0; i < 11; i++)
                {
                    resultat = svar * i;
                    Console.WriteLine($"{svar} * {i} = {resultat}");
                }
            return resultat;

            }
    }
    
}
