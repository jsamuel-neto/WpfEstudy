using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WpfEstudy.Domain.Entity;

namespace WpfEstudy.Domain.Interface.Service
{
    public interface IPessoaService : IDisposable
    {
        Task<IEnumerable<Pessoa>> FindAll();
        Pessoa FindTeste(int id);
    }
}
