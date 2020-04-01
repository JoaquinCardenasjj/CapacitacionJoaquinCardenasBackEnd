using PruebaNexos.MethodParameters;
using PruebaNexos.MethodParameters.Paciente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Paciente
{
    public interface IPaciente
    {
        GetPacientesOut GetPacientes(GetPacientesIn input);
        CreatePacienteOut CreatePaciente(CreatePacienteIn input);
        UpdatePacienteOut UpdatePaciente(UpdatePacienteIn input);
        DeletePacienteOut DeletePaciente(DeletePacienteIn input);
        GetPacienteOut GetPaciente(GetPacienteIn input);
        GetPacienteExportacionOut GetPacienteExportacion(GetPacienteExportacionIn input);
    }
}
