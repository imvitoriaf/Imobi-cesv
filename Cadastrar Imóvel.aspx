<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastrar Imóvel.aspx.cs" Inherits="ImobCESV.Cadastrar_Imóvel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style3 {
            width: 297px;
        }
        .auto-style4 {
            width: 5px;
        }
        .auto-style5 {
            width: 374px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;" border="0">
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style55" colspan="4">
                        <asp:Label ID="lblcadastrar" runat="server" Font-Bold="True" Font-Italic="False" Text="CADASTRAR IMÓVEL"
                            Font-Names="Arial Black"></asp:Label>
                    </td>
                    <td class="auto-style80"></td>
                    <td class="auto-style17"></td>
                    <td class="auto-style71"></td>
                    <td class="auto-style63"></td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style5">
                        &nbsp;</td>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td class="auto-style18">
                        &nbsp;</td>
                    <td class="auto-style72">
                        &nbsp;</td>
                    <td class="auto-style64">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <br />
                    </td>
                    <td class="auto-style5">
                        &nbsp;<asp:Label ID="lblreferencia" runat="server" Text="Referência:" Font-Names="Arial"></asp:Label><br />
                        <asp:TextBox ID="txtreferencia" runat="server" OnTextChanged="TextBox1_TextChanged" Width="260px"
                            Font-Names="Arial"></asp:TextBox>
                        <br />
                    </td>
                    <td class="auto-style3">
                        <asp:Label ID="lbltitulo" runat="server" Text="Título do anúncio:  " Font-Names="Arial"></asp:Label>
                        <asp:TextBox ID="txttitulo" runat="server" OnTextChanged="TextBox1_TextChanged" Width="161px" 
                            Font-Names="Arial"></asp:TextBox>
                    </td>
                    <td class="auto-style19">
                        <asp:RadioButtonList ID="rdbativo" runat="server" Width="114px" Font-Names="Arial">
                            <asp:ListItem>Ativo</asp:ListItem>
                            <asp:ListItem>Inativo</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    <td class="auto-style79">
                        &nbsp;</td>
                    <td class="auto-style65">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style5">
                        <asp:Label ID="lblendereco" runat="server" Text="Endereço:  " Font-Names="Arial"></asp:Label><br />
                        <asp:TextBox ID="txtendereco" runat="server" Width="260px" Font-Names="Arial"></asp:TextBox>
&nbsp; </td>
                    <td class="auto-style3">
                        <asp:Label ID="lblcep" runat="server" Text="CEP:" Font-Names="Arial"></asp:Label><br />
                        <asp:TextBox ID="txtcep" runat="server" Width="132px" Font-Names="Arial"></asp:TextBox>
                        <asp:Button ID="btnvalidarcep" runat="server" OnClick="btnvalidarcep_Click" Text="Validar CEP" 
                            Font-Names="Arial" />
                    </td>
                    <td class="auto-style20">
                        <asp:Label ID="lblbairro" runat="server" Text="Bairro:" Font-Names="Arial"></asp:Label><br />
                        <asp:TextBox ID="txtbairro" runat="server" Width="161px" Font-Names="Arial"></asp:TextBox>
                    </td>
                    <td class="auto-style74">

                        <br />

                    </td>
                    <td class="auto-style66">
                        <br />

                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">

                        <asp:Label ID="lblcidade" runat="server" Text="Cidade:" Font-Names="Arial"></asp:Label><br />
                        <asp:TextBox ID="txtcidade" runat="server" Font-Names="Arial"></asp:TextBox>

                    </td>
                    <td class="auto-style3">
                        <asp:Label ID="lblnumero" runat="server" Text="Número:" Font-Names="Arial"></asp:Label><br />

                        <asp:TextBox ID="txtnumero" runat="server" Width="80px" Font-Names="Arial"></asp:TextBox>
                    </td>
                    <td class="auto-style20">
                        &nbsp;</td>
                    <td class="auto-style74">

                        &nbsp;</td>
                    <td class="auto-style66">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">

                        &nbsp;</td>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td class="auto-style20">
                        &nbsp;</td>
                    <td class="auto-style74">

                        &nbsp;</td>
                    <td class="auto-style66">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style5">
                        <asp:Label ID="lbltipoimovel" runat="server" Text="Tipo de imóvel:  " Font-Names="Arial"></asp:Label>
                        <asp:DropDownList ID="ddltipoimovel" runat="server" Width="150px" Font-Names="Arial">
                            <asp:ListItem>Apartamento</asp:ListItem>
                            <asp:ListItem>Casa </asp:ListItem>
                            <asp:ListItem>Sobrado</asp:ListItem>
                            <asp:ListItem>Kitnet/conjugado</asp:ListItem>
                            <asp:ListItem>Flat</asp:ListItem>
                            <asp:ListItem>Loft</asp:ListItem>
                            <asp:ListItem>Studio</asp:ListItem>
                            <asp:ListItem>Casa de condominio</asp:ListItem>
                            <asp:ListItem>Cobertura</asp:ListItem>
                            <asp:ListItem>Lote/terreno</asp:ListItem>
                            <asp:ListItem>Fazenda/Sitío/Chácara</asp:ListItem>
                            <asp:ListItem>Consultório</asp:ListItem>
                            <asp:ListItem>Galpão/depósito/armazén</asp:ListItem>
                            <asp:ListItem>imóvel comercial</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                    </td>
                    <td class="auto-style3">
                        <asp:Label ID="lblfinalidade" runat="server" Text="Finalidade:  " Font-Names="Arial"></asp:Label>
                        <asp:DropDownList ID="ddlfinalidade" runat="server" Width="150px" Font-Names="Arial">
                            <asp:ListItem>Compra</asp:ListItem>
                            <asp:ListItem>Aluguel</asp:ListItem>
                            <asp:ListItem>Temporada</asp:ListItem>
                            <asp:ListItem>Venda</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style24"></td>
                    <td class="auto-style75"></td>
                    <td class="auto-style67"></td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style5">
                        <asp:Label ID="lbldescricao" runat="server" Text="Descrição do imóvel:" Font-Names="Arial"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtdescricao" runat="server" Height="52px" Width="251px"></asp:TextBox>
                        <br />
                        </td>
                    <td class="auto-style3"></td>
                    <td class="auto-style35"></td>
                    <td class="auto-style76"></td>
                    <td class="auto-style68"></td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style19">&nbsp;</td>
                    <td class="auto-style79">&nbsp;</td>
                    <td class="auto-style65">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Label ID="lblinformacoes" runat="server" Font-Bold="True" Text="INFORMAÇÕES DO IMÓVEL" 
                            Font-Names="Arial Black"></asp:Label>
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style19">&nbsp;</td>
                    <td class="auto-style79">&nbsp;</td>
                    <td class="auto-style65">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style19">&nbsp;</td>
                    <td class="auto-style79">&nbsp;</td>
                    <td class="auto-style65">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style5">
                        <asp:Label ID="lblquarto" runat="server" Text="Quarto(s):" Font-Names="Arial"></asp:Label>
                        <asp:DropDownList ID="ddlquarto" runat="server" Font-Names="Arial">
                            <asp:ListItem>0</asp:ListItem>
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                            <asp:ListItem>6</asp:ListItem>
                            <asp:ListItem>7</asp:ListItem>
                            <asp:ListItem>8</asp:ListItem>
                            <asp:ListItem>9</asp:ListItem>
                            <asp:ListItem>10</asp:ListItem>
                        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblbanheiro" runat="server" Text="Banheiro(s):" Font-Names="Arial"></asp:Label>
                        <asp:DropDownList ID="ddlbanheiro" runat="server" Font-Names="Arial">
                            <asp:ListItem>0</asp:ListItem>
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                            <asp:ListItem>6</asp:ListItem>
                            <asp:ListItem>7</asp:ListItem>
                            <asp:ListItem>8</asp:ListItem>
                            <asp:ListItem>9</asp:ListItem>
                            <asp:ListItem>10</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style3">
                        <asp:Label ID="lblsuite" runat="server" Text="Suíte(s):" Font-Names="Arial"></asp:Label>
                        <asp:DropDownList ID="ddlsuite" runat="server" Font-Names="Arial">
                            <asp:ListItem>0</asp:ListItem>
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                            <asp:ListItem>6</asp:ListItem>
                            <asp:ListItem>7</asp:ListItem>
                            <asp:ListItem>8</asp:ListItem>
                            <asp:ListItem>9</asp:ListItem>
                            <asp:ListItem>10</asp:ListItem>
                        </asp:DropDownList>
                        &nbsp;<asp:Label ID="lblgaragem" runat="server" Text="Vaga de garagem:" Font-Names="Arial"></asp:Label>
                        <asp:DropDownList ID="ddlgaragem" runat="server" Font-Names="Arial">
                            <asp:ListItem>0</asp:ListItem>
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                            <asp:ListItem>6</asp:ListItem>
                            <asp:ListItem>7</asp:ListItem>
                            <asp:ListItem>8</asp:ListItem>
                            <asp:ListItem>9</asp:ListItem>
                            <asp:ListItem>10</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style40">&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblarea" runat="server" Text="Area total em m²:" Font-Names="Arial"></asp:Label>
                        <asp:TextBox ID="txtareatotal" runat="server" Width="36px"></asp:TextBox>
                    </td>
                    <td class="auto-style77">&nbsp;</td>
                    <td class="auto-style69">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">&nbsp;&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style19">&nbsp;</td>
                    <td class="auto-style79">&nbsp;</td>
                    <td class="auto-style65">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Label ID="lblvalor" runat="server" Text="Valor do imóvel:" Font-Names="Arial"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtvalor" runat="server" Width="260px" Font-Names="Arial"></asp:TextBox>
                    </td>
                    <td class="auto-style3">
                        <asp:Label ID="lbltratar" runat="server" Text="Tratar com:" Font-Names="Arial"></asp:Label><br />
                        <asp:TextBox ID="txttratar" runat="server" Width="259px" Font-Names="Arial"></asp:TextBox>
                        <br />
                    </td>
                    <td class="auto-style19">
                        <asp:Label ID="lbltelefone" runat="server" Text="Telefone para contato:" Font-Names="Arial"></asp:Label><br />
                        <asp:TextBox ID="txttelefone" runat="server" Width="180px" Font-Names="Arial"></asp:TextBox>
                    </td>
                    <td class="auto-style79">&nbsp;</td>
                    <td class="auto-style65">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">
                        &nbsp;</td>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td class="auto-style19">
                        &nbsp;</td>
                    <td class="auto-style79">&nbsp;</td>
                    <td class="auto-style65">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style5">
                        <asp:Label ID="lblcaracteristicas" runat="server" Font-Bold="True" Text="CARACTERÍSTICAS DO IMÓVEL" 
                            Font-Names="Arial Black"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        </td>
                    <td class="auto-style91">
                        </td>
                    <td class="auto-style92"></td>
                    <td class="auto-style93"></td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style5">
                        <asp:CheckBox ID="chkagua" runat="server" Text="Água" Font-Names="Arial" />
                    </td>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td class="auto-style45">
                        &nbsp;</td>
                    <td class="auto-style78"></td>
                    <td class="auto-style70">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style5">
                        <asp:CheckBox ID="chklavanderia" runat="server" Text="Lavanderia" Font-Names="Arial" />
&nbsp;
                        &nbsp;
                        </td>
                    <td class="auto-style3">
                        &nbsp;&nbsp;&nbsp;
                        &nbsp;
                        &nbsp;
                        </td>
                    <td class="auto-style45">
                        &nbsp;</td>
                    <td class="auto-style78"></td>
                    <td class="auto-style70">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:CheckBox ID="chkalarme" runat="server" Text="Alarme" Font-Names="Arial" />
                        </td>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td class="auto-style45">
                        &nbsp;</td>
                    <td class="auto-style78">&nbsp;</td>
                    <td class="auto-style70">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:CheckBox ID="chkacademia" runat="server" Text="Acadêmia" Font-Names="Arial" />
                    </td>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td class="auto-style45">
                        &nbsp;</td>
                    <td class="auto-style78">&nbsp;</td>
                    <td class="auto-style70">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:CheckBox ID="chkcamera" runat="server" Text="Câmeras de segurança" Font-Names="Arial" />
                    </td>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td class="auto-style45">
                        &nbsp;</td>
                    <td class="auto-style78">&nbsp;</td>
                    <td class="auto-style70">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:CheckBox ID="chkchurrasqueira" runat="server" Text="Churrasqueira" Font-Names="Arial" />
                        </td>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td class="auto-style45">
                        &nbsp;</td>
                    <td class="auto-style78">&nbsp;</td>
                    <td class="auto-style70">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:CheckBox ID="chkcerca" runat="server" Text="Cerca elétrica" Font-Names="Arial" />
                        </td>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td class="auto-style45">
                        &nbsp;</td>
                    <td class="auto-style78">&nbsp;</td>
                    <td class="auto-style70">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:CheckBox ID="chkesgoto" runat="server" Text="Esgoto" Font-Names="Arial" />
                    </td>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td class="auto-style45">
                        &nbsp;</td>
                    <td class="auto-style78">&nbsp;</td>
                    <td class="auto-style70">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:CheckBox ID="chkgas" runat="server" Text="Gás encanado" Font-Names="Arial" />
                    </td>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td class="auto-style45">
                        &nbsp;</td>
                    <td class="auto-style78">&nbsp;</td>
                    <td class="auto-style70">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:CheckBox ID="chkplayground" runat="server" Text="Playground" Font-Names="Arial" />
                    </td>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td class="auto-style45">
                        &nbsp;</td>
                    <td class="auto-style78">&nbsp;</td>
                    <td class="auto-style70">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:CheckBox ID="chkpiscina" runat="server" Text="Piscina" Font-Names="Arial" />
                    </td>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td class="auto-style45">
                        &nbsp;</td>
                    <td class="auto-style78">&nbsp;</td>
                    <td class="auto-style70">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:CheckBox ID="chkportaria" runat="server" Text="Portaria" Font-Names="Arial" />
                    </td>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td class="auto-style45">
                        &nbsp;</td>
                    <td class="auto-style78">&nbsp;</td>
                    <td class="auto-style70">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:CheckBox ID="chkquintal" runat="server" Text="Quintal" Font-Names="Arial" />
                    </td>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td class="auto-style45">
                        &nbsp;</td>
                    <td class="auto-style78">&nbsp;</td>
                    <td class="auto-style70">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:CheckBox ID="chkquadra" runat="server" Text="Quadra esportiva" Font-Names="Arial" />
                        </td>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td class="auto-style45">
                        &nbsp;</td>
                    <td class="auto-style78">&nbsp;</td>
                    <td class="auto-style70">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:CheckBox ID="chksauna" runat="server" Text="Sauna" Font-Names="Arial" />
                    </td>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td class="auto-style45">
                        &nbsp;</td>
                    <td class="auto-style78">&nbsp;</td>
                    <td class="auto-style70">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:CheckBox ID="chkwifi" runat="server" Text="WIFI" Font-Names="Arial" />
                    </td>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td class="auto-style45">
                        &nbsp;</td>
                    <td class="auto-style78">&nbsp;</td>
                    <td class="auto-style70">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">
                        &nbsp;</td>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td class="auto-style45">
                        &nbsp;</td>
                    <td class="auto-style78">&nbsp;</td>
                    <td class="auto-style70">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Button ID="btncadastrar" runat="server" Text="Cadastrar" Font-Names="Arial" 
                            OnClick="btncadastrar_Click" />
                        <asp:Button ID="btnpesquisar" runat="server" OnClick="btnpesquisar_Click" Text="Pesquisar" />
                        <asp:Button ID="btnalterar" runat="server" Text="Alterar" OnClick="btnalterar_Click" />
                        <asp:Button ID="btnexcluir" runat="server" Text="Excluir" OnClick="btnexcluir_Click" />
                    </td>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td class="auto-style45">
                        &nbsp;</td>
                    <td class="auto-style78">&nbsp;</td>
                    <td class="auto-style70">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Label ID="lblmensagemcadimovel" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td class="auto-style45">
                        &nbsp;</td>
                    <td class="auto-style78">&nbsp;</td>
                    <td class="auto-style70">&nbsp;</td>
                </tr>
            </table>
        </div>
    <p>
        &nbsp;</p>
    </form>
    </body>
</html>
