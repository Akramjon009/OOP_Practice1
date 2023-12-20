namespace Calculator
{
    public interface ICalculator<MYint>
    {
        public void Multiply(MYint a, MYint b);
        public void Divide(MYint a, MYint b);
        public void Add(MYint a, MYint b);
        public void Divorse(MYint a, MYint b);
    }
}
