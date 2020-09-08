using System;
using System.Runtime.CompilerServices;
using static System.Console;
namespace GenericType
{
    class Program
    {
        class StoreAnything<T,U,W> // declare class StoreAnything using generic type
        { public T var1 { set; get; } 
        public U var2 { set; get; }
            public W var3 { set; get; }
        }
        static void Main(string[] args)
        {
            //StoreAnything<string> MyVar1 = new StoreAnything<string> {var1 = "CS" };

            //StoreAnything<int> MyVar2 = new StoreAnything<int> { var1 = 132 };
            //WriteLine(MyVar1.var1 + " " + MyVar2.var1);

            //create new object of storeAnything class, passing string and int type
            StoreAnything<string, int,char> MyVar1 = new StoreAnything<string, int,char> { var1 = "CS", var2 = 132, var3 = '!'};
            WriteLine(MyVar1.var1 + MyVar1.var2+ MyVar1.var3);
        }
    }
}
