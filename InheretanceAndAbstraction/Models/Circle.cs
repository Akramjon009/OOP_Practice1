namespace InheretanceAndAbstraction.Models
{
    public class Circle : Shape
    {
        private double radius;
        public Circle(double radius, double x, double y) : base(x, y)
        {
            this.radius = radius;
        }
        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
