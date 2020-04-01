using FluentValidation;
using PruebaNexos.MethodParameters.Paciente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNexos.Validators
{
    public class CreatePacienteValidator : AbstractValidator<CreatePacienteIn>
    {

        public CreatePacienteValidator()
        {
            RuleFor(paciente => paciente.Nombre)
           .Cascade(CascadeMode.Continue)
           .NotEmpty().WithMessage("El campo {PropertyName} es obligatorio.")
           .MaximumLength(120).WithMessage("El campo {PropertyName} no puede tener mas de 120 caracteres")
           .MinimumLength(3).WithMessage("El campo {PropertyName} no puede tener menos de 3 caracteres");

            RuleFor(paciente => paciente.NumeroSeguro)
           .Cascade(CascadeMode.Continue)
           .NotEmpty().WithMessage("El campo {PropertyName} es obligatorio.")
           .MaximumLength(50).WithMessage("El campo {PropertyName} no puede tener mas de 50 caracteres")
           .MinimumLength(3).WithMessage("El campo {PropertyName} no puede tener menos de 3 caracteres");

            RuleFor(paciente => paciente.MedicoPreferido)
          .Cascade(CascadeMode.Continue)
          .NotEmpty().WithMessage("El campo {PropertyName} es obligatorio.")
          .MaximumLength(120).WithMessage("El campo {PropertyName} no puede tener mas de 120 caracteres")
          .MinimumLength(3).WithMessage("El campo {PropertyName} no puede tener menos de 3 caracteres");

        }
    }
}
