using ApiMedicalClinic.Models.ErrorMessages;
using FluentValidation;

namespace ApiMedicalClinic.Models.Validation
{
    public class ValidatorConsultation : AbstractValidator<Consultation>
    {
        public ValidatorConsultation() 
        {
            RuleFor(u => u.Date)
              .NotEmpty().WithMessage(ConsultationErrorMessages.InvalidDate);
        }
    }
}
