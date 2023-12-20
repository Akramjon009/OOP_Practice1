using System.Collections.Generic;

public class Doctor : Person
{
    public int Id { get; }
    public string Specialization { get; }
    public List<string> Patients { get; }

    public Doctor(string name, string surname, string ssn, int id, string specialization)
        : base(name, surname, ssn)
    {
        Id = id;
        Specialization = specialization;
        Patients = new List<string>();
    }
}
