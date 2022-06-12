<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="name_registration.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txt_nome" runat="server" Height="28px" Width="248px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_adc" runat="server" OnClick="btn_adc_Click" Text="Adcionar" Width="80px" />
&nbsp;
            <asp:Button ID="btn_pesquisa" runat="server" OnClick="btn_pesquisa_Click" Text="Pesquisar" Width="80px" />
&nbsp;
            <asp:Button ID="btn_excluir" runat="server" OnClick="btn_excluir_Click" Text="Excluir" Width="80px" />
            <br />
            <br />
            <asp:ListBox ID="listBox_nomes" runat="server" Height="175px" SelectionMode="Multiple" Width="254px"></asp:ListBox>
&nbsp;
            <asp:Button ID="btn_excluir_mult" runat="server" OnClick="btn_excluir_mult_Click" Text="Excluir Múltiplos" Width="120px" />
        </div>
    </form>
</body>
</html>
