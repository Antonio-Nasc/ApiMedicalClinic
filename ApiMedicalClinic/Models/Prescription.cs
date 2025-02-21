namespace ApiMedicalClinic.Models;

public class Prescription
{
    public int Id { get; set; }
    public  int MedicalRecordId { get; set; }
    public MedicalRecord? MedicalRecord { get; set; }
    public string? Medicine { get; set; }
    public string? Dosage { get; set; }
    public string? Frequency { get; set; }
    public string? Duration { get; set; }
}
