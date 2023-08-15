using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPrueba05.Data
{
    public class Estudiante
    {
        [Key]
        public int IdEstudiante { get; set; }
        public string? NombreCompleto { get; set; }
        public Grado Grado { get; set; }
    }
}
