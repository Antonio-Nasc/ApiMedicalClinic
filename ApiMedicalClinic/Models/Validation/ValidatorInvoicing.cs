using ApiMedicalClinic.Models.ErrorMessages;
using FluentValidation;

namespace ApiMedicalClinic.Models.Validation;

public class ValidatorInvoicing : AbstractValidator<Invoicing>
{
    public ValidatorInvoicing()
    {
        RuleFor(i => i.Price)
            .NotEmpty().WithMessage(InvoicingErrorMessages.InvalidPrice);
        RuleFor(i => i.Status)
            .NotEmpty().WithMessage(InvoicingErrorMessages.InvalidStatus);
        RuleFor(i => i.PaymentMethod)
            .NotEmpty().WithMessage(InvoicingErrorMessages.InvalidPaymentMethod);
    }
}
