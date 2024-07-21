using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_4.Interface
{
    public class Circle :ICircle
    {
        public double Radius { get;  set; }

        double ICircle.Radius { get; set; }
        double IShape.Area { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Area => Math.PI * Radius * Radius;

      

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle - Radius: {Radius}, Area: {Area}");
        }
    }
}
