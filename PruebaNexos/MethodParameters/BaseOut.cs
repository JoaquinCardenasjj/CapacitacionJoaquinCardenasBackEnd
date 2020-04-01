using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNexos.MethodParameters
{
    public class BaseOut
    {
        public Result result { get; set; }
        public string MensajeExcepcion { get; set; }
        public List<string> Errores { get; set; }
    }
}
