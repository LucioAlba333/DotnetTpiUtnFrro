using Academia.Dtos;
using FluentValidation;

namespace Academia.Validaciones;

public class EspecialidadDtoValidator : AbstractValidator<EspecialidadDto>
{
    public EspecialidadDtoValidator()
    {
        RuleFor(x=> x.Id)
            .LessThanOrEqualTo(0).WithMessage("El id solo puede ser mayor a 0");
        RuleFor(x => x.Descripcion)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .MaximumLength(50)
            .WithMessage("la descripcion es obligatoria y debe tener menos de 50 caracteres");
    }
}