using System;
using static System.Console;

namespace Enums
{
    enum Gender { Male, Female, Other };
    enum Age { Young, Middle, Old};
    enum Hair { Long, Short,Bald};
    enum Height { Tall, Short};
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("I am a "+ Gender.Male);
            WriteLine("My Age is "+ Age.Young);
            WriteLine("My Hair is "+ Hair.Short);
            WriteLine("My Height is "+ Height.Tall);
        }
    }
}
