using System;
using static System.Console;
using System.Collections;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable myHashTable = new Hashtable()
           {
               {"Kim",26 },
               { "John", 77},
               {"Max", 50 }
           };
            int HashTableVal1 = (int)myHashTable["Kim"];
            int HashTableVal2 = (int)myHashTable["John"];
            int HashTableVal3 = (int)myHashTable["Max"];

            WriteLine(HashTableVal1);
            WriteLine(HashTableVal2);
            WriteLine(HashTableVal3);
        }
    }
}
