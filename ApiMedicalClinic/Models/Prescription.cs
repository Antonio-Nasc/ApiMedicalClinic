using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiMedicalClinic.Models;

public class Prescription
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public  int MedicalRecordId { get; set; }
    public MedicalRecord? MedicalRecord { get; set; }
    [Required]
    [MaxLength(150)]
    public string? Medicine { get; set; }
    [Required]
    [MaxLength(80)]
    public string? Dosage { get; set; }
    [Required]
    [MaxLength(100)]
    public string? Frequency { get; set; }
    [Required]
    [MaxLength(100)]
    public string? Duration { get; set; }
}
