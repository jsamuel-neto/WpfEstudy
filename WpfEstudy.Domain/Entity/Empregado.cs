using System;
using System.Collections.Generic;
using System.Text;

namespace WpfEstudy.Domain.Entity
{
    public class Empregado : Entidade
    {
        public int empresa { get; set; }
        public String cargo { get; set; }
        public decimal salario { get; set; }
        public DateTime data_pagament { get; set; }

        //EF Relations
        public virtual Empresa Empresa { get; set; }
    }
}
