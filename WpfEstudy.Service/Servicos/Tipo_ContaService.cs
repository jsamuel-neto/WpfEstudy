using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WpfEstudy.Domain.DTO;
using WpfEstudy.Domain.Entity;
using WpfEstudy.Domain.Interface.Service;

namespace WpfEstudy.Service.Servicos
{
    public class Tipo_ContaService : ITipo_ContaService
    {
        private readonly ITipo_ContaService _repository;
        private readonly IMapper _mapper;

        public Tipo_ContaService(ITipo_ContaService tipoContaRepository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = tipoContaRepository;
        }

        public Task Add(Tipo_ContaDTO tipoConta)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _repository?.Dispose();
        }

        public Task<IEnumerable<Tipo_ContaDTO>> Find(Expression<Func<Tipo_Conta, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Tipo_ContaDTO>> FindAll()
        {
            throw new NotImplementedException();
        }

        public Tipo_ContaDTO FindTeste(int id)
        {
            throw new NotImplementedException();
        }

        public Task Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Tipo_ContaDTO tipoConta)
        {
            throw new NotImplementedException();
        }
    }
}
