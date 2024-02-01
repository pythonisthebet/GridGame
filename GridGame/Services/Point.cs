using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridGame.Services
{
    public class Point
    {
        private int X { get; set; }
        private int Y { get; set; }

        public Point() { X = 0; Y = 0; }
        public Point(int x, int y) 
        {
            try
            {
                X=x; Y=y;
                if (x < 0 || y < 0 || x > 50 || y > 50)
                {
                    throw new Exception();
                }
            }
            catch
            {
                X = 0;
                Y = 0;
            }
        }


    }
}
