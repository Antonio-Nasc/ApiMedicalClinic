namespace ApiMedicalClinic.Models;

public class Doctor
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? CRM { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public int SpecializationId { get; set; }
    public Specialization? Specialization { get; set; }
    public int AddressId { get; set; }
    public Address? Address { get; set; }
    public int? UserId { get; set; }
    public User? User { get; set; }

}
