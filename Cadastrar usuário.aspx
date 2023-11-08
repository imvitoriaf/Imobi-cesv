<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastrar usuário.aspx.cs" Inherits="ImobCESV.Cadastrar_usuário" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 108px;
        }
        .auto-style2 {
            width: 108px;
            height: 26px;
        }
        .auto-style3 {
            height: 26px;
        }
        .auto-style4 {
            width: 108px;
            height: 30px;
        }
        .auto-style5 {
            height: 30px;
        }
        .auto-style6 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style6">
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    <asp:Label ID="lbltitulocadastrarusuario" runat="server" Font-Names="Arial Black" Text="CADASTRAR USUÁRIO"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="lblnomecadastro" runat="server" Font-Names="Arial" Text="Nome:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtnomecadastro" runat="server" Font-Names="Arial" Width="235px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblcadastraremail" runat="server" Font-Names="Arial" Text="E-mail:"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtcadastraremail" runat="server" Font-Names="Arial" Width="237px"></asp:TextBox>
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="lblcadastrarsenha" runat="server" Font-Names="Arial" Text="Senha:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtcadastrarsenha" runat="server" Font-Names="Arial" Width="235px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style5">
                    <asp:Button ID="btncadusuario" runat="server" OnClick="btncadusuario_Click1" Text="Cadastrar usuário" />
                &nbsp;
                    <asp:Button ID="btnvoltar" runat="server" Font-Names="Arial" OnClick="btnvoltar_Click" Text="Voltar" />
                </td>
                <td class="auto-style5"></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    <asp:Label ID="lblmensagemcadusuario" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
