namespace ApiMedicalClinic.Models.ErrorMessages;

public static class InvoicingErrorMessages
{
    public static string InvalidPrice => "The Price field is required.";
    public static string InvalidStatus => "The Status field is required.";
    public static string InvalidPaymentMethod => "The Payment Method field is required.";
}
