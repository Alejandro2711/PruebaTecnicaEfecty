using FluentValidation;
using PruebaTecnica.Domain.Entities.Prueba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Services.Validators
{
    public class PruebaValidator : AbstractValidator<PruebaModel>
    {
        public PruebaValidator()
        {

            RuleFor(p => p.Nombre)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("Debe indicar el Nombre");

            RuleFor(p => p.Apellidos)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("Debe indicar los Apellidos");

            RuleFor(p => p.TipoDocumento)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .WithMessage("Debe indicar el tipo de documento");

            RuleFor(p => p.FechaNacimiento)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .WithMessage("Debe indicar la fecha de nacimiento");

            RuleFor(p => p.EstadoCivil)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .WithMessage("Debe indicar el estado civil");
        }
    }
}
