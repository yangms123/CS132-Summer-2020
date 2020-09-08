using System;
using System.Collections;
using static System.Console;

namespace Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            //create Arraylist using built in library
            ArrayList myArrList = new ArrayList();

            //add values to Array List using AddRange() method.
            myArrList.Add(10);
            myArrList.Add(11.5);
            myArrList.Add("This is a string");

            //Add values to Array List using Addrange() method
            myArrList.AddRange(new ArrayList() {20,17.7,"This is another string " });

            myArrList.Remove(10);
            myArrList.RemoveAt(0);
            myArrList.RemoveRange(1, 2);

            //print each value in the array list using foreach() method
            foreach (var value in myArrList) {
                WriteLine(value);
            }
        }
    }
}
