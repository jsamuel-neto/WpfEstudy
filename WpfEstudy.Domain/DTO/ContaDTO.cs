using System;
using System.Collections.Generic;
using System.Text;

namespace WpfEstudy.Domain.DTO
{
    public class ContaDTO
    {
        public int id { get; set; }
        public int agencia { get; set; }
        public String codigo { get; set; }
        public int tipo { get; set; }
        public int cartao { get; set; }
        public decimal saldo { get; set; }
        public decimal limite { get; set; }

        public virtual AgenciaDTO AgenciaDTO { get; set; }
        public virtual Tipo_ContaDTO Tipo_ContaDTO { get; set; }
        public virtual CartaoDTO CartaoDTO { get; set; }
    }
}
