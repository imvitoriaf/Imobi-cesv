using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ImobCESV
{
    public partial class Cadastrar_Imóvel : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnvalidarcep_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ws = new wsCorreios.AtendeClienteService())
                {
                    var resultado = ws.consultaCEP(txtcep.Text);

                    txtendereco.Text = resultado.end;
                    txtbairro.Text = resultado.bairro;
                    txtcidade.Text = resultado.cidade;
                }
            }
            catch (Exception ex)
            {
                ExibirMensagem(ex.Message);
            }
        }
        public void ExibirMensagem(string msg)
        {
            Response.Write("<script>alert('" + msg + "')</script>");
        }
        protected void btncadastrar_Click(object sender, EventArgs e)
        {

            try
            {


                Imovel objimovel = new Imovel();
                objimovel.bairro = txtbairro.Text;
                objimovel.endereco = txtendereco.Text;
                objimovel.cidade = txtcidade.Text;
                objimovel.cep = txtcep.Text;
                objimovel.numero = txtnumero.Text;
                objimovel.referencia = txtreferencia.Text;
                objimovel.titulo = txttitulo.Text;
                objimovel.ativo = rdbativo.Text;
                objimovel.tipoimovel = ddltipoimovel.SelectedValue;
                objimovel.finalidade = ddlfinalidade.SelectedValue;
                objimovel.descricao = txtdescricao.Text;
                objimovel.quartos = int.Parse(ddlquarto.SelectedValue);
                objimovel.banheiro = int.Parse(ddlbanheiro.SelectedValue);
                objimovel.suite = int.Parse(ddlsuite.SelectedValue);
                objimovel.garagem = int.Parse(ddlgaragem.SelectedValue);
                objimovel.areatotal = txtareatotal.Text;
                objimovel.valor = txtvalor.Text;
                objimovel.tratar = txttratar.Text;
                objimovel.telefone = txttelefone.Text;
                objimovel.agua = chkagua.Checked;
                objimovel.lavanderia = chklavanderia.Checked;
                objimovel.alarme = chkalarme.Checked;
                objimovel.academia = chkacademia.Checked;
                objimovel.camera = chkcamera.Checked;
                objimovel.churrasqueira = chkchurrasqueira.Checked;
                objimovel.cerca = chkcerca.Checked;
                objimovel.esgoto = chkesgoto.Checked;
                objimovel.gas = chkgas.Checked;
                objimovel.playground = chkplayground.Checked;
                objimovel.piscina = chkpiscina.Checked;
                objimovel.portaria = chkportaria.Checked;
                objimovel.quintal = chkquintal.Checked;
                objimovel.quadra = chkquadra.Checked;
                objimovel.sauna = chksauna.Checked;
                objimovel.wifi = chkwifi.Checked;


                ImovelDAO dao = new ImovelDAO();
                dao.cadastrarImovel(objimovel);

                lblmensagemcadimovel.Text = "Cadastro salvo com sucesso!";
                limparCampos();
            }
            catch (Exception ex)
            {

                lblmensagemcadimovel.Text = "Erro ao salvar cadastro! Entre em contato com o administrador do sistema.";
            }
        }

        public void btnpesquisar_Click(object sender, EventArgs e)
        {
            var referencia = txtreferencia.Text;

            try
            {
                if (!string.IsNullOrEmpty(referencia))
                {

                    ImovelDAO imovelDao = new ImovelDAO();

                    Imovel imovel = imovelDao.ConsultarImovelPorReferencia(txtreferencia.Text);
                    if (imovel != null)
                    {

                        txtbairro.Text = imovel.bairro;
                        txtendereco.Text = imovel.endereco;
                        txtcidade.Text = imovel.cidade;
                        txtcep.Text = imovel.cep;
                        txtnumero.Text = imovel.numero;
                        txtreferencia.Text = imovel.referencia;
                        txttitulo.Text = imovel.titulo;
                        rdbativo.Text = imovel.ativo;
                        ddltipoimovel.Text = imovel.tipoimovel;
                        ddlfinalidade.Text = imovel.finalidade;
                        txtdescricao.Text = imovel.descricao;
                        ddlquarto.Text = imovel.quartos.ToString();
                        ddlbanheiro.Text = imovel.banheiro.ToString();
                        ddlsuite.Text = imovel.suite.ToString();
                        ddlgaragem.Text = imovel.garagem.ToString();
                        txtareatotal.Text = imovel.areatotal;
                        txtvalor.Text = imovel.valor;
                        txttratar.Text = imovel.tratar;
                        txttelefone.Text = imovel.telefone;
                        chkagua.Checked = imovel.agua;
                        chklavanderia.Checked = imovel.lavanderia;
                        chkalarme.Checked = imovel.alarme;
                        chkacademia.Checked = imovel.academia;
                        chkcamera.Checked = imovel.camera;
                        chkchurrasqueira.Checked = imovel.churrasqueira;
                        chkcerca.Checked = imovel.cerca;
                        chkesgoto.Checked = imovel.esgoto;
                        chkgas.Checked = imovel.gas;
                        chkplayground.Checked = imovel.playground;
                        chkpiscina.Checked = imovel.piscina;
                        chkportaria.Checked = imovel.portaria;
                        chkquintal.Checked = imovel.quintal;
                        chkquadra.Checked = imovel.quadra;
                        chksauna.Checked = imovel.sauna;
                        chkwifi.Checked = imovel.wifi;
                    }
                    else
                    {
                        lblmensagemcadimovel.Text = "Imóvel não encontrado!";
                    }


                }

            }
            catch
            {
            }
        }

        protected void btnalterar_Click(object sender, EventArgs e)
        {
            var referencia = txtreferencia.Text;

            try
            {
                if (!string.IsNullOrEmpty(referencia))
                {

                    ImovelDAO imovelDao = new ImovelDAO();

                    Imovel objimovel = new Imovel();
                    objimovel.bairro = txtbairro.Text;
                    objimovel.endereco = txtendereco.Text;
                    objimovel.cidade = txtcidade.Text;
                    objimovel.cep = txtcep.Text;
                    objimovel.numero = txtnumero.Text;
                    objimovel.referencia = txtreferencia.Text;
                    objimovel.titulo = txttitulo.Text;
                    objimovel.ativo = rdbativo.Text;
                    objimovel.tipoimovel = ddltipoimovel.SelectedValue;
                    objimovel.finalidade = ddlfinalidade.SelectedValue;
                    objimovel.descricao = txtdescricao.Text;
                    objimovel.quartos = int.Parse(ddlquarto.SelectedValue);
                    objimovel.banheiro = int.Parse(ddlbanheiro.SelectedValue);
                    objimovel.suite = int.Parse(ddlsuite.SelectedValue);
                    objimovel.garagem = int.Parse(ddlgaragem.SelectedValue);
                    objimovel.areatotal = txtareatotal.Text;
                    objimovel.valor = txtvalor.Text;
                    objimovel.tratar = txttratar.Text;
                    objimovel.telefone = txttelefone.Text;
                    objimovel.agua = chkagua.Checked;
                    objimovel.lavanderia = chklavanderia.Checked;
                    objimovel.alarme = chkalarme.Checked;
                    objimovel.academia = chkacademia.Checked;
                    objimovel.camera = chkcamera.Checked;
                    objimovel.churrasqueira = chkchurrasqueira.Checked;
                    objimovel.cerca = chkcerca.Checked;
                    objimovel.esgoto = chkesgoto.Checked;
                    objimovel.gas = chkgas.Checked;
                    objimovel.playground = chkplayground.Checked;
                    objimovel.piscina = chkpiscina.Checked;
                    objimovel.portaria = chkportaria.Checked;
                    objimovel.quintal = chkquintal.Checked;
                    objimovel.quadra = chkquadra.Checked;
                    objimovel.sauna = chksauna.Checked;
                    objimovel.wifi = chkwifi.Checked;
                    imovelDao.EditarCampos(objimovel);

                }
            }
            catch
            {
            }
        }

        protected void btnexcluir_Click(object sender, EventArgs e)
        {
            var referencia = txtreferencia.Text;

            try
            {
                if (!string.IsNullOrEmpty(referencia))
                {

                    ImovelDAO imovelDao = new ImovelDAO();
                    imovelDao.excluirImovel(referencia);
                    limparCampos();
                }
            }
            catch
            {
            }
        }

        protected void limparCampos()
        {
            txtbairro.Text = "";
            txtendereco.Text = "";
            txtcidade.Text = "";
            txtcep.Text = "";
            txtnumero.Text = "";
            txtreferencia.Text = "";
            txttitulo.Text = "";
            rdbativo.Text = "";
            ddltipoimovel.SelectedValue = "";
            ddlfinalidade.SelectedValue = "";
            txtdescricao.Text = "";
            ddlquarto.SelectedValue = "";
            ddlbanheiro.SelectedValue = "";
            ddlsuite.SelectedValue = "";
            ddlgaragem.SelectedValue = "";
            txtareatotal.Text = "";
            txtvalor.Text = "";
            txttratar.Text = "";
            txttelefone.Text = "";
            chkagua.Checked = false;
            chklavanderia.Checked = false;
            chkalarme.Checked = false;
            chkacademia.Checked = false;
            chkcamera.Checked = false;
            chkchurrasqueira.Checked = false;
            chkcerca.Checked = false;
            chkesgoto.Checked = false;
            chkgas.Checked = false;
            chkplayground.Checked = false;
            chkpiscina.Checked = false;
            chkportaria.Checked = false;
            chkquintal.Checked = false;
            chkquadra.Checked = false;
            chksauna.Checked = false;
            chkwifi.Checked = false;
        }
    }
}