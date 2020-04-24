using System;
using System.Collections.Generic;
using System.Text;

namespace WpfEstudy.Domain.Entity
{
    public class Carteira : Entidade
    {
        public String descricao { get; set; }
        public Decimal valor { get; set; }
    }
}