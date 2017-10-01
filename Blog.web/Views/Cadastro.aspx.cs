using Blog.web.Controllers;
using Blog.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog.web.Views
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TxtSenha == txtSenha2)
            {
                using (var context = new BlogContext2())
                {
                    Pessoa pessoa = new Pessoa
                    {
                        Nome = TxtNome.Text,
                        Email = txtEmail.Text,
                        Usuario = txtUsuario.Text,
                        Senha = TxtSenha.Text
                      
                    };
                    context.Pessoas.Add(pessoa);
                    context.SaveChanges();
                }

            }
            else
            {
                lbErro.Text = "As senhas não são iguais";
            }
        }
    }
}