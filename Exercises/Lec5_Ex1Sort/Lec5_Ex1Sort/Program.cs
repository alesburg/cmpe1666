using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec5_Ex1Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = BubbleSort(PrepArray());
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($" {array[i]}");
            }
            Console.ReadKey();
        }

        public static int[] PrepArray()
        {
            int n;
            int[] array;
            Random random = new Random();

            Console.Write("n is: ");
            int.TryParse(Console.ReadLine(), out n);

            Console.Write("Generated order:");
            array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0,1000);
                Console.Write($" {array[i]}");
            }
            Console.WriteLine();
            return array;

        }

        public static int[] BubbleSort(int[] array)
        {
            int n = array.Length-1;
            int temp;

            Console.Write("Sorted order:");
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }
    }
}
