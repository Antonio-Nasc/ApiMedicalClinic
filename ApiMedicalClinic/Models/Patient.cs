using ApiMedicalClinic.Enum;

namespace ApiMedicalClinic.Models;

public class Patient
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? CPF { get; set; }
    public DateTime DateBirth { get; set; }
    public Sexuality SexualType { get; set; }
    public string? CellPhone { get; set; }
    public string? Email { get; set; }
    public int AddressId { get; set; }
    public Address? Address { get; set; }
    public int? UserId { get; set; }
    public User? User { get; set; }

}
