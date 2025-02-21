using ApiMedicalClinic.Models.ErrorMessages;
using FluentValidation;

namespace ApiMedicalClinic.Models.Validation;

public class ValidatorDoctor : AbstractValidator<Doctor>
{
    public ValidatorDoctor()
    {
        RuleFor(a => a.Name)
            .NotEmpty().WithMessage(DoctorErrorMessages.InvalidName)
            .MaximumLength(100).WithMessage(DoctorErrorMessages.InvalidNameLength);
        RuleFor(a => a.Email)
            .NotEmpty().WithMessage(DoctorErrorMessages.InvalidEmail)
            .EmailAddress().WithMessage(DoctorErrorMessages.InvalidEmailLength);
        RuleFor(a => a.Phone)
            .NotEmpty().WithMessage(DoctorErrorMessages.InvalidPhone)
            .MaximumLength(11).WithMessage(DoctorErrorMessages.InvalidPhoneLength);
        RuleFor(a => a.CRM)
            .NotEmpty().WithMessage(DoctorErrorMessages.InvalidCRM)
            .MaximumLength(10).WithMessage(DoctorErrorMessages.InvalidCRMLength);
    }
}
