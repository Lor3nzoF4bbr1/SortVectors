using System;

namespace SortVectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vect = new int[] { 4, -1, 100, -85, 4, 6, 77, -35, 2, 0 };

            Ordina(vect);

            foreach (int v in vect) 
             Console.WriteLine(v);
            
            Console.ReadKey();
        }

        static void Ordina(int[] v)
        {
            Array.Sort(v);
        }
    }
}
}
