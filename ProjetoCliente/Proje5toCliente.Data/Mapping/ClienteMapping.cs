using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoCliente.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.Data.Mapping
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("tb_Cliente");

            builder.HasKey(c => c.IdCliente);

            builder.Property(f => f.IdCliente)
               .HasColumnName("IdCliente")
               .IsRequired();

            builder.Property(f => f.NomeCliente)
               .HasColumnName("NomeCliente")
               .IsRequired();

            builder.Property(f => f.EmailCliente)
               .HasColumnName("EmailCliente")
               .IsRequired();

            builder.Property(f => f.Cpf)
               .HasColumnName("Cpf")
               .IsRequired();
        }
    }
}
