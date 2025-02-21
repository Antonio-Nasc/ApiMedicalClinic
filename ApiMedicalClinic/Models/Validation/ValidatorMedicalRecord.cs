using ApiMedicalClinic.Models.ErrorMessages;
using FluentValidation;

namespace ApiMedicalClinic.Models.Validation;

public class ValidatorMedicalRecord : AbstractValidator<MedicalRecord>
{
    public ValidatorMedicalRecord()
    {
        RuleFor(m => m.Annotation)
            .NotEmpty().WithMessage(MedicalRecordErrorMessages.InvalidAnnotation)
            .MaximumLength(180).WithMessage(MedicalRecordErrorMessages.InvalidAnnotationLength);
    }
}
