namespace ApiMedicalClinic.Models.ErrorMessages;

public static class SpecializationErrorMessages
{
    public static string InvalidName => "The Name field is required.";
    public static string InvalidNameLength => "The Name field must have a maximum of 180 characters.";
}
