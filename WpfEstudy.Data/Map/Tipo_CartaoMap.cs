using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WpfEstudy.Domain.Entity;

namespace WpfEstudy.Infrastructure.Map
{
    public class Tipo_CartaoMap : IEntityTypeConfiguration<Tipo_Cartao>
    {
        public void Configure(EntityTypeBuilder<Tipo_Cartao> builders)
        {
            builders.HasKey(t => t.id);

            builders.Property(t => t.descricao)
                .IsRequired()
                .HasColumnType("varchar(30)");

            builders.ToTable("tipo_cartao");
        }
    }
}
