using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPrueba05.Data;

namespace TestPrueba05.Models
{
    internal class EstudianteContext : DbContext
    {
        public DbSet<Estudiante> students { get; set; }
        public DbSet<Grado> Grades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["constring"].ToString());
        }
    }
}
