using System.Numerics;

namespace Calculator
{
    public partial class CalculatorService<MYint>:ICalculator<MYint>
    where MYint : INumber<MYint>
    {
        public void Add(MYint a, MYint b)
        {
            Console.WriteLine(a + b);
        }

        public void Divide(MYint a, MYint b)
        {
            Console.WriteLine(a / b);
        }

        public void Divorse(MYint a, MYint b)
        {
            Console.WriteLine(a - b);
        }

        public void Multiply(MYint a, MYint b)
        {
            Console.WriteLine(a * b);
        }
    }
}
