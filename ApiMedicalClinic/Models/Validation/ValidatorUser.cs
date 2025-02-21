using ApiMedicalClinic.Models.ErrorMessages;
using FluentValidation;

namespace ApiMedicalClinic.Models.Validation;

public class ValidatorUser : AbstractValidator<User>
{
    public ValidatorUser()
    {
        RuleFor(u => u.Name)
            .NotEmpty().WithMessage(UserErrorMessages.InvalidName)
            .MaximumLength(100).WithMessage(UserErrorMessages.InvalidNameLength);
        RuleFor(u => u.Email)
            .NotEmpty().WithMessage(UserErrorMessages.InvalidEmail)
            .EmailAddress().WithMessage(UserErrorMessages.InvalidEmailLength);
        RuleFor(u => u.Password)
            .NotEmpty().WithMessage(UserErrorMessages.InvalidPassword)
            .MaximumLength(100).WithMessage(UserErrorMessages.InvalidPasswordLength);
        RuleFor(u => u.Phone)
            .NotEmpty().WithMessage(UserErrorMessages.InvalidPhone)
            .MaximumLength(11).WithMessage(UserErrorMessages.InvalidPhoneLength);
        RuleFor(u => u.Document)
           .NotEmpty().WithMessage(UserErrorMessages.InvalidDocument)
           .MaximumLength(14).WithMessage(UserErrorMessages.InvalidDocumentLength);
        RuleFor(u => u.BirthDate)
          .NotEmpty().WithMessage(UserErrorMessages.InvalidBirthDate);
        RuleFor(u => u.Profile)
         .NotEmpty().WithMessage(UserErrorMessages.InvalidProfile);
    }
}
