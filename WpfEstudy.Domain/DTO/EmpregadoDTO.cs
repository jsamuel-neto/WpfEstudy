using System;
using System.Collections.Generic;
using System.Text;

namespace WpfEstudy.Domain.DTO
{
    public class EmpregadoDTO
    {
        public int id { get; set; }
        public int empresa { get; set; }
        public String cargo { get; set; }
        public decimal salario { get; set; }
        public DateTime data_pagament { get; set; }

        public virtual EmpresaDTO EmpresaDTO { get; set; }
    }
}
