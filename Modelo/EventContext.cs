using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.PN;
using Modelo.DAO;

namespace Modelo
{
    public class EventContext : DbContext
    {
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
