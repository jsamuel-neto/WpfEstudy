using WpfEstudy.Domain.Entity;
using WpfEstudy.Domain.Interface.Repository;
using WpfEstudy.Infrastructure.Context;

namespace WpfEstudy.Infrastructure.Repository
{
    public class Tipo_LancamentoRepository : Repository<Tipo_Lancamento>, ITipo_LancamentoRepository
    {
        public Tipo_LancamentoRepository(WpfEstudyDBContext context) : base(context) { }
    }
}
