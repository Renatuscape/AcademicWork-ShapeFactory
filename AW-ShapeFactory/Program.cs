using AW_ShapeFactory.BL;

namespace AW_ShapeFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory.CreateShape(ShapeType.Rectangle, new double[] { 5, 3}).PrintInformation();
            ShapeFactory.CreateShape(ShapeType.Triangle, new double[] { 7, 8 }).PrintInformation();
            ShapeFactory.CreateShape(ShapeType.Circle, new double[] { 4 }).PrintInformation();
        }
    }
}