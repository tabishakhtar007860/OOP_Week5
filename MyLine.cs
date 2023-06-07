using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Task
{
    class MyLine
    {
       public MyPoint begin ;
       public MyPoint ending ;
        public MyLine()
        {

        }
        public MyLine(MyPoint begin, MyPoint end)
        {
            this.begin = begin;
            this.ending = end;
        }
        public MyLine(MyPoint ending,string name)
        {
            this.ending = ending;
        }
         public double getGradientOfLine()
        {
            double gradient = (ending.y - begin.y) / (ending.x - begin.x);
            return gradient;
        }
    
    }
}
