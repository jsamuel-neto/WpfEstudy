using System;
using System.Collections.Generic;
using System.Text;

namespace WpfEstudy.Domain.Entity
{
    public class Recurso : Entidade
    {
        public int conta { get; set; }
        public int cartao { get; set; }
        public int carteira { get; set; }
        public int pessoa { get; set; }
        public String descricao { get; set; }

        //EF Relations
        public virtual Conta Conta { get; set; }
        public virtual Cartao Cartao { get; set; }
        public virtual Carteira Carteira { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
