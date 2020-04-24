using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WpfEstudy.Domain.Entity;

namespace WpfEstudy.Infrastructure.Map
{
    public class BancoMap : IEntityTypeConfiguration<Banco>
    {
        public void Configure(EntityTypeBuilder<Banco> builders)
        {
            builders.HasKey(b => b.id);

            builders.Property(b => b.nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builders.Property(b => b.codigo)
                .IsRequired()
                .HasColumnType("varchar(3)");

            builders.ToTable("banco");
        }
    }
}
