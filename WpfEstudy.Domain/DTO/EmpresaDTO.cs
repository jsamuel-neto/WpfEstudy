using System;
using System.Collections.Generic;
using System.Text;

namespace WpfEstudy.Domain.DTO
{
    public class EmpresaDTO
    {
        public int id { get; set; }
        public String nome { get; set; }
        public String documento { get; set; }
        public int categoria { get; set; }
        public String endereco { get; set; }

        public virtual Categoria_ConsumoDTO Categoria_ConsumoDTO { get; set; }
    }
}
