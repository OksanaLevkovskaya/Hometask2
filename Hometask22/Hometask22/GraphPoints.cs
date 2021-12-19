using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask22
{
    public class GraphPoints
    {
        private string pointName;
        private int coordinateX;
        private int coordinateY;
    

    public GraphPoints (string pn, int cx, int cy)
        {
        pointName = pn;
        coordinateX = cx;
        coordinateY = cy;   

        }
        
        public string GetPoint()
        {
            return "Point Name is: " + pointName + ","
                    + " Coordinate X - " + coordinateX
                    + " Coordinate Y - " + coordinateY;
        }
    }
}
