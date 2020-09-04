using System;
using System.Runtime.InteropServices;
using static System.Console;

namespace Inheritance
{
    
    class Program
    {
        class Shapes // create class named Shapes with below properties
        {
            public double length;
            public double width;
            public double radius;
            public void DisplayProperties() {
                WriteLine("Base length is " + length);
                WriteLine("Base width is " + width);
                WriteLine("Base radius is " + radius);
                WriteLine("\n");
            }
        }
        class Rectangle : Shapes { //Rectangle class derived fron shapes base class
            public void CalArea(double l, double w)
            {
                length = l;
                width = w;
                double RecArea = w * l;
                WriteLine("Rectangle length is: "+ length);
                WriteLine("Rectangle width is: " + width);
                WriteLine("Rectangle Area is: "+ RecArea);
            }

        }
        class Square : Shapes { //Square class derived fron shapes base class
            public void CalArea(double a) {
                length = a;
                double SqArea = a * a;
                WriteLine("Square side length is: " + a);
                WriteLine("Square Area is: " + SqArea);
            }
        }
        class Circle : Shapes { //circle class derived from Shapes base class
            public void CalArea(double r) {
                radius = r;
                double CirArea = 3.15*r*r;
                WriteLine("Circle radius is: " + radius);
                WriteLine("Circle Area is: " + CirArea);
            }
        }

        static void Main(string[] args)
        {
            Rectangle MyRec = new Rectangle();// object MyRec of class Rectangle
            Square MySq = new Square();//object MySq of class Square
            Circle MyCir = new Circle();// objecy MyCir of class Circle

            //using objects to call properties of its classes. since all Rectangle,Square and Circle classes
            //are derived from base class Shapes, all of those classes have access to Shapes' properties
            //making thier objects also able to access
            //length, width and Radius, which are the properties of base class Shapes
            //WriteLine("Base length is " + MyRec.length);
            //WriteLine("Base width is " + MyRec.width);
            //WriteLine("Base radius is " + MyCir.radius);
            //WriteLine("\n");

            //challenge
            MySq.DisplayProperties();
            MyRec.CalArea(3,4);
            WriteLine("\n");
            MySq.CalArea(10);
            WriteLine("\n");
            MyCir.CalArea(8);

        }
        

    }
}
