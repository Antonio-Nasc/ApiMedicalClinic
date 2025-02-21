using ApiMedicalClinic.Enum;

namespace ApiMedicalClinic.Models;

public class User
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public string? Phone { get; set; }
    public string? Document { get; set; }
    public DateTime BirthDate { get; set; }
    public EProfile Profile { get; set; }
    public ICollection<Doctor>? Doctors { get; set; }
    public ICollection<Patient>? Patients { get; set; }
}
