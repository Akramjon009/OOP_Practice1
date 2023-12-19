namespace Calculator
{
    public partial class CalculatorService
    {
        public CalculatorService(int a, int b)
        {
            int A = a;
            int B = b;
            Add(A, B);
            Divide(A, B);
            Divorse(A, B);
            Multiply(A, B); 

        }
        public int A { get; set; }  
        public int B { get; set; }  

    }
}