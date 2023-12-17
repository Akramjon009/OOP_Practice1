using System.Drawing;

namespace InheretanceAndAbstraction.Models
{
    public abstract class Shape : Point
    {
        public Point CenterPoint;
        public Shape(double x, double y) : base(x, y)
        {
            CenterPoint = new Point(x, y);
        }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }
}
