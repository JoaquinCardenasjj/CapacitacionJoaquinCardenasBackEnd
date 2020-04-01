using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNexos.MethodParameters.Paciente
{
    public class UpdatePacienteIn : BaseIn
    {
        public int pacienteId { get; set; }
        public string Nombre { get; set; }
        public string NumeroSeguro { get; set; }
        public string MedicoPreferido { get; set; }
    }
}
