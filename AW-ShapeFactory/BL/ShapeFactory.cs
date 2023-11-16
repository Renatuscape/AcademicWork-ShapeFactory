using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW_ShapeFactory.BL
{
    internal static class ShapeFactory
    {
        public static IShape CreateShape(ShapeType type, double[] properties)
        {
            if (type is ShapeType.Rectangle)
            {
                return new Rectangle(properties[0], properties[1]);
            }
            else if (type is ShapeType.Triangle)
            {
                return new Triangle(properties[0], properties[1]);
            }
            else
            {
                return new Circle(properties[0]);
            }
        }
    }
}