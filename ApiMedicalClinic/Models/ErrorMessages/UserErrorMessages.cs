namespace ApiMedicalClinic.Models.ErrorMessages
{
    public static class UserErrorMessages
    {
        public static string InvalidName => "The Name field is required.";
        public static string InvalidNameLength => "The Name field must have a maximum of 100 characters.";
        public static string InvalidEmail => "The Email field is required.";
        public static string InvalidEmailLength => "The Email field must have a maximum of 100 characters.";
        public static string InvalidPassword => "The Password field is required.";
        public static string InvalidPasswordLength => "The Password field must have a maximum of 100 characters.";
        public static string InvalidPhone => "The Phone field is required.";
        public static string InvalidPhoneLength => "The Phone field must have a maximum of 11 characters.";
        public static string InvalidDocument => "The Document field is required.";
        public static string InvalidDocumentLength => "The Document field must have a maximum of 14 characters.";
        public static string InvalidBirthDate => "The Birth Date field is required.";
        public static string InvalidProfile => "The Profile field is required.";

    }
}
