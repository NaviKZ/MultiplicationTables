using System;

namespace MultiplicationTable
{
    internal class MultiplicationTable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите размерность таблицы умножения:");
            int tableSize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.Write($"{"y/x",4} |");

            for (int i = 1; i <= tableSize; i++)
            {
                Console.Write($"{i,4}");
            }

            Console.WriteLine();

            for (int i = 0; i <= tableSize + 1; i++)
            {
                Console.Write(" __ ");
            }

            Console.WriteLine();

            for (int i = 1; i <= tableSize; i++)
            {
                Console.Write($"{i,4} |");

                for (int j = 1; j <= tableSize; j++)
                {
                    Console.Write($"{i * j,4}");
                }

                Console.WriteLine();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}