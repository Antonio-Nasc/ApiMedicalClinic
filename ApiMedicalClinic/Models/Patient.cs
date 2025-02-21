using ApiMedicalClinic.Enum;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiMedicalClinic.Models;

public class Patient
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    public string? Name { get; set; }
    [Required]
    [MaxLength(11)]
    public string? CPF { get; set; }
    [Required]
    public DateTime DateBirth { get; set; }
    [Required]
    public Sexuality SexualType { get; set; }
    [Required]
    [MaxLength(11)]
    public string? CellPhone { get; set; }
    [Required]
    [MaxLength(100)]
    public string? Email { get; set; }
    public int AddressId { get; set; }
    public Address? Address { get; set; }
    public int? UserId { get; set; }
    public User? User { get; set; }

}
