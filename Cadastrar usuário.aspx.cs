using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ImobCESV
{
    public partial class Cadastrar_usuário : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private bool validarEmail() {
            if (string.IsNullOrEmpty(txtcadastraremail.Text)) return false;
            if (string.IsNullOrEmpty(txtcadastrarsenha.Text)) return false;
            if (!txtcadastraremail.Text.Contains("@")) return false;
            if (txtcadastraremail.Text.Split('@')[0].Length == 0) return false;
            if (txtcadastraremail.Text.Length <= 6) return false;
            return true;
        }
        protected void btncadusuario_Click1(object sender, EventArgs e)
        {
            try
            {
                if (validarEmail()) {
                    Usuario objusuario = new Usuario();
                    objusuario.nome = txtnomecadastro.Text;
                    objusuario.email = txtcadastraremail.Text;
                    objusuario.senha = txtcadastrarsenha.Text;

                    UsuarioDAO usuarioDao = new UsuarioDAO();

                    bool encontrou = usuarioDao.ConsultarUsuarioPorEmail(objusuario.email);

                    if (encontrou)
                    {
                        lblmensagemcadusuario.Text = "Usuário já existe!";
                    }
                    else
                    {
                        usuarioDao.cadastrarUsuario(objusuario);
                        lblmensagemcadusuario.Text = "Usuário cadastrado com sucesso!";
                    }
                } else
                {
                    lblmensagemcadusuario.Text = "Por favor, insira corretamente os campos.";
                }
                
            }
            catch
            {

            }
        }

        protected void btnvoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
    }
}

      