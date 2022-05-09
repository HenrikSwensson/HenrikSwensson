using System;

namespace RobertTentaF2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            for (int i = 1; i < 12; i++) // ändrade till mindre än 12
            {
                a = EttVarv(i, a);
            }
            Console.ReadKey();
        }
        public static int EttVarv(int i, int a) //la till int
        {
            Console.WriteLine("Varv {0}. a == {1}; a = a * 2.", i, a); // bytte plats på a och i

            return a * 2; // ändrade a * a till a *2
        }
    }
}
