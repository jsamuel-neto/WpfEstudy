using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WpfEstudy.Domain.DTO;
using WpfEstudy.Domain.Entity;

namespace WpfEstudy.Domain.Interface.Service
{
    public interface IPessoaService : IDisposable
    {
        Task<IEnumerable<PessoaDTO>> FindAll();
        PessoaDTO FindTeste(int id);
        Task Add(PessoaDTO pessoa);
        Task Remove(int id);
        Task Update(PessoaDTO pessoa);
        Task<IEnumerable<PessoaDTO>> Find(Expression<Func<Pessoa, bool>> predicate);
    }
}
