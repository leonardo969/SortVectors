using System;

namespace SortVectors
{
    class Program
    {
        static void Main(string[] args)
        {
           int [] vector = new int [10] { 4,5,8,123,54,-2,1,99,-99,10};
           Array.Sort(vector);

            for (int i=0; i < 10; i++)
            {
                Console.Write(vector[i]+" | ");
            }

           Console.ReadKey();
        }
    }
}
