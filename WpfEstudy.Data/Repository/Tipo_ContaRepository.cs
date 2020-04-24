using System;
using System.Collections.Generic;
using System.Text;
using WpfEstudy.Domain.Entity;
using WpfEstudy.Domain.Interface.Repository;
using WpfEstudy.Infrastructure.Context;

namespace WpfEstudy.Infrastructure.Repository
{
    public class Tipo_ContaRepository : Repository<Tipo_Conta>, ITipo_ContaRepository
    {
        public Tipo_ContaRepository(WpfEstudyDBContext context) : base(context) { }
    }
}
