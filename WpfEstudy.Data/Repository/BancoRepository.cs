using System;
using WpfEstudy.Domain.Entity;
using WpfEstudy.Domain.Interface.Repository;
using WpfEstudy.Infrastructure.Context;

namespace WpfEstudy.Infrastructure.Repository
{
    public class BancoRepository : Repository<Banco>, IBancoRepository
    {
        public BancoRepository(WpfEstudyDBContext context) : base(context) { }
    }
}
