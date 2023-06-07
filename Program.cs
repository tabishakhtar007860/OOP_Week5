using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Task
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPoint myPoint = new MyPoint();
            MyLine myLine = null;
            MyPoint begin = takeInputForBegin();
            MyPoint end = takeInputForEnd();
            MyLine line = new MyLine(begin, end);
           double totalDistance = begin.distanceWithCord(end.x, end.y);
            Console.WriteLine(totalDistance);
            Console.Read();
           string option;
            do
            {
                Console.Clear();
                option = menu();
                if (option == "1")
                {
                    
                    drawLine(totalDistance);
                }
                else if (option == "2")
                {
                    updateTheBeginPoint(line);
                    Console.ReadKey();
                }
                else if (option == "3")
                {
                    updateTheEndPoint(myLine);
                    Console.ReadKey();

                }
                else if (option == "4")
                {
                    ShowBeginPoint(myLine);
                    Console.ReadKey();

                }
                else if (option == "5")
                {
                    showEndPoint(myLine);
                    Console.ReadKey();

                }
                else if (option == "6")
                {
                     getLength(totalDistance);
                    Console.ReadKey();
                }
                else if (option == "7")
                {
                    PrintGradientOfLine(line);
                    Console.ReadKey();

                }
                else if (option == "8")
                {
                    Console.WriteLine("Distance of begin point From Zero is" + begin.distanceFromZero());
                    Console.ReadKey();

                }
                else if (option == "9")
                {
                    Console.WriteLine("Distance of end point From Zero is" + end.distanceFromZero());
                    Console.ReadKey();


                }
            }
            while (option != "10");

        }
        static string menu()
        {
            Console.WriteLine("  1.Make a Line ");
            Console.WriteLine("2.Update the begin point");
            Console.WriteLine("3.Update the end point");
            Console.WriteLine("4.Show the begin Point");
            Console.WriteLine("5.Show the end point");
            Console.WriteLine("6.Get the Length of the line");
            Console.WriteLine("7.Get the Gradient of the Line");
            Console.WriteLine("8.Find the distance of begin point from zero coordinates");
            Console.WriteLine("9.Find the distance of end point from zero coordinates");
            Console.WriteLine("10.Exit ");
            string option = (Console.ReadLine());
            return option;
        }


        static MyPoint takeInputForBegin()
        {
            Console.WriteLine("Enter Begin  x1 >");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Begin y1 >");
            int y1 = int.Parse(Console.ReadLine());
            MyPoint begin = new MyPoint(x1, y1);
            return begin;
        }
        static MyPoint takeInputForEnd()
        { 
            Console.WriteLine("Enter End x2 >");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter End y2");
            int y2 = int.Parse(Console.ReadLine());
            MyPoint end = new MyPoint(x2, y2);
            return end;
        }
        
        static void drawLine (double distance)
        {


            for (int x = 0; x < distance; x++)
            {

                Console.Write("_");
            
            }

            Console.WriteLine();
            Console.Read();

        }
        static void updateTheBeginPoint(MyLine line )
        {
            Console.WriteLine("Enter New begining x1 Point");
            line.begin.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter New Begining y1 point >");
            line.begin.y = int.Parse(Console.ReadLine());
        }
        static void updateTheEndPoint(MyLine Line)
        {
            Console.WriteLine("Enter Ending Point x2 >");
            Line.ending.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter New ending y2 point >");
            Line.ending.y = int.Parse(Console.ReadLine());
        }
        static void ShowBeginPoint(MyLine Line)
        {
            Console.WriteLine("Begin x1 = " + Line.begin.getX());
            Console.WriteLine("Begin y1 = " + Line.begin.getY());

        }
        static void showEndPoint(MyLine Line)
        {
            Console.WriteLine("End x2 = " + Line.ending.getX());
            Console.WriteLine("End y2 = " + Line.ending.getY());
        }
       static void getLength(double length)
        {
            Console.WriteLine("Length of Line is>" + length);
        }
        static void PrintGradientOfLine(MyLine line)
        {
          Console.WriteLine( "Gradient of Line is >" + line.getGradientOfLine());
        }
        








    }
}
