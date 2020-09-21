using DataAccess.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;

namespace DataAccess.Seeders
{
    public class TipoContratoSeeder
    {
        public void Seed(Contexto context)
        {
            context.TipoContratos.AddOrUpdate(x => x.Tipo,
                new TipoContrato { Tipo = "Contrato de Aprendizaje", FechaRegistro = DateTime.Now, FechaModificacion = DateTime.Now, Estado = true },
                new TipoContrato { Tipo = "Contrato de obra o labor", FechaRegistro = DateTime.Now, FechaModificacion = DateTime.Now, Estado = true },
                new TipoContrato { Tipo = "Contrato por tiempo determinado", FechaRegistro = DateTime.Now, FechaModificacion = DateTime.Now, Estado = true },
                new TipoContrato { Tipo = "Contrato por tiempo indefinido", FechaRegistro = DateTime.Now, FechaModificacion = DateTime.Now, Estado = true },
                new TipoContrato { Tipo = "Otro tipo de contrato", FechaRegistro = DateTime.Now, FechaModificacion = DateTime.Now, Estado = true }
                );
        }
    }
}
