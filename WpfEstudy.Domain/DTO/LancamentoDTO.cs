using System;
using System.Collections.Generic;
using System.Text;

namespace WpfEstudy.Domain.DTO
{
    public class LancamentoDTO
    {
        public int id { get; set; }
        public int ano { get; set; }
        public int recurso { get; set; }
        public int tipo { get; set; }
        public int empresa { get; set; }
        public decimal valor { get; set; }
        public DateTime data_lancamento { get; set; }

        public virtual RecursoDTO RecursoDTO { get; set; }
        public virtual Tipo_LancamentoDTO Tipo_LancamentoDTO { get; set; }
        public virtual EmpresaDTO EmpresaDTO { get; set; }
    }
}
