namespace ApiMedicalClinic.Models.ErrorMessages;

public static class MedicalRecordErrorMessages
{
    public static string InvalidAnnotation => "The Annotation field is required.";
    public static string InvalidAnnotationLength => "The Annotation field must have a maximum of 180 characters.";
}
