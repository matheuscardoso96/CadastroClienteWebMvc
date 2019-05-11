using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ClientesWebMvc.Models
{
    public class ClientesWebMvcContext : DbContext
    {
        public ClientesWebMvcContext (DbContextOptions<ClientesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<ClienteEndereco> ClienteEndereco { get; set; }
        public DbSet<Pais> Pais { get; set; }
        public DbSet<TipoEndereco> TipoEndereco { get; set; }
        public DbSet<TipoPessoa> TipoPessoa { get; set; }
        public DbSet<Uf> Uf { get; set; }

    }
}
