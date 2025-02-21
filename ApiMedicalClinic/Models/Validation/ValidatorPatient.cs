using ApiMedicalClinic.Models.ErrorMessages;
using FluentValidation;

namespace ApiMedicalClinic.Models.Validation;

public class ValidatorPatient : AbstractValidator<Patient>
{
    public ValidatorPatient()
    {
        RuleFor(p => p.Name)
            .NotEmpty().WithMessage(PatientErrorMessages.InvalidName)
            .MaximumLength(100).WithMessage(PatientErrorMessages.InvalidNameLength);
        RuleFor(p => p.Email)
            .NotEmpty().WithMessage(PatientErrorMessages.InvalidEmail)
            .EmailAddress().WithMessage(PatientErrorMessages.InvalidEmailLength);
        RuleFor(p => p.CellPhone)
            .NotEmpty().WithMessage(PatientErrorMessages.InvalidPhone)
            .MaximumLength(11).WithMessage(PatientErrorMessages.InvalidPhoneLength);
        RuleFor(p => p.CPF)
            .NotEmpty().WithMessage(PatientErrorMessages.InvalidDocument)
            .MaximumLength(11).WithMessage(PatientErrorMessages.InvalidDocumentLength);
        RuleFor(p => p.DateBirth)
            .NotEmpty().WithMessage(PatientErrorMessages.InvalidBirthDate);
        RuleFor(p => p.SexualType)
            .NotEmpty().WithMessage(PatientErrorMessages.InvalidSexualType);

    }
}
