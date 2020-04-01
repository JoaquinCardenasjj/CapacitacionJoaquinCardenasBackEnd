using PruebaNexos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNexos.MethodParameters.Paciente
{
    public class GetPacienteOut : BaseOut
    {
        public PruebaNexos.Entities.Paciente paciente { get; set; }        
    }
}
