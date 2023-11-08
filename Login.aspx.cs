using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ImobCESV
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnentrar_Click(object sender, EventArgs e)
        {
            var email = txtemail.Text;
            var senha = txtsenha.Text;

            try
            {
                
                if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(senha))
                { 
                    UsuarioDAO usuarioDAO = new UsuarioDAO();
                    Usuario usuario = usuarioDAO.logar(email, senha);
                    Response.Redirect("Cadastrar Imóvel.aspx");
                }
                else
                {
                    lblmensagem.Text = "Email/Senha inválido(s)";
                }
                
            }
            catch (Exception)
            {
                lblmensagem.Text = "Email/Senha estão incorretos";
            }
            
        }

        protected void btncadastrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cadastrar usuário.aspx");
        }
    }
}