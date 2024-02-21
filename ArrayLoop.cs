using System;

namespace Ncit_lab_asal1
{
    internal class ArrayLoop
    {
        static void Main(string[] args)
        {

            int[] A = new int[20];


            int evenNumber = 0;
            for (int i = 0; i < 20; i++)
            {
                A[i] = evenNumber;
                evenNumber += 2;
            }


            Console.WriteLine("Array elements with their indices:");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("A[" + i + "]=" + A[i]);

            }
        }
    }
}
