using PruebaNexos.MethodParameters;
using PruebaNexos.MethodParameters.Paciente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business.Paciente
{
    public interface IPaciente
    {
        CreatePacienteOut CreatePaciente(CreatePacienteIn input);
        GetPacientesOut GetPacientes(GetPacientesIn input);
        UpdatePacienteOut UpdatePaciente(UpdatePacienteIn input);
        DeletePacienteOut DeletePaciente(DeletePacienteIn input);
        GetPacienteOut GetPaciente(GetPacienteIn input);
        GetPacienteExportacionOut GetPacienteExportacion(GetPacienteExportacionIn input);
    }
}
