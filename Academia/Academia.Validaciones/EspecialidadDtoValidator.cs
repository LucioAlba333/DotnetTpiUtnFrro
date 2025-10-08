using Academia.Dtos;
using FluentValidation;

namespace Academia.Validaciones;

public class EspecialidadDtoValidator : AbstractValidator<EspecialidadDto>
{
    public EspecialidadDtoValidator()
    {
        RuleFor(x => x.Descripcion)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("la descripcion es obligatoria y debe tener menos de 50 caracteres")
            .MaximumLength(50)
            .WithMessage("la descripcion es obligatoria y debe tener menos de 50 caracteres");
    }
}