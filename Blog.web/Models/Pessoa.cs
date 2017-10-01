using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.web.Models
{
    public class Pessoa
    {
        public int PessoaID { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Usuario { get; set; }

        public string Senha { get; set; }

        public List<Publicacao>  Post { get; set; }



    }
}