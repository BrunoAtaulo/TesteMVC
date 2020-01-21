using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_teste.Models
{
    public class Produtos
    {
        [Key]
        public int cod_produto { get; set; }
        public String nome_produto { get; set; }
    }
}