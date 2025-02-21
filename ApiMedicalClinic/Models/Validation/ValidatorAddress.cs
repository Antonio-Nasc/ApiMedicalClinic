using ApiMedicalClinic.Models.ErrorMessages;
using FluentValidation;

namespace ApiMedicalClinic.Models.Validation;

public class ValidatorAddress : AbstractValidator<Address>
{
    public ValidatorAddress()
    {
        RuleFor(a => a.Street)
            .NotEmpty().WithMessage(AddressErrorMessages.InvalidStreet)
            .MaximumLength(180).WithMessage(AddressErrorMessages.InvalidStreetLength);
        RuleFor(a => a.Number)
            .NotEmpty().WithMessage(AddressErrorMessages.InvalidNumber)
            .MaximumLength(10).WithMessage(AddressErrorMessages.InvalidNumberLength);
        RuleFor(a => a.Complement)
            .MaximumLength(300).WithMessage(AddressErrorMessages.InvalidComplementLength);
        RuleFor(a => a.Neighborhood)
            .NotEmpty().WithMessage(AddressErrorMessages.InvalidNeighborhood)
            .MaximumLength(120).WithMessage(AddressErrorMessages.InvalidNeighborhoodLength);
        RuleFor(a => a.City)
            .NotEmpty().WithMessage(AddressErrorMessages.InvalidCity)
            .MaximumLength(120).WithMessage(AddressErrorMessages.InvalidCityLength);
        RuleFor(a => a.State)
            .NotEmpty().WithMessage(AddressErrorMessages.InvalidState)
            .MaximumLength(2).WithMessage(AddressErrorMessages.InvalidStateLength);
        RuleFor(a => a.ZipCode)
            .NotEmpty().WithMessage(AddressErrorMessages.InvalidZipCode)
            .MaximumLength(8).WithMessage(AddressErrorMessages.InvalidZipCodeLength);
    }
}
