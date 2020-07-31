using System;

namespace HOP04_MingshengYang_01_Methods
{
    class Program
    {
        //public static void PrintSomething()
        //{
        //    Console.WriteLine("Hello World!");
        //}

        public static int Adding(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        public static int Mod(int a, int b)
        {
            return a % b;
        }
        static void Main(string[] args)
        {
            //PrintSomething();
            //Console.WriteLine(Adding(10,20));
            Console.WriteLine(Mod(20, 13));

        }
    }
}
