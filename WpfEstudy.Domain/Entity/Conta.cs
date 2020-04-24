using System;
using System.Collections.Generic;
using System.Text;

namespace WpfEstudy.Domain.Entity
{
    public class Conta : Entidade
    {
        public int agencia { get; set; }
        public String codigo { get; set; }
        public int tipo { get; set; }
        public int cartao { get; set; }
        public decimal saldo { get; set; }
        public decimal limite { get; set; }

        //EF Relations
        public virtual Agencia Agencia { get; set; }
        public virtual Tipo_Conta Tipo_Conta { get; set; }
        public virtual Cartao Cartao { get; set; }
    }
}
