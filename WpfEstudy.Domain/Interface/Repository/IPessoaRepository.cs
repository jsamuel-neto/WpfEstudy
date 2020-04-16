using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WpfEstudy.Domain.Entity;

namespace WpfEstudy.Domain.Interface.Repository
{
    public interface IPessoaRepository : IRepository<Pessoa>
    {
        Pessoa FindTeste(int id);
    }
}
