using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiMedicalClinic.Models;

public class Address
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    [MaxLength(180)]
    public string? Street { get; set; }
    [Required]
    [MaxLength(10)]
    public string? Number { get; set; }
    [MaxLength(300)]
    public string? Complement { get; set; }
    [Required]
    [MaxLength(120)]
    public string? Neighborhood { get; set; }
    [Required]
    [MaxLength(120)]
    public string? City { get; set; }
    [Required]
    [MaxLength(2)]
    public string? State { get; set; }
    [Required]
    [MaxLength(8)]
    public string? ZipCode { get; set; }
}
