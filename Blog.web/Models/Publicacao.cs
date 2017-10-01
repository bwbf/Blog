using System;
using System.Collections.Generic;

namespace Blog.web.Models
{
    public class Publicacao
    {

        public int PublicacaoID { get; set; }

        public DateTime DataPost { get; set; }

        public string Conteudo { get; set; }

        public List<Comentario> ComentarioPost { get; set; }


    }
}