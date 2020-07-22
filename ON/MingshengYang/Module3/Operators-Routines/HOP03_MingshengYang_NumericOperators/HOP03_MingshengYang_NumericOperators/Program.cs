using System;
using static System.Console;

namespace HOP03_MingshengYang_NumericOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 20;
            int num2 = 77;
            float num3 = 5.2f;

            float sum = num1 + num2 + num3; //sum = 20 +77 + 5.2
            int subtract = num2 - num1; // subtract = 77 - 20
            int muliply = num1 * num2;  // muliply = 20 *77
            float divide = num1 / num3;// divide = 20 / 5.3
            int modulus = num2 % num1;// modulus = 77 % 20 

            // output the value of each variable.
            WriteLine("Sum of 3 numbers is: " + sum);
            WriteLine("77 - 20 is: " + subtract);
            WriteLine("20 * 77 is: " + muliply);
            WriteLine("20 / 5.2 is: " + divide);
            WriteLine("77 % 20 is: " + modulus);
            ReadLine();

        }
    }
}
