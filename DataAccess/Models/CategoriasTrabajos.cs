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
    /// almacenara las categorias de los trabajos
    /// </summary>
    public class CategoriasTrabajos: CamposComunes
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        [Index(IsUnique = true)]
        public string Nombre { get; set; }

        public virtual ICollection<Trabajos> Trabajos { get; set; }
    }
}
