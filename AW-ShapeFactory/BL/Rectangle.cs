using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW_ShapeFactory.BL
{
    internal class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double GetArea()
        {
            return Height * Width;
        }

        public void PrintInformation()
        {
            Console.WriteLine(
                $"{GetType().Name}" +
              $"\n - Height: {Height}" +
              $"\n - Width: {Width}" +
              $"\n - Area: {GetArea()}");
        }
    }
}
