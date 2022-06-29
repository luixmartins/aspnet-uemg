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
            <asp:ListBox ID="lst_dadis" runat="server"></asp:ListBox>
            <br />
            <br />
            Para inserir<br />
            <br />
            Nome:
            <asp:TextBox ID="txt_nome" runat="server"></asp:TextBox>
            <br />
            <br />
            Email: <asp:TextBox ID="txt_email" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_adcionar" runat="server" OnClick="btn_adcionar_Click" Text="Inserir" Width="90px" />
&nbsp;&nbsp;&nbsp;
            <br />
        </div>
    </form>
</body>
</html>
