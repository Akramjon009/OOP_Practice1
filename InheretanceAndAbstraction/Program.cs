using InheretanceAndAbstraction.Models;

namespace InheretanceAndAbstraction
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var uchburchak = new Triangle(3, 4, 5, 9, 7);
            Console.WriteLine(uchburchak.CalculateArea());
            Console.WriteLine(uchburchak.CalculateArea());

            var tortburchak = new Rectengular(2, 2, 2, 2);
            Console.WriteLine(tortburchak.CalculatePerimeter());
            Console.WriteLine(tortburchak.CalculateArea());

            var dumaloq = new Circle(8, 4, 5);
            Console.WriteLine(dumaloq.CalculatePerimeter());
            Console.WriteLine(dumaloq.CalculateArea());

        }
    }
}