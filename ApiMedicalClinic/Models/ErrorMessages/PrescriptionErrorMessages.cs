namespace ApiMedicalClinic.Models.ErrorMessages;

public static class PrescriptionErrorMessages
{
    public static string InvalidFrequency => "The Frequency field is required.";
    public static string InvalidFrequencyLength => "The Frequency field must have a maximum of 100 characters.";
    public static string InvalidMedicine => "The Medicine field is required.";
    public static string InvalidMedicineLength => "The Medicine field must have a maximum of 150 characters.";
    public static string InvalidDosage => "The Dosage field is required.";
    public static string InvalidDosageLength => "The Dosage field must have a maximum of 80 characters.";
    public static string InvalidDuration => "The Duration field is required.";
    public static string InvalidDurationLength => "The Duration field must have a maximum of 100 characters.";
}
