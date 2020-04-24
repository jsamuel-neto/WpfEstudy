using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WpfEstudy.Domain.Entity;

namespace WpfEstudy.Infrastructure.Map
{
    public class Tipo_LancamentoMap : IEntityTypeConfiguration<Tipo_Lancamento>
    {
        public void Configure(EntityTypeBuilder<Tipo_Lancamento> builders)
        {
            builders.HasKey(t => t.id);

            builders.Property(t => t.descricao)
                .IsRequired()
                .HasColumnType("varchar(30)");

            builders.Property(t => t.operacao)
                .IsRequired()
                .HasColumnType("char(1)");

            builders.ToTable("tipo_lancamento");
        }
    }
}
