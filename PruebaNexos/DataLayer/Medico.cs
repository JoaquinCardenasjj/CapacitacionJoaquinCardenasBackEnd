using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNexos.DataLayer
{
    public class Medico
    {
        [Key]
        public int Id_Medico { get; set; }
        public string Nombres { get; set; }
        public string Especialidad{ get; set; }
        public string CodigoMedico { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }        
        public List<MedicoPaciente> MedicosPaciente { get; set; }
    }
    public class MedicoValidator : AbstractValidator<Medico>
    {
        public MedicoValidator()
        {
            RuleFor(medico => medico.Id_Medico).NotNull();
            RuleFor(medico => medico.Nombres).NotNull().MaximumLength(120);
            RuleFor(medico => medico.Especialidad).NotNull().MaximumLength(60);
            RuleFor(medico => medico.CodigoMedico).NotNull().MaximumLength(40);
            RuleFor(medico => medico.Telefono).NotNull().MaximumLength(40);
            RuleFor(medico => medico.Correo).NotNull().MaximumLength(120).EmailAddress();
        }
    }
}
