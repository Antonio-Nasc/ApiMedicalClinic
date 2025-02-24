using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiMedicalClinic.Models;

public class Doctor
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    public string? Name { get; set; }
    [Required]
    [MaxLength(10)]
    public string? CRM { get; set; }
    [Required]
    [MaxLength(11)]
    public string? Phone { get; set; }
    [Required]
    [MaxLength(100)]
    public string? Email { get; set; }
    public int SpecializationId { get; set; }
    public Specialization? Specialization { get; set; }
    [Required]
    public int AddressId { get; set; }
    [Required]
    public Address? Address { get; set; }
    public int? UserId { get; set; }
    public User? User { get; set; }

}
