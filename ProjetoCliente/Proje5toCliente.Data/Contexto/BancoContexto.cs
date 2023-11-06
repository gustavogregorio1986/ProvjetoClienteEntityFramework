using Microsoft.EntityFrameworkCore;
using ProjetoCliente.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.Data.Contexto
{
    public class BancoContexto : DbContext
    {
        public BancoContexto(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
