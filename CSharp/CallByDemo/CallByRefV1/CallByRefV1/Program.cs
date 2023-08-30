using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallByRefV1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;


            Console.WriteLine("Main Before Swap: a :"+ a);
            Console.WriteLine("Main Before Swap: b :" + b);
            Swap(ref a, ref b);
            Console.WriteLine("Main After Swap: a :" + a);
            Console.WriteLine("Main After Swap: b :" + b);


        }


        public static void Swap(ref int i, ref int j)
        {
            Console.WriteLine("Before Swap: i :" + i);
            Console.WriteLine("Before Swap: j :" + j);
            int temp = i;

            i = j;
            j = temp;
            Console.WriteLine("After Swap: i :" + i);
            Console.WriteLine("After Swap: j :" + j);
        }


    }
}
