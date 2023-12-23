using System.ComponentModel.Design;
using System.Globalization;

int? number = 1;
int? number1 = null;
int? resoult = number ?? number1;
Console.WriteLine(resoult);

int number3;
int number4;
int resoult5;
try 
{
    number3 = int.Parse(Console.ReadLine());
}
catch
{ 
    number4 = int.Parse(Console.ReadLine());
}


