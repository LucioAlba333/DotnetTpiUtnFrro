using Academia.Dtos;
using FluentValidation;

namespace Academia.Validaciones;

public class PersonaDtoValidator : AbstractValidator<PersonaDto>
{
    public PersonaDtoValidator()
    {
        RuleFor(p => p.Apellido)
            .NotEmpty()
            .MaximumLength(50)
            .WithMessage("el apellido debe tener menos de 50 caracteres");
        RuleFor(p => p.Email)
            .NotEmpty()
            .EmailAddress();
        RuleFor(p => p.Nombre)
            .NotEmpty()
            .MaximumLength(50)
            .WithMessage("el nombre debe tener menos de 50 caracteres");
        RuleFor(p => p.FechaNacimiento)
            .Must(ValidDate)
            .WithMessage("la fecha de nacimiento no es valida");
    }
    private bool ValidDate(DateTime date)
    {
        return date < new DateTime(1900, 01, 01) || date > DateTime.Now;
    }
}