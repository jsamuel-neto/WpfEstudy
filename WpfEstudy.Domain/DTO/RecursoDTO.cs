using System;
using System.Collections.Generic;
using System.Text;

namespace WpfEstudy.Domain.DTO
{
    public class RecursoDTO
    {
        public int id { get; set; }
        public int conta { get; set; }
        public int cartao { get; set; }
        public int carteira { get; set; }
        public int pessoa { get; set; }
        public String descricao { get; set; }

        public virtual ContaDTO ContaDTO { get; set; }
        public virtual CartaoDTO CartaoDTO { get; set; }
        public virtual CarteiraDTO CarteiraDTO { get; set; }
        public virtual PessoaDTO PessoaDTO { get; set; }
    }
}
