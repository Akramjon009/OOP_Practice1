namespace Hospital;
    using System;
    using System.Collections.Generic;

    public class NoSuchPatientException : Exception
    {
        public NoSuchPatientException(string message) : base(message)
        {
        }
    }

    public class NoSuchDoctorException : Exception
    {
        public NoSuchDoctorException(string message) : base(message)
        {
        }
    }

    public class Clinic
    {
        private List<Person> patients;
        private List<Doctor> doctors;

        public Clinic()
        {
            patients = new List<Person>();
            doctors = new List<Doctor>();
        }

        public void AddPatient(Person patient)
        {
            patients.Add(patient);
        }

        public Person GetPatient(string ssn)
        {
            foreach (Person patient in patients)
            {
                if (patient.SSN.Equals(ssn))
                {
                    return patient;
                }
            }
            throw new NoSuchPatientException("Пациент не найден");
        }   

}
