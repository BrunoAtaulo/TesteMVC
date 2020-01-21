using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_teste.Models
{
    public class Clientes
    {
        [Key]
        public int cod_cliente { get; set; }
        public String nome_cliente { get; set; }
        public String sobrenome_cliente { get; set; }
    }
}