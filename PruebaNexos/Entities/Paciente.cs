using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNexos.Entities
{
    public class Paciente
    {
        public int Id_Paciente { get; set; }
        public string Nombre { get; set; }
        public string NumeroSeguroSocial { get; set; }
        public string MedicoPreferido { get; set; }
    }
}
