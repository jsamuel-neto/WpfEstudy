using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WpfEstudy.Domain.Entity;

namespace WpfEstudy.Infrastructure.Map
{
    public class Categoria_ConsumoMap : IEntityTypeConfiguration<Categoria_Consumo>
    {
        public void Configure(EntityTypeBuilder<Categoria_Consumo> builders)
        {
            builders.HasKey(c => c.id);

            builders.Property(c => c.descricao)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builders.ToTable("categoria_consumo");
        }
    }
}
