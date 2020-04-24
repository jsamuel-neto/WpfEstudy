using System;
using System.Collections.Generic;
using System.Text;

namespace WpfEstudy.Domain.Entity
{
    public class Empresa : Entidade
    {
        public String nome { get; set; }
        public String documento { get; set; }
        public int categoria { get; set; }
        public String endereco { get; set; }

        //EF Relations
        public virtual Categoria_Consumo Categoria_Consumo { get; set; }
    }
}
