using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProyectoCalidad.Models;

namespace ProyectoCalidad.Data
{
    public class ProyectoCalidadContext : DbContext
    {
        public ProyectoCalidadContext (DbContextOptions<ProyectoCalidadContext> options)
            : base(options)
        {
        }

        public DbSet<ProyectoCalidad.Models.Formulario_Model> Formulario_Model { get; set; } = default!;
    }
}
