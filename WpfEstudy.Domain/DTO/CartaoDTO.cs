using System;
using System.Collections.Generic;
using System.Text;

namespace WpfEstudy.Domain.DTO
{
    public class CartaoDTO
    {
        public int id { get; set; }
        public String descricao { get; set; }
        public int banco { get; set; }
        public int tipo { get; set; }
        public decimal limite { get; set; }

        public virtual BancoDTO BancoDTO { get; set; }
        public virtual Tipo_CartaoDTO Tipo_CartaoDTO { get; set; }
    }
}
