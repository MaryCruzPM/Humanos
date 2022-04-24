using System;
using System.Collections.Generic;
// System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Humanos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double  Altura { get; set; }
        public double Peso { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
    }
}
