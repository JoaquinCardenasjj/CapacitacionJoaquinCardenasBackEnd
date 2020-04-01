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
    }
}
