using System;
using System.Collections.Generic;
using System.Text;

namespace WpfEstudy.Domain.DTO
{
    public class ParcelaDTO
    {
        public int id { get; set; }
        public int recurso { get; set; }
        public String descricao { get; set; }
        public int quantidade { get; set; }
        public decimal valor { get; set; }
        public decimal juros { get; set; }

        public virtual RecursoDTO RecursoDTO { get; set; }
    }
}
