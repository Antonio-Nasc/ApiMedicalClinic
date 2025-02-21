using ApiMedicalClinic.Enum;
using System.Net.NetworkInformation;

namespace ApiMedicalClinic.Models;

public class Invoicing
{
    public int Id { get; set; }
    public int ConsultationId { get; set; }
    public Consultation? Consultation { get; set; }
    public decimal Price { get; set; }
    public EStatus Status { get; set; }
    public EPaymentMethod PaymentMethod { get; set; }

}
