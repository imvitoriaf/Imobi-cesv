<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ImobCESV.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 93px;
        }
        .auto-style3 {
            height: 168px;
            margin-top: 0px;
        }
        .auto-style4 {
            width: 93px;
            height: 30px;
        }
        .auto-style5 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" >
        <div class="auto-style3" >
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style1">&nbsp;</td>
                        <td>
                            <asp:Label ID="lbllogin1" runat="server" Font-Bold="True" Font-Italic="True" 
                                Text="Imob CESV" Font-Names="Arial Black"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">&nbsp;&nbsp;
                            <asp:Label ID="lblemail" runat="server" Text="E-mail:" Font-Names="Arial"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtemail" runat="server" Font-Names="Arial"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">&nbsp;&nbsp;
                            <asp:Label ID="lblsenha" runat="server" Text="Senha:" Font-Names="Arial"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtsenha" runat="server" TextMode="Password" Font-Names="Arial"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">&nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style4"></td>
                        <td class="auto-style5">
                            <asp:Button ID="btnentrar" runat="server" OnClick="btnentrar_Click" Text="Entrar" Font-Names="Arial" />
                            <asp:Button ID="btncadastrousuario" runat="server" OnClick="btncadastrar_Click" Text="Cadastrar" />
                        </td>
                        <td class="auto-style5"></td>
                    </tr>
                    <tr>
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style5">
                            <asp:Label ID="lblmensagem" runat="server"></asp:Label>
                        </td>
                        <td class="auto-style5">&nbsp;</td>
                    </tr>
                </table>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
