using WpfEstudy.Domain.Entity;
using WpfEstudy.Domain.Interface.Repository;
using WpfEstudy.Infrastructure.Context;

namespace WpfEstudy.Infrastructure.Repository
{
    public class Tipo_CartaoRepository : Repository<Tipo_Cartao>, ITipo_CartaoRespository
    {
        public Tipo_CartaoRepository(WpfEstudyDBContext context) : base(context) { }
    }
}
