using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EstudosVendasRoupas.Entidades
{
    public class Venda
    {
        [Key]
        public int Id { get; set; }

        public int Id_Cliente { get; set; }

        public virtual Cliente Cliente { get; set; }

        public DateTime Data { get; set; }

        public decimal Valor { get; set; }
    }
}