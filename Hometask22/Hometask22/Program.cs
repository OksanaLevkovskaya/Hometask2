using System;
using System.Collections.Generic;
using System.Linq;

namespace Hometask22
{
    public class Point
    {
       

        static void Main(string[] args)

        {
            GraphPoints point1 = new GraphPoints ("P1", 1, 1);
            GraphPoints point2 = new GraphPoints ("P2", 2, 2);
            GraphPoints point3 = new GraphPoints ("P3",3,3);
            GraphPoints point4 = new GraphPoints("P1", 1, 1);
            GraphPoints point5 = new GraphPoints("P2", 2, 2);
            GraphPoints point6 = new GraphPoints("P3", 3, 3);
            GraphPoints point7 = new GraphPoints("P1", 1, 1);
            GraphPoints point8 = new GraphPoints("P2", 2, 2);
            GraphPoints point9 = new GraphPoints("P3", 3, 3);
            GraphPoints point10 = new GraphPoints("P1", 1, 1);

            GraphPoints [] graphPoints = { point1, point2, point3, point4, point5, point6,
                                           point7, point8, point9, point10};

            foreach (GraphPoints p in graphPoints)
            {
                Console.WriteLine (p.GetPoint());
            }

         

            
        }
    }
}