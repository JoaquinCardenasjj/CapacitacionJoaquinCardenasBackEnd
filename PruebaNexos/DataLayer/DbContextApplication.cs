using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PruebaNexos.DataLayer
{
    class DbContextApplication : DbContext
    {
        public static readonly ILoggerFactory MyLoggerFactory
        = LoggerFactory.Create(builder =>
        {
            builder
                .AddFilter((category, level) =>
                    category == DbLoggerCategory.Database.Command.Name
                    && level == LogLevel.Information)
                .AddConsole();
        });

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            // El connectionString debe venir de un archivo de configuraciones!
            optionsBuilder.UseSqlServer("Server=DESKTOP-TKCRCIL\\DEVELOP; Trusted_Connection=False; MultipleActiveResultSets=true; database=PruebaNexos;user id=sa;password=nexos")
                .EnableSensitiveDataLogging(true)
                .UseLoggerFactory(MyLoggerFactory);

        }

        public DbSet<Paciente> Pacientes { get; set; }

        public DbSet<Medico> Medicos { get; set; }
        public DbSet<MedicoPaciente> MedicoPacientes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Medico
            modelBuilder.Entity<Medico>()
                .Property(b => b.Especialidad)
                .HasMaxLength(60).IsRequired(true);
            modelBuilder.Entity<Medico>()
              .Property(b => b.Correo)
              .HasMaxLength(120).IsRequired(true);
            modelBuilder.Entity<Medico>()
             .Property(b => b.CodigoMedico)
             .HasMaxLength(40).IsRequired(true);
            modelBuilder.Entity<Medico>()
            .Property(b => b.Telefono)
            .HasMaxLength(40);
            modelBuilder.Entity<Medico>()
             .Property(b => b.Nombres)
             .HasMaxLength(120).IsRequired(true);

            //Medico paciente
            modelBuilder.Entity<MedicoPaciente>()
              .HasOne(p => p.Medico)
              .WithMany(b => b.MedicosPaciente)
              .HasForeignKey(p => p.Medico_Id)
              .HasConstraintName("FK_MEDP_MED");

            modelBuilder.Entity<MedicoPaciente>()
              .HasOne(p => p.Paciente)
              .WithMany(b => b.MedicosPaciente)
              .HasForeignKey(p => p.Paciente_Id)
              .HasConstraintName("FK_MEDP_PAC");

        }
    }
}
