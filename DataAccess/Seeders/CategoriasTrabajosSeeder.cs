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
    public class CategoriasTrabajosSeeder
    {
        public void Seed(Contexto context)
        {
            context.CategoriasTrabajos.AddOrUpdate(x => x.Nombre,
                new CategoriasTrabajos { Nombre = "Administración / Oficina", FechaRegistro = DateTime.Now, FechaModificacion = DateTime.Now, Estado = true },
                new CategoriasTrabajos { Nombre = "Almacén / Logística / Transporte", FechaRegistro = DateTime.Now, FechaModificacion = DateTime.Now, Estado = true },
                new CategoriasTrabajos { Nombre = "Atención a clientes", FechaRegistro = DateTime.Now, FechaModificacion = DateTime.Now, Estado = true },
                new CategoriasTrabajos { Nombre = "CallCenter / Telemercadeo", FechaRegistro = DateTime.Now, FechaModificacion = DateTime.Now, Estado = true },
                new CategoriasTrabajos { Nombre = "Compras / Comercio Exterior", FechaRegistro = DateTime.Now, FechaModificacion = DateTime.Now, Estado = true },
                new CategoriasTrabajos { Nombre = "Construccion y obra", FechaRegistro = DateTime.Now, FechaModificacion = DateTime.Now, Estado = true },
                new CategoriasTrabajos { Nombre = "Contabilidad / Finanzas", FechaRegistro = DateTime.Now, FechaModificacion = DateTime.Now, Estado = true },
                new CategoriasTrabajos { Nombre = "Dirección / Gerencia", FechaRegistro = DateTime.Now, FechaModificacion = DateTime.Now, Estado = true },
                new CategoriasTrabajos { Nombre = "Diseño / Artes gráficas", FechaRegistro = DateTime.Now, FechaModificacion = DateTime.Now, Estado = true },
                new CategoriasTrabajos { Nombre = "Docencia", FechaRegistro = DateTime.Now, FechaModificacion = DateTime.Now, Estado = true },
                new CategoriasTrabajos { Nombre = "Hostelería / Turismo", FechaRegistro = DateTime.Now, FechaModificacion = DateTime.Now, Estado = true },
                new CategoriasTrabajos { Nombre = "Informática / Telecomunicaciones", FechaRegistro = DateTime.Now, FechaModificacion = DateTime.Now, Estado = true },
                new CategoriasTrabajos { Nombre = "Ingeniería", FechaRegistro = DateTime.Now, FechaModificacion = DateTime.Now, Estado = true },
                new CategoriasTrabajos { Nombre = "Investigación y Calidad", FechaRegistro = DateTime.Now, FechaModificacion = DateTime.Now, Estado = true },
                new CategoriasTrabajos { Nombre = "Legal / Asesoría", FechaRegistro = DateTime.Now, FechaModificacion = DateTime.Now, Estado = true },
                new CategoriasTrabajos { Nombre = "Mantenimiento y Reparaciones Técnicas", FechaRegistro = DateTime.Now, FechaModificacion = DateTime.Now, Estado = true },
                new CategoriasTrabajos { Nombre = "Medicina / Salud", FechaRegistro = DateTime.Now, FechaModificacion = DateTime.Now, Estado = true },
                new CategoriasTrabajos { Nombre = "Mercadotécnia / Publicidad / Comunicació", FechaRegistro = DateTime.Now, FechaModificacion = DateTime.Now, Estado = true },
                new CategoriasTrabajos { Nombre = "Otros(86)", FechaRegistro = DateTime.Now, FechaModificacion = DateTime.Now, Estado = true },
                new CategoriasTrabajos { Nombre = "Producción / Operarios / Manufactura", FechaRegistro = DateTime.Now, FechaModificacion = DateTime.Now, Estado = true },
                new CategoriasTrabajos { Nombre = "Recursos Humanos", FechaRegistro = DateTime.Now, FechaModificacion = DateTime.Now, Estado = true },
                new CategoriasTrabajos { Nombre = "Servicios Generales, Aseo y Seguridad", FechaRegistro = DateTime.Now, FechaModificacion = DateTime.Now, Estado = true },
                new CategoriasTrabajos { Nombre = "Ventas", FechaRegistro = DateTime.Now, FechaModificacion = DateTime.Now, Estado = true }
                );
        }
    }
}
