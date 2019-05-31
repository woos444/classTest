using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Rectangle rect1;
             rect1.leng = 100;
             rect1.wid = 30;

             Console.WriteLine("rect leng : {0}, wid :{1}", rect1.leng, rect1.wid);

             Rectangle rect2 = new Rectangle(200,50);
             Console.WriteLine("rect leng : {0}, wid :{1}, Area :{2} ", rect2.leng, rect2.wid, rect2.Area());
             */


            Animal fox = new Animal("fox","Raaww");
            fox.MakeSound();
            Animal a = new Animal("Wolf","Walllll");
            a.MakeSound();
            Animal b = new Animal("bar","GomGom");
            b.MakeSound();

            Console.WriteLine("{0}", ShapeMath.GetArea("Rectangle",4,6));
            Console.WriteLine("{0}", ShapeMath.GetArea("Triangle", 4, 6));
            Console.WriteLine("{0}", ShapeMath.GetArea("Circle", 4));


            Console.ReadLine();




        }

        struct Rectangle
        {
            public double leng;
            public double wid;

            public Rectangle(double l,double w)
            {
                leng = l;
                wid = w;
            }

            public double Area()
            {
                return leng * wid;
            }

        }
    }
}
