using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    //Struct
    //a struct is a value type that is tipically used to incapsulate small
    //groups of related variables
    //they dont need the new keyword to be instantiated
    //they dont support inheritance
    //they cannot contain virtual methods
    //they can have some methods eg vector3 in unity has magnitude or normalized method
    //also can contain indexes and properties
    //they cannot contain default constructors but they can have contructors that take parameters
    //in that case they need the "new" keyword

    // hint: all c#types are structs: int, double, bool etc...

    class Program
    {
        static void Main(string[] args)
        {
            Book b;
            b.title = "Cars and Farts";
            b.price = 19.90;
            b.author = "Gass Mann";
            Console.WriteLine(b.title);

            Point p = new Point(1, 2);
            Console.WriteLine(p.x);

            Console.ReadKey();

        }
    }

    struct Book
    {
        public string title;
        public double price;
        public string author;
    }

    struct Point
    {
        public int x;
        public int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
