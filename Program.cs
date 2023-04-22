using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов в массиве");
            int arraySize = int.Parse(Console.ReadLine());
            int[] arr = new int[arraySize];
            Random rnd = new Random();

            Console.WriteLine("Первоначальный массив:");

            for (int i = 0; i < arraySize; i++)
            {
                arr[i] = rnd.Next(100);
                Console.Write(arr[i] + " ");
            }
            Shuffle(arr);

            Console.WriteLine("\nПеремешанный массив:");

            for (int i = 0; i < arraySize; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.ReadLine();
        }

        static void Shuffle(int[] arr)
        {
            Random rng = new Random();

            for (int i = arr.Length - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1);
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }

        }
    }
}