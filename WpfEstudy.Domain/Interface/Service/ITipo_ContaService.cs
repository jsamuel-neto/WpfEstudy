using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WpfEstudy.Domain.DTO;
using WpfEstudy.Domain.Entity;

namespace WpfEstudy.Domain.Interface.Service
{
    public interface ITipo_ContaService : IDisposable
    {
        Task<IEnumerable<Tipo_ContaDTO>> FindAll();
        Tipo_ContaDTO FindTeste(int id);
        Task Add(Tipo_ContaDTO tipoConta);
        Task Remove(int id);
        Task Update(Tipo_ContaDTO tipoConta);
        Task<IEnumerable<Tipo_ContaDTO>> Find(Expression<Func<Tipo_Conta, bool>> predicate);
    }
}
