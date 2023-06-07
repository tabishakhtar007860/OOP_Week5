using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Task
{
    public  class MyPoint
    {
      public  int x ;
       public int y ;
    public MyPoint()
        {
            x = 0;
            y = 0;

        }
        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public double  distanceWithCord(int x1,int y1)
        {
        
            double distance = 0;
            distance = Math.Pow((x - x1),2) + Math.Pow((y - y1),2);
            distance = Math.Sqrt(distance);
            return distance;
        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
       public double distanceFromZero()
        {
            double distance;
            distance = Math.Pow((x - 0), 2) + Math.Pow((y - 0), 2);
            distance = Math.Sqrt(distance);
            return distance;
        }


    }
}
