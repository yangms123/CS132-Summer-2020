using System;
using static System.Console;

namespace Date_Time
{
    class Program
    {
        void ShowTime()
        {
            DateTime currentDate = DateTime.Now;
            bool leapYear = DateTime.IsLeapYear(2020);
            WriteLine(currentDate);
            Write("2020 is a leapYear: ");
            WriteLine(leapYear);
        }
        void GetpersonalInfo()
        {
            WriteLine("Enter your name: ");
            string name = ReadLine();
            WriteLine("What year are you born?:");
            int birthYear = Convert.ToInt32(ReadLine());
            int age = Convert.ToInt32(DateTime.Now.Year) - birthYear;

            WriteLine("Here are what we know from your inputs: ");
            WriteLine("Your name is "+ name);
            WriteLine("Today is : "+ DateTime.Now.ToShortDateString());
            WriteLine("Your age :" +age);
        }
        void GetMonthAndDays()
        {
            int mon = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            WriteLine(mon);
            WriteLine(DateTime.DaysInMonth(year,mon));
        }
        static void Main(string[] args)
        {
            //create an object of class Program to access a method of that class, in this case, is the ShowTime() method
            Program MyProgram = new Program();
            //MyProgram.ShowTime();
            //MyProgram.GetpersonalInfo();
            MyProgram.GetMonthAndDays();

        }

    }
}
