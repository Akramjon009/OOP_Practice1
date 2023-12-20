using Calculator;
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
ICalculator<int> calculator = new CalculatorService<int>(1, 2); 
