using System;
using System.Collections.Generic;
using System.Text;

namespace WpfEstudy.Domain.Entity
{
    public class Lancamento : Entidade
    {
        public int ano { get; set; }
        public int recurso { get; set; }
        public int tipo { get; set; }
        public int empresa { get; set; }
        public decimal valor { get; set; }
        public DateTime data_lancamento { get; set; }

        //EF Relations
        public virtual Recurso Recurso { get; set; }
        public virtual Tipo_Lancamento Tipo_Lancamento { get; set; }
        public virtual Empresa Empresa { get; set; }
    }
}
