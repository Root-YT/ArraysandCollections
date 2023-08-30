using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemoV1
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] a = new int[5]; 

            //a[0] = 12;
            //a[1] = 13;
            //a[2] = 14;
            //a[3] = 15;
            //a[4] = 16;

            //Console.WriteLine(a[2]);

            int[] ma = new int[5] { 11, 12, 13, 14, 15 };

            int[] ma1 = GetRandomArray(10, 20);

            int[] ma2 = GetUserArray(5);
            PrintArrays(ma2);

            float[] ma3 = new float[] {1.10f, 1.35f, 2.4f };
            PrintArrays(ma3);
            //int sum = 0;
            //for (int i = 0; i < ma.Length; i++)
            //{
            //    Console.Write(ma[i]+"\t");
            //    sum += ma[i];
            //}
            //Console.WriteLine();
            //Console.WriteLine(sum);

            //ma.Max();
            //ma.Min();
            //ma.Sum();
            //ma.Average();


        }

        public static int[] GetRandomArray(int Size, int Max)
        {
            int[] a = new int[Size];
            Random r = new Random();

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(Max);
            }
            return a;
        }

        public static int[] GetUserArray(int Size)
        {
            int[] a = new int[Size];
            Console.WriteLine("Getting Array Values");

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter the value for position "+ i);
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }



        public static void PrintArrays(int[] a)
        {
            Console.WriteLine("Printing Array Elements: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]+ "\t");
            }
            Console.WriteLine();
        }

        public static void PrintArrays(float[] a)
        {
            Console.WriteLine("Printing Array Elements: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + "\t");
            }
            Console.WriteLine();
        }
    }
}
