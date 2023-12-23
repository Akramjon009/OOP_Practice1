internal class Project 
{
    static void Main(string[] args)
    {
        Mydelegat newdelegat = Mystring;
        newdelegat("string");
    }
    //delegat funksiyani parqmetr sfatida olishga yordam beradi
    public delegate void Mydelegat(string str);
    static void Mystring(string mystr) 
    {
        Console.WriteLine(mystr);
    }
}