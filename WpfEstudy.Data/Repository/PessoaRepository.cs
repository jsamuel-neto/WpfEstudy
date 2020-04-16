using WpfEstudy.Domain.Interface.Repository;
using WpfEstudy.Infrastructure.Context;
using WpfEstudy.Domain.Entity;
using System.Threading.Tasks;

namespace WpfEstudy.Infrastructure.Repository
{
    public class PessoaRepository : Repository<Pessoa>, IPessoaRepository
    {
       public PessoaRepository(WpfEstudyDBContext context) : base(context) { }

        public Pessoa FindTeste(int id)
        {
            return Db.Pessoas.Find(id);
        }

    }
}
