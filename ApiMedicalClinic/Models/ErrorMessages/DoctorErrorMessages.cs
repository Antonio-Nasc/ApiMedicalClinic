namespace ApiMedicalClinic.Models.ErrorMessages;

public static class DoctorErrorMessages
{
    public static string InvalidName => "The Name field is required.";
    public static string InvalidNameLength => "The Name field must have a maximum of 180 characters.";
    public static string InvalidEmail => "The Email field is required.";
    public static string InvalidEmailLength => "The Email field must have a maximum of 100 characters.";
    public static string InvalidPhone => "The Phone field is required.";
    public static string InvalidPhoneLength => "The Phone field must have a maximum of 11 characters.";
    public static string InvalidCRM => "The CRM field is required.";
    public static string InvalidCRMLength => "The CRM field must have a maximum of 10 characters.";
}
