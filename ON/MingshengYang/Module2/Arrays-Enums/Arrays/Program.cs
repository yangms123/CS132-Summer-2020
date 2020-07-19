using System;
using static System.Console;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sentence = new string[] {"This","is","a","string" };
            foreach (string s in sentence)
            {
                Write(s + " ");
            }
            ReadLine();
        }
    }
}
