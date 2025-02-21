namespace ApiMedicalClinic.Models;

public class MedicalRecord
{
    public int Id { get; set; }
    public int PatientId { get; set; }
    public Patient? Patient { get; set; }
    public DateTime DateCreated { get; set; }
    public string? Annotation { get; set; }
    public ICollection<Prescription>? Prescriptions { get; set; }
}
