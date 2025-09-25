
namespace HealthClinic.models;

public class Hospital
{
    public Guid IdHospital { get; set; }
    public string? NameHospital { get; set; }
    public List<Patient> Patients { get; set; }


    public Hospital(string NameHosp)
    {
        IdHospital = Guid.NewGuid();
        NameHospital = NameHosp;
        Patients = new List<Patient>();
    }
    
    public void AddPatient(Patient patient)
    {
        Patients.Add(patient);
    }

}
