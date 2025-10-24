using Academia.Dtos;
using FluentValidation;

namespace Academia.Validaciones;

public class CursoDtoValidator : AbstractValidator<CursoDto>
{
    public CursoDtoValidator()
    {
        
        RuleFor(x => x.AnioCalendario)
            .InclusiveBetween(DateTime.Now.Year, DateTime.Now.Year + 1)
            .WithMessage($"el año calendario debe estar entre {DateTime.Now.Year} y {DateTime.Now.Year + 1}");

        RuleFor(x => x.Cupo)
            .GreaterThanOrEqualTo(0)
            .WithMessage("el cupo no puede ser negativo");
    }
}