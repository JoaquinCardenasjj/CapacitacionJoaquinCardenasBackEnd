using FluentValidation.Results;
using PruebaNexos.MethodParameters;
using PruebaNexos.MethodParameters.Paciente;
using PruebaNexos.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business.Paciente
{
    public class Paciente : IPaciente
    {
        public DataAccess.Paciente.IPaciente paciente { get; set; }
        public Paciente(DataAccess.Paciente.IPaciente pac)
        {
            paciente = pac;
        }
        public CreatePacienteOut CreatePaciente(CreatePacienteIn input)
        {
            CreatePacienteOut output = new CreatePacienteOut() { result = Result.Error };
            CreatePacienteValidator validador = new CreatePacienteValidator();
            ValidationResult resultado = validador.Validate(input);
            List<string> listErrors = new List<string>();
            if (resultado.Errors.Count > 0)
            {
                foreach (ValidationFailure falla in resultado.Errors)
                {
                    listErrors.Add(falla.PropertyName + ": " + falla.ErrorMessage);
                }
                output.Errores = listErrors;
                return output;
            }

            return paciente.CreatePaciente(input);
        }
        public GetPacientesOut GetPacientes(GetPacientesIn input)
        {
            return paciente.GetPacientes(input);
        }

        public UpdatePacienteOut UpdatePaciente(UpdatePacienteIn input)
        {
            UpdatePacienteOut output = new UpdatePacienteOut() { result = Result.Error };
            UpdatePacienteValidator validador = new UpdatePacienteValidator();
            ValidationResult resultado = validador.Validate(input);
            List<string> listErrors = new List<string>();
            if (resultado.Errors.Count > 0)
            {
                foreach (ValidationFailure falla in resultado.Errors)
                {
                    listErrors.Add(falla.PropertyName + ": " + falla.ErrorMessage);
                }
                output.Errores = listErrors;
                return output;
            }
            return paciente.UpdatePaciente(input);
        }
        public DeletePacienteOut DeletePaciente(DeletePacienteIn input)
        {
            return paciente.DeletePaciente(input);
        }
        public GetPacienteOut GetPaciente(GetPacienteIn input)
        {
            return paciente.GetPaciente(input);
        }
        public GetPacienteExportacionOut GetPacienteExportacion(GetPacienteExportacionIn input)
        {
            return paciente.GetPacienteExportacion(input);
        }
    }
}
