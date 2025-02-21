using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiMedicalClinic.Models;

public class MedicalRecord
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int PatientId { get; set; }
    public Patient? Patient { get; set; }
    public DateTime DateCreated { get; set; }
    [Required]
    [MaxLength(180)]
    public string? Annotation { get; set; }
    public ICollection<Prescription>? Prescriptions { get; set; }
}
