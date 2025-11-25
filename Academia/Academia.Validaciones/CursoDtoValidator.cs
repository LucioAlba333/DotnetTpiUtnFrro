using Academia.Dtos;
using FluentValidation;

namespace Academia.Validaciones;

public class CursoDtoValidator : AbstractValidator<CursoDto>
{
    public CursoDtoValidator()
    {
        RuleFor(x => x.AnioCalendario)
            .InclusiveBetween(DateTime.Now.Year, DateTime.Now.Year + 1)
            .WithMessage($"El año calendario debe estar entre {DateTime.Now.Year} y {DateTime.Now.Year + 1}");

        RuleFor(x => x.Cupo)
            .GreaterThan(0)
            .WithMessage("El cupo debe ser mayor que 0")
            .LessThanOrEqualTo(200)
            .WithMessage("El cupo no puede superar los 200");
    }

}