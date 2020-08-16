using System;
using System.Reflection.PortableExecutable;
using static System.Console;

namespace String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string welcome = "Welcome to ";
            string CourseName = "CS132";
            string message = welcome + CourseName;

            //the index starts at 0 and keeps interating, as long as its in range of "Message"
            for (int i = 0; i < message.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Write(message[i]);// prints the value at the index of "message", starting at index 0
                }
            }
            
        }
    }
}
