using Academia.Dtos;
using FluentValidation;

namespace Academia.Validaciones;

public class PlanDtoValidator: AbstractValidator<PlanDto>
{
    public PlanDtoValidator()
    {
        RuleFor(p=> p.Descripcion)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .MaximumLength(50)
            .WithMessage("la descripcion es obligatoria y debe tener menos de 50 caracteres");
    }
}