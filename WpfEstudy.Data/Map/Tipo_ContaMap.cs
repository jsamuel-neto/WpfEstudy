using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WpfEstudy.Domain.Entity;

namespace WpfEstudy.Infrastructure.Map
{
    public class Tipo_ContaMap : IEntityTypeConfiguration<Tipo_Conta>
    {
        public void Configure(EntityTypeBuilder<Tipo_Conta> builders)
        {
            builders.HasKey(t => t.id);

            builders.Property(t => t.descricao)
                .IsRequired()
                .HasColumnType("varchar(30)");

            builders.ToTable("tipo_conta");
        }
    }
}
