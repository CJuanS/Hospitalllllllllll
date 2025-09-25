namespace HealthClinic.models;

public class Patient
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? Symptom { get; set; }

    public Patient(string NamePatient, int AgePatient, string SymptomPatient)
    {
        Id = Guid.NewGuid();
        Name = NamePatient;
        Age = AgePatient;
        Symptom = SymptomPatient;
    }

    public void ShowInformation()
    {
        Console.WriteLine();
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Symptom: {Symptom}");
        Console.WriteLine();
    }

}
