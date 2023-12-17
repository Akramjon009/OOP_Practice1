namespace InheretanceAndAbstraction.Models
{
    public class Rectengular : Shape
    {
        private double width;
        private double height;

        public Rectengular(double width, double height, double x, double y) : base(x, y)
        {
            this.width = width;
            this.height = height;

        }

        public override double CalculateArea()
        {
            return width * height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (width + height);
        }
    }
}
