<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Label">Nimesi</asp:Label>
        <asp:TextBox ID="TxtName" runat="server" Width="105px"></asp:TextBox>
        <asp:RequiredFieldValidator ForeColor="Red" ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtName" ErrorMessage="Haista vittu"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label">Sähköpostiosoitteesi</asp:Label>
        <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ForeColor="Red" ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxtEmail" ErrorMessage="Haista vittu"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$" ControlToValidate="TxtEmail" ErrorMessage="RegularExpressionValidator"></asp:RegularExpressionValidator>
        <br />
        <asp:Button ID="BtnLogin" runat="server" Text="Sisään" OnClick="BtnLogin_Click" />
    </div>
    </form>
</body>
</html>
