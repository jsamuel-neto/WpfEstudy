using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WpfEstudy.Domain.Entity;

namespace WpfEstudy.Infrastructure.Map
{
    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builders)
        {
            builders.HasKey(p => p.id);

            builders.Property(p => p.nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builders.Property(p => p.documento);

            builders.ToTable("pessoa");
        }
    }
}
