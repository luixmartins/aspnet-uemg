<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calculator_form.aspx.cs" Inherits="calculator.calculator_form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl_total" runat="server" BorderStyle="Inset" Text="0" Width="250px"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btn_7" runat="server" Font-Bold="True" OnClick="Insert_Number" Text="7" Width="56px" />
&nbsp;<asp:Button ID="btn_8" runat="server" Font-Bold="True" OnClick="Insert_Number" Text="8" Width="56px" />
&nbsp;<asp:Button ID="btn_9" runat="server" Font-Bold="True" OnClick="Insert_Number" Text="9" Width="56px" />
&nbsp;<asp:Button ID="btn_soma" runat="server" Font-Bold="True" OnClick="op_Click" Text="+" Width="56px" />
&nbsp;
            <asp:Button ID="btn_CE" runat="server" Font-Bold="True" OnClick="Clean_Values" Text="CE" Width="56px" />
&nbsp;
            <br />
            <br />
            <asp:Button ID="btn_4" runat="server" Font-Bold="True" OnClick="Insert_Number" Text="4" Width="56px" />
&nbsp;<asp:Button ID="btn_5" runat="server" Font-Bold="True" OnClick="Insert_Number" Text="5" Width="56px" />
&nbsp;<asp:Button ID="btn_6" runat="server" Font-Bold="True" OnClick="Insert_Number" Text="6" Width="56px" />
&nbsp;<asp:Button ID="btn_sub" runat="server" Font-Bold="True" OnClick="op_Click" Text="-" Width="56px" />
&nbsp;
            <asp:Button ID="btn_C" runat="server" Font-Bold="True" OnClick="Clean_Values" Text="C" Width="56px" />
            <br />
            <br />
            <asp:Button ID="btn_1" runat="server" Font-Bold="True" OnClick="Insert_Number" Text="1" Width="56px" />
&nbsp;<asp:Button ID="btn_2" runat="server" Font-Bold="True" OnClick="Insert_Number" Text="2" Width="56px" />
&nbsp;<asp:Button ID="btn_3" runat="server" Font-Bold="True" OnClick="Insert_Number" Text="3" Width="56px" />
&nbsp;<asp:Button ID="btn_multi" runat="server" Font-Bold="True" OnClick="op_Click" Text="*" Width="56px" />
&nbsp;
            <asp:Button ID="btn_back" runat="server" Font-Bold="True" OnClick="Clean_Values" Text="&lt;&lt;" Width="56px" />
            <br />
            <br />
            <asp:Button ID="btn_0" runat="server" Font-Bold="True" OnClick="Insert_Number" Text="0" Width="56px" />
&nbsp;<asp:Button ID="btn_ponto" runat="server" Font-Bold="True" OnClick="btn_ponto_Click" Text="." Width="56px" />
&nbsp;<asp:Button ID="btn_result" runat="server" Font-Bold="True" OnClick="btn_result_Click" Text="=" Width="56px" />
&nbsp;<asp:Button ID="btn_div" runat="server" Font-Bold="True" OnClick="op_Click" Text="/" Width="56px" />
            <br />
            <br />
            <asp:HiddenField ID="hd_total" runat="server" />
            <asp:HiddenField ID="hd_operacao" runat="server" />
        </div>
    </form>
</body>
</html>
