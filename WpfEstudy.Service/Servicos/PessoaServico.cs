using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WpfEstudy.Domain.Entity;
using WpfEstudy.Domain.Interface.Repository;
using WpfEstudy.Domain.Interface.Service;

namespace WpfEstudy.Service.Servicos
{
    public class PessoaServico : IPessoaService
    {
        private readonly IPessoaRepository _repository;

        public PessoaServico(IPessoaRepository pessoaRepository)
        {
            _repository = pessoaRepository;
        }

        public async Task<IEnumerable<Pessoa>> FindAll()
        {
            return await _repository.FindAll();
        }

        public void Dispose()
        {
            _repository?.Dispose();
        }

        public Pessoa FindTeste(int id)
        {
            return _repository.FindTeste(id);
        }
    }
}
