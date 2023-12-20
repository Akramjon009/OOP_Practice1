public class Person
{
    public string Name { get; }
    public string Surname { get; }
    public string SSN { get; }

    public Person(string name, string surname, string ssn)
    {
        Name = name;
        Surname = surname;
        SSN = ssn;
    }

    public string GetDoctor()
    {
        // Реализуйте этот метод для получения назначенного врача
        return null;
    }
}
