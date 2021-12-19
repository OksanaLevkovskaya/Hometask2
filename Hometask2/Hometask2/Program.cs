using System;
using System.Collections.Generic;
using System.Linq;

namespace Hometask2
{
    public class Point

    {
        int x;
        int y;

        public Point(int x, int y) { this.x = x; this.y = y; }
      

        public static void Main(string[] args)
        {
         

            Point a = new Point(1, 2);
            Point b = new Point(2, 3);
            Point c = new Point(3, 4);
            Point d = new Point(4, 5);
            Point e = new Point(5, 6);
            Point f = new Point(1, 2);
            Point g = new Point(2, 3);
            Point h = new Point(3, 4);
            Point i = new Point(4, 5);
            Point j = new Point(5, 6);

            a.Print();
            b.Print();
            c.Print();
            d.Print();
            e.Print();
            f.Print();
            g.Print();
            h.Print();
            i.Print();
            j.Print();



        }
        public void Print()
        {
            Console.WriteLine($" Coordinate X: {x}  Coordinate Y: {y}");
        }

    }
   
}