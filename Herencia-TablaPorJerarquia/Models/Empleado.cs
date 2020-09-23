using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_TablaPorJerarquia.Models
{
    public abstract class Empleado
    {
        public int Id { get; set; }

        public string Apellido { get; set; }
        public string Nombre { get; set; }

        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Region { get; set; }
        public string CodigoPostal { get; set; }
        public string Pais { get; set; }
    }
}
