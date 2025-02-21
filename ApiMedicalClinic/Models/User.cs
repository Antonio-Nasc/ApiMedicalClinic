using ApiMedicalClinic.Enum;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiMedicalClinic.Models;

public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    public string? Name { get; set; }
    [Required]
    [MaxLength(100)]
    public string? Email { get; set; }
    [Required]
    [MaxLength(100)]
    public string? Password { get; set; }
    [Required]
    [MaxLength(11)]
    public string? Phone { get; set; }
    [Required]
    [MaxLength(14)]
    public string? Document { get; set; }
    [Required]
    public DateTime BirthDate { get; set; }
    [Required]
    public EProfile Profile { get; set; }
    public ICollection<Doctor>? Doctors { get; set; }
    public ICollection<Patient>? Patients { get; set; }
}
