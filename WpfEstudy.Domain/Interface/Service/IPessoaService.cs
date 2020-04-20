using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WpfEstudy.Domain.DTO;

namespace WpfEstudy.Domain.Interface.Service
{
    public interface IPessoaService : IDisposable
    {
        Task<IEnumerable<PessoaDTO>> FindAll();
        PessoaDTO FindTeste(int id);
        Task Add(PessoaDTO pessoa);
        Task Remove(int id);
        Task Update(PessoaDTO pessoa);
    }
}
