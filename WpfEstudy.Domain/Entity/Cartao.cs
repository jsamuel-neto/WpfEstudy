using System;
using System.Collections.Generic;
using System.Text;

namespace WpfEstudy.Domain.Entity
{
    public class Cartao : Entidade
    {
        public String descricao { get; set; }
        public int banco { get; set; }
        public int tipo { get; set; }
        public decimal limite { get; set; }

        //EF Relations
        public virtual Banco Banco { get; set; }
        public virtual Tipo_Cartao Tipo_Cartao { get; set; }
    }
}
