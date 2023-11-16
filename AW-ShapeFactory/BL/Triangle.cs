using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW_ShapeFactory.BL
{
    internal class Triangle : IShape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double width, double height)
        {
            Base = width;
            Height = height;
        }

        public double GetArea()
        {
            return Height * Base / 2;
        }

        public void PrintInformation()
        {
            Console.WriteLine(
                $"{GetType().Name}" +
              $"\n - Base: {Base}" +
              $"\n - Height: {Height}" +
              $"\n - Area: {GetArea()}");
        }
    }
}
