using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNexos.DataLayer
{
    public class MedicoPaciente
    {
        [Key]
        public int Id_MedicoPaciente { get; set; }
        public int Paciente_Id { get; set; }
        public int Medico_Id { get; set; }
        public DateTime FechaHora { get; set; }
        public bool Activo { get; set; }

        public Medico Medico { get; set; }

        public Paciente Paciente { get; set; }
    }
    public class MedicoPacienteValidator : AbstractValidator<MedicoPaciente>
    {
        public MedicoPacienteValidator()
        {
            RuleFor(medico => medico.Id_MedicoPaciente).NotNull();
            RuleFor(medico => medico.Paciente_Id).NotNull();
            RuleFor(medico => medico.Medico_Id).NotNull();
            RuleFor(medico => medico.FechaHora).NotNull();
        }
    }
}
