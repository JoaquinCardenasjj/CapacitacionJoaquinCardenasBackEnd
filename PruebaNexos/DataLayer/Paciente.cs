using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNexos.DataLayer
{
    public class Paciente
    {
        [Key]
        public int Id_Paciente { get; set; }
        public string Nombre { get; set; }
        public string NumeroSeguroSocial { get; set; }
        public string MedicoPreferido { get; set; }

    }
}
