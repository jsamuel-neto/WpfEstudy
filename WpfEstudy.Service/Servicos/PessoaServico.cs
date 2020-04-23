using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WpfEstudy.Domain.DTO;
using WpfEstudy.Domain.Entity;
using WpfEstudy.Domain.Interface.Repository;
using WpfEstudy.Domain.Interface.Service;

namespace WpfEstudy.Service.Servicos
{
    public class PessoaServico : IPessoaService
    {
        private readonly IPessoaRepository _repository;
        private readonly IMapper _mapper;

        public PessoaServico(IPessoaRepository pessoaRepository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = pessoaRepository;
        }

        public async Task<IEnumerable<PessoaDTO>> FindAll()
        {
            return _mapper.Map<IEnumerable<PessoaDTO>>(await _repository.FindAll());
        }

        public PessoaDTO FindTeste(int id)
        {
            return _mapper.Map<Pessoa, PessoaDTO>(_repository.FindTeste(id));
        }

        public async Task Add(PessoaDTO pessoa) {
            await _repository.Add(_mapper.Map<Pessoa>(pessoa));
        }

        public async Task Update(PessoaDTO pessoa)
        {
            await _repository.Update(_mapper.Map<Pessoa>(pessoa));
        }

        public async Task Remove(int id)
        {
            await _repository.Delete(id);
        }

        public void Dispose()
        {
            _repository?.Dispose();
        }

        public async Task<IEnumerable<PessoaDTO>> Find(Expression<Func<Pessoa, bool>> predicate)
        {
            return _mapper.Map<IEnumerable<PessoaDTO>>(await _repository.Find(predicate));
        }
    }
}
