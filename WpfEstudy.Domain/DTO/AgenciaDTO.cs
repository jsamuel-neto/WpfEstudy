using System;
using System.Collections.Generic;
using System.Text;

namespace WpfEstudy.Domain.DTO
{
    public class AgenciaDTO
    {
        public int id { get; set; }
        public int banco { get; set; }
        public String codigo { get; set; }

        public virtual BancoDTO BancoDTO { get; set; }
    }
}
