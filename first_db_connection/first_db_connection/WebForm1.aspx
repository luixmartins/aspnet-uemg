<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="first_db_connection.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="btn_adcionar">
            <asp:Label ID="lbl_msgerro" runat="server"></asp:Label>
            <br />
            Nome a procurar:
            <asp:TextBox ID="txt_procurar" runat="server" Width="189px"></asp:TextBox>
            &nbsp;<asp:Button ID="btn_procurar" runat="server" OnClick="btn_procurar_Click" Text="Procurar" />
            <br />
            <br />
            <asp:ListBox ID="lst_dadis" runat="server" OnSelectedIndexChanged="lst_dadis_SelectedIndexChanged" Width="120px" AutoPostBack="True"></asp:ListBox>
            <br />
            <br />
            <asp:HyperLink runat="server" NavigateUrl="~/WebForm2.aspx">Abrir WebForm2</asp:HyperLink>
            <br />
            <br />
            Para inserir<br />
            <br />
            Nome:
            <asp:TextBox ID="txt_nome" runat="server" Width="419px"></asp:TextBox>
            <br />
            <br />
            Email: <asp:TextBox ID="txt_email" runat="server" Width="419px"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_adcionar" runat="server" OnClick="btn_adcionar_Click" Text="Inserir" Width="130px" />
&nbsp;
            <asp:Button ID="btn_alterar" runat="server" Text="Alterar" OnClick="btn_alterar_Click" Width="130px" />
            &nbsp;
            <asp:Button ID="btn_excluir" runat="server" OnClick="btn_excluir_Click" Text="Excluir" Width="130px" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_limpa" runat="server" OnClick="btn_limpa_Click" Text="Limpar campos" Width="130px" />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
