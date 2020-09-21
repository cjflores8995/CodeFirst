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
    /// almacenara la informacion de trabajos
    /// </summary>
    /// 
    public class Trabajos: CamposComunes
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Titulo { get; set; }

        [Required]
        [MaxLength(150)]
        public string Ubicacion { get; set; }

        [Required]
        public double Salario { get; set; }

        [Required]
        [MaxLength(250)]
        public string Descripcion { get; set; }

        [ForeignKey("TipoContrato")]
        public int TipoContratoId { get; set; }
        public TipoContrato TipoContrato { get; set; }

        [ForeignKey("CategoriaTrabajo")]
        public int CategoriaTrabajoId { get; set; }
        public CategoriasTrabajos CategoriaTrabajo { get; set; }

    }
}
