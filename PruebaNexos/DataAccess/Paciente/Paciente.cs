using Microsoft.EntityFrameworkCore;
using PruebaNexos.DataLayer;
using PruebaNexos.MethodParameters;
using PruebaNexos.MethodParameters.Paciente;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Paciente
{
    public class Paciente : IPaciente
    {
        public GetPacientesOut GetPacientes(GetPacientesIn input)
        {
            GetPacientesOut output = new GetPacientesOut() { result = Result.Error };
            try
            {
                DbContextApplication dbContext = new DbContextApplication();
                var linqResult = dbContext.Pacientes.ToList();
                output.pacientes = new List<PruebaNexos.Entities.Paciente>();
                output.totalRecords = linqResult.Count;
                foreach (var linqPaciente in linqResult)
                {
                    var paciente = new PruebaNexos.Entities.Paciente()
                    {
                        Id_Paciente = linqPaciente.Id_Paciente,
                        Nombre = linqPaciente.Nombre,
                        NumeroSeguroSocial = linqPaciente.NumeroSeguroSocial,
                        MedicoPreferido = linqPaciente.MedicoPreferido

                    };
                    output.pacientes.Add(paciente);
                }
                output.result = Result.Success;

                return output;
            }
            catch (Exception e)
            {
                output.MensajeExcepcion = "Excepción no controlada por favor comuniquese con el administrador enviele el siguiente mensaje: " + e.Message;
                return output;
            }
        }
        public CreatePacienteOut CreatePaciente(CreatePacienteIn input)
        {
            CreatePacienteOut output = new CreatePacienteOut() { result = Result.Error };
            try
            {
                DbContextApplication dbContext = new DbContextApplication();
                var paciente = new PruebaNexos.DataLayer.Paciente
                {
                    Nombre = input.Nombre,
                    NumeroSeguroSocial = input.NumeroSeguro,
                    MedicoPreferido = input.MedicoPreferido
                };

                dbContext.Pacientes.Add(paciente);

                if (dbContext.SaveChanges() > 0)
                {
                    output.pacienteId = paciente.Id_Paciente;
                    output.result = Result.Success;
                }
                return output;
            }
            catch (Exception e)
            {
                output.MensajeExcepcion = "Excepción no controlada por favor comuniquese con el administrador enviele el siguiente mensaje: " + e.Message;
                return output;
            }
        }
        public UpdatePacienteOut UpdatePaciente(UpdatePacienteIn input)
        {
            UpdatePacienteOut output = new UpdatePacienteOut() { result = Result.Error };
            try
            {
                DbContextApplication dbContext = new DbContextApplication();
                var paciente = new PruebaNexos.DataLayer.Paciente
                {
                    Id_Paciente = input.pacienteId,
                    Nombre = input.Nombre,
                    NumeroSeguroSocial = input.NumeroSeguro,
                    MedicoPreferido = input.MedicoPreferido
                };
                dbContext.Entry(paciente).State = EntityState.Modified;  
                
                if (dbContext.SaveChanges() > 0)
                {
                    output.pacienteId = paciente.Id_Paciente;
                    output.result = Result.Success;
                }
                return output;
            }
            catch (Exception e)
            {
                output.MensajeExcepcion = "Excepción no controlada por favor comuniquese con el administrador enviele el siguiente mensaje: " + e.Message;
                return output;
            }
        }
        public DeletePacienteOut DeletePaciente(DeletePacienteIn input)
        {
            DeletePacienteOut output = new DeletePacienteOut() { result = Result.Error };
            try
            {
                DbContextApplication dbContext = new DbContextApplication();
                var paciente = new PruebaNexos.DataLayer.Paciente
                {
                    Id_Paciente = input.Id,                    
                };
                dbContext.Entry(paciente).State = EntityState.Deleted;

                if (dbContext.SaveChanges() > 0)
                {                    
                    output.result = Result.Success;
                }
                return output;
            }
            catch (Exception e)
            {
                output.MensajeExcepcion = "Excepción no controlada por favor comuniquese con el administrador enviele el siguiente mensaje: " + e.Message;
                return output;
            }
        }
        public GetPacienteOut GetPaciente(GetPacienteIn input)
        {
            GetPacienteOut output = new GetPacienteOut() { result = Result.Error };
            try
            {
                DbContextApplication dbContext = new DbContextApplication();
                var linqResult = dbContext.Pacientes.Find(input.Id);
                
                    var paciente = new PruebaNexos.Entities.Paciente()
                    {
                        Id_Paciente = linqResult.Id_Paciente,
                        Nombre = linqResult.Nombre,
                        NumeroSeguroSocial = linqResult.NumeroSeguroSocial,
                        MedicoPreferido = linqResult.MedicoPreferido
                    };
                output.paciente = paciente;
                output.result = Result.Success;

                return output;
            }
            catch (Exception e)
            {
                output.MensajeExcepcion = "Excepción no controlada por favor comuniquese con el administrador enviele el siguiente mensaje: " + e.Message;
                return output;
            }
        }
        public GetPacienteExportacionOut GetPacienteExportacion(GetPacienteExportacionIn input)
        {
            GetPacienteExportacionOut output = new GetPacienteExportacionOut() { result = Result.Error };
            try
            {
                string folder = "Utils\\Pruebaexportacion.pdf";

                Byte[] bytes = File.ReadAllBytes(folder);
                output.archivo = Convert.ToBase64String(bytes);
                output.result = Result.Success;
                return output;
            }
            catch (Exception e)
            {
                output.MensajeExcepcion = "Excepción no controlada por favor comuniquese con el administrador enviele el siguiente mensaje: " + e.Message;
                return output;
            }

        }
    }
}
