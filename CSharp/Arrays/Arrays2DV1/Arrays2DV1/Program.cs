using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2DV1
{
    class Program
    {
        static void Main(string[] args)
        {

            //2D arrays

            //int[,] a = new int[2, 3];
            //a[0, 0] = 12;
            //a[0, 1] = 5;
            //a[0, 2] = 6;
            //a[1, 0] = 4;
            //a[1, 1] = 10;
            //a[1, 2] = 15;

            //Console.WriteLine(a[0,0]);
            //Console.WriteLine(a[0, 2]);
            //Console.WriteLine(a[1, 1]);

            // int[,] a = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            //// Console.WriteLine(a.Length);

            // for (int i = 0; i < a.GetLength(0); i++)
            // {
            //     for (int j = 0; j < a.GetLength(1); j++)
            //     {
            //         Console.Write(a[i,j]+"\t");
            //     }
            //     Console.WriteLine();
            // }


            //Jagged Array

            //int[][] a = new int[3][];
            //a[0] = new int[3] { 1, 2, 3 };
            //a[1] = new int[5] { 1, 2, 3, 4, 5 };
            //a[2] = new int[2] { 6, 7 };


            //Alternative Approach for Initialization.
            int[][] a = new int[3][] { new int[] { 1, 2, 3 }, new int[]{ 2, 5 }, new int[]{ 4, 5, 6, 7, 8 } };

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j] + "\t");
                }
                Console.WriteLine();


            }
        }
    }
}
