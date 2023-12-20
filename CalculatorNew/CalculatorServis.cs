using System.Numerics;

namespace Calculator
{
    public partial class CalculatorService<MYint>
    {
        public MYint A { get; set; }  
        public MYint B { get; set; }  
        public CalculatorService(MYint a, MYint b)
        {
            MYint A = a;
            MYint B = b;
            Add(A, B);
            Divide(A, B);
            Divorse(A, B);
            Multiply(A, B); 

        }

    }
}