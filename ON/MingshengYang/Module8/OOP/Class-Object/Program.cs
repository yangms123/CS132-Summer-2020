using System;
using System.Runtime.InteropServices.ComTypes;
using static System.Console;

namespace Class_Object
{
    class Shapes // create class named Shapes with below properties
    {
        public double length;
        public double width;
        public double radius;
        const double PI = 3.15;
        public double CalArea(double l, double w)
        {
            length = l;
            width = w;
            double Area = w * l;
            return Area;
        }

        public double CalCircleArea(double r)
        {
            radius = r;
            return r * r * PI;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            double RecWidth = 7;
            double RecLength = 8;
            double SqWidth = 2;
            double CircleRadius = 3;

            Shapes Rectangle = new Shapes();// create instance /object of calss Shapes, named Rectangle
            Shapes Square = new Shapes();// create instance /object of calss Shapes, named Square
            Shapes Circle = new Shapes();
            // use Object Rectangle to call method CalArea of class Shapes
            WriteLine("Area of Rectangle is: " + Rectangle.CalArea(RecLength,RecWidth));

            // use Object Square to call method CalArea of class Shapes
            WriteLine("Area of Square is: " + Square.CalArea(SqWidth, SqWidth));

            WriteLine("Area of Circle is: " + Circle.CalCircleArea(CircleRadius));
        }
    }
}
