using ApiMedicalClinic.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.NetworkInformation;

namespace ApiMedicalClinic.Models;

public class Invoicing
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int ConsultationId { get; set; }
    public Consultation? Consultation { get; set; }
    [Required]
    [Column(TypeName = "decimal(10,2)")]
    public decimal Price { get; set; }
    [Required]
    public EStatus Status { get; set; }
    [Required]
    public EPaymentMethod PaymentMethod { get; set; }

}
