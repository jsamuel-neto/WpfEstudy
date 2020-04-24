using System;
using System.Collections.Generic;
using System.Text;

namespace WpfEstudy.Domain.Entity
{
    public class Parcela : Entidade
    {
        public int recurso { get; set; }
        public String descricao { get; set; }
        public decimal valor { get; set; }
        public int quantidade { get; set; }
        public decimal juros { get; set; }

        //EF Relations
        public virtual Recurso Recurso { get; set; }
    }
}
