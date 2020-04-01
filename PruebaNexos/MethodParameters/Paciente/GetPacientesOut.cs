using PruebaNexos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNexos.MethodParameters.Paciente
{
    public class GetPacientesOut : BaseOut
    {
        public List<PruebaNexos.Entities.Paciente> pacientes { get; set; }
        public int totalRecords { get; set; }
    }
}
