using WpfEstudy.Domain.Entity;
using WpfEstudy.Domain.Interface.Repository;
using WpfEstudy.Infrastructure.Context;

namespace WpfEstudy.Infrastructure.Repository
{
    public class Categoria_ConsumoRepository : Repository<Categoria_Consumo>, ICategoria_ConsumoRepository
    {
        public Categoria_ConsumoRepository(WpfEstudyDBContext context) : base(context) { }
    }
}
