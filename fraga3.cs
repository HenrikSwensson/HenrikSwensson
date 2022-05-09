using System;

namespace Uppgift_3
{
	class VektorSortering
	{
        public static string[] namn = { "Carl", "Isabell", "Martin", "Stina", "Jane", "Samuel", "Harriet", "Victoria", "Frans", "Hjalmar", "Karin", "Fredrika", "Anne", "Charlotte", "Emily", "Albert", "Daniel", "Alexandre", "William", "Per" };
        static void Main()
		{
            SorteraNamn();
            PrintNamn(namn);
		}

        public static void PrintNamn(string[] printnamn)
        {
            for (int i = 0; i < printnamn.Length; i++)
            {
                Console.WriteLine((printnamn[i]));
            }
        }

        public static void Swap(string[] vektor, int a, int b)
        {
            string r = vektor[a];
            vektor[a] = vektor[b];
            vektor[b] = r;
        }
        public static void SorteraNamn()
		{
            bool osorterad = true;
            int end = namn.Length - 1;
            while (osorterad)
            {
                osorterad = false;
                for (int j = 0; j < end; j++)
                {
                    if (namn[j].CompareTo(namn[j + 1]) == -1)
                    {
                        Swap(namn, j, j + 1);
                        osorterad = true;
                    }
                }
                end--;
            }

        }

	}
}
