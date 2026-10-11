
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 20;
            int j, jB = 0, jC = 0;

            Random rnd = new Random();

            int[] A = new int[N];
            int[] B = new int[N];
            int[] C = new int[N];
            for (j = 0; j < N; j++)
            {
                A[j] = 50 - rnd.Next(1, 101);
            }
            Console.WriteLine("\nВихідний масив A:");

            foreach (int jj in A)
            {
                Console.Write(" " + jj);
            }

            Console.WriteLine("\n");
            for (j = 0; j < N; j++)
            {
                if (A[j] > 0)
                {
                    B[jB] = A[j];
                    jB++;
                }
                else if (A[j] < 0)
                {
                    C[jC] = A[j];
                    jC++;
                }
            }
            Console.WriteLine("\nМасив B (додатні елементи):");

            for (j = 0; j < jB; j++)
            {
                Console.Write(" " + B[j]);
            }

            Console.WriteLine("\n");
            Console.WriteLine("\nМасив C (від’ємні елементи):");

            for (j = 0; j < jC; j++)
            {
                Console.Write(" " + C[j]);
            }

            Console.WriteLine("\n");

            Console.ReadKey();
        }
    }
}
