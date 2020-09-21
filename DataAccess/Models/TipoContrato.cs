using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{

    /// <summary>
    /// almacenara los tipos de contratos
    /// </summary>
    public class TipoContrato: CamposComunes
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        [Index(IsUnique = true)]
        public string Tipo { get; set; }

        public virtual ICollection<Trabajos> Trabajos { get; set; }
    }
}
