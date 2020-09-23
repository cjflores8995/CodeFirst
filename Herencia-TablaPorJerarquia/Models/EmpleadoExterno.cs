using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_TablaPorJerarquia.Models
{
    public class EmpleadoExterno: Empleado
    {
        public string NombreConsultor { get; set; }

        public DateTime? ExpiracionContacto { get; set; }
    }
}
