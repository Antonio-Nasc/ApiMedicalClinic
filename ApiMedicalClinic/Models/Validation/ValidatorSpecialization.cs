using ApiMedicalClinic.Models.ErrorMessages;
using FluentValidation;

namespace ApiMedicalClinic.Models.Validation;

public class ValidatorSpecialization : AbstractValidator<Specialization>
{
    public ValidatorSpecialization()
    {
        RuleFor(s => s.Name)
            .NotEmpty().WithMessage(SpecializationErrorMessages.InvalidName)
            .MaximumLength(100).WithMessage(SpecializationErrorMessages.InvalidNameLength);
    }
}
