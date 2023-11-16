using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW_ShapeFactory.BL
{
    internal class Circle : IShape
    {
        public double Radius { get; set; }
        public double Diameter { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
            Diameter = radius * 2;
        }

        public double GetArea()
        {
            return float.Pi * (Radius * 2);
        }

        public void PrintInformation()
        {
            Console.WriteLine(
                $"{GetType().Name}" +
              $"\n - Radius: {Radius}" +
              $"\n - Diameter: {Diameter}" +
              $"\n - Area: {GetArea()}");
        }
    }
}
