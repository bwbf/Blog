<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Blog.web.Views.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Cadastro</div>
        Nome:<asp:TextBox ID="TxtNome" runat="server" Height="16px" Width="196px"></asp:TextBox>
        <p>
            Email<asp:TextBox ID="txtEmail" runat="server" Width="200px"></asp:TextBox>
        </p>
        <p>
            Usuario:<asp:TextBox ID="txtUsuario" runat="server" OnTextChanged="TextBox2_TextChanged" Width="183px"></asp:TextBox>
        </p>
        <p>
            Senha:<asp:TextBox ID="TxtSenha" runat="server" Width="189px"></asp:TextBox>
        </p>
        Confirmar Senha:<asp:TextBox ID="txtSenha2" runat="server" Width="128px"></asp:TextBox>
        <p>
            <asp:Label ID="lbErro" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Cadastrar" />
        </p>
    </form>
</body>
</html>
