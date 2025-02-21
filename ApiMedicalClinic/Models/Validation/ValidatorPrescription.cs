using ApiMedicalClinic.Models.ErrorMessages;
using FluentValidation;

namespace ApiMedicalClinic.Models.Validation;

public class ValidatorPrescription : AbstractValidator<Prescription>
{
    public ValidatorPrescription()
    {
        RuleFor(a => a.Frequency).NotEmpty().WithMessage(PrescriptionErrorMessages.InvalidFrequency)
            .MaximumLength(100).WithMessage(PrescriptionErrorMessages.InvalidFrequencyLength);
        RuleFor(a => a.Medicine).NotEmpty().WithMessage(PrescriptionErrorMessages.InvalidMedicine)
            .MaximumLength(150).WithMessage(PrescriptionErrorMessages.InvalidMedicineLength);
        RuleFor(a => a.Dosage).NotEmpty().WithMessage(PrescriptionErrorMessages.InvalidDosage)
            .MaximumLength(80).WithMessage(PrescriptionErrorMessages.InvalidDosageLength);
        RuleFor(a => a.Duration).NotEmpty().WithMessage(PrescriptionErrorMessages.InvalidDuration)
            .MaximumLength(100).WithMessage(PrescriptionErrorMessages.InvalidDurationLength);
    }
}
