using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Paciente;
using Microsoft.AspNetCore.Mvc;
using PruebaNexos.MethodParameters.Paciente;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PruebaNexos.ServicesLayer.Controllers
{
    [Route("api/[controller]")]
    public class PacienteController : Controller
    {
        public IPaciente paciente { get; set; }
        public PacienteController(IPaciente pac)
        {
            paciente = pac;
        }
        [HttpPost]
        [Route("crear")]
        public CreatePacienteOut CreatePaciente([FromBody]CreatePacienteIn input)
        {
            return paciente.CreatePaciente(input);
        }
        [HttpPost]
        [Route("")]
        public GetPacientesOut GetPacientes(GetPacientesIn input)
        {
            return paciente.GetPacientes(input);
        }
        [HttpPost]
        [Route("editar")]
        public UpdatePacienteOut UpdatePaciente([FromBody]UpdatePacienteIn input)
        {
            return paciente.UpdatePaciente(input);
        }
        [HttpPost]
        [Route("eliminar")]
        public DeletePacienteOut DeletePaciente([FromBody]DeletePacienteIn input)
        {
            return paciente.DeletePaciente(input);
        }
        [HttpPost]
        [Route("detalle")]
        public GetPacienteOut GetPaciente([FromBody]GetPacienteIn input)
        {
            return paciente.GetPaciente(input);
        }
        [HttpPost]
        [Route("exportacion")]
        public GetPacienteExportacionOut GetPacienteExportacion(GetPacienteExportacionIn input)
        {
            return paciente.GetPacienteExportacion(input);
        }
    }
}
