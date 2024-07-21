using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_4.Interface
{
        public class Rectangle : IRectangle
        {
        public double Length { get ; set ; }
        public double Width { get; set; }
        double IShape.Area { get; set; }
        double Area => Length * Width;



        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
    

        public void DisplayShapeInfo()
            {
                Console.WriteLine($"Rectangle - Length: {Length}, Width: {Width}, Area: {Area}");
            }
        }
 }

