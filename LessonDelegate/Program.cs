using LessonDelegate;
using System.Runtime.InteropServices;

public class Program 
{
    public delegate int Mydelegat(int a, int b);
    static void Main(string[] args) 
    {
        int a = 10;
        int b = 2;
        Methodelegate methodelegate = new Methodelegate();
        Mydelegat del = methodelegate.Add;
        Mydelegat del2 = methodelegate.Devays;
        Mydelegat del3 = methodelegate.Multiplay;
        Mydelegat del4 = methodelegate.Devays;

        Console.WriteLine(del(a, b));
        Console.WriteLine(del2(a, b));
        Console.WriteLine(del3(a, b));
        Console.WriteLine(del4(a, b));


    }
}