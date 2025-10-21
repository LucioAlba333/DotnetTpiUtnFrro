using Academia.Dtos;
using FluentValidation;

namespace Academia.Validaciones;

public class ComisionDtoValidator : AbstractValidator<ComisionDto>
{
    public ComisionDtoValidator()
    {
        RuleFor(x => x.Descripcion)
            .NotEmpty()
            .WithMessage("la descripcion es obligatoria y debe tener menos de 50 caracteres")
            .MaximumLength(50)
            .WithMessage("la descripcion es obligatoria y debe tener menos de 50 caracteres");
        RuleFor(x=>x.AnioEspecialidad)
            .InclusiveBetween(0,5)
            .WithMessage("el anio de especialidad debe estar entre 0 y 5");
    }
    
}