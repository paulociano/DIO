using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front_End_com_ASPNET_MVC.Models
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set; }
    }
}