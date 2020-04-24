using System;
using System.Collections.Generic;
using System.Text;

namespace WpfEstudy.Domain.Entity
{
    public class Agencia : Entidade
    {
        public String codigo { get; set; }
        public int banco { get; set; }

        public virtual Banco Banco { get; set; }
    }
}
