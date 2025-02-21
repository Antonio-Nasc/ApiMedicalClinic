namespace ApiMedicalClinic.Models.ErrorMessages;

public static class AddressErrorMessages
{
    public static string InvalidStreet => "The Street field is required.";
    public static string InvalidStreetLength => "The Street field must have a maximum of 180 characters.";
    public static string InvalidNumber => "The Number field is required.";
    public static string InvalidNumberLength => "The Number field must have a maximum of 10 characters.";
    public static string InvalidComplementLength => "The Complement field must have a maximum of 300 characters.";
    public static string InvalidNeighborhood => "The Neighborhood field is required.";
    public static string InvalidNeighborhoodLength => "The Neighborhood field must have a maximum of 120 characters.";
    public static string InvalidCity => "The City field is required.";
    public static string InvalidCityLength => "The City field must have a maximum of 120 characters.";
    public static string InvalidState => "The State field is required.";
    public static string InvalidStateLength => "The State field must have a maximum of 2 characters.";
    public static string InvalidZipCode => "The ZipCode field is required.";
    public static string InvalidZipCodeLength => "The ZipCode field must have a maximum of 8 characters.";
}
