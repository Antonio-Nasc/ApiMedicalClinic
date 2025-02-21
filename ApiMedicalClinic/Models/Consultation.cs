namespace ApiMedicalClinic.Models;

public class Consultation
{
    public int Id { get; set; }
    public int PatientId { get; set; }
    public Patient? Patient { get; set; }
    public int DoctorId { get; set; }
    public Doctor? Doctor { get; set; }
    public DateTime Date { get; set; }
}
