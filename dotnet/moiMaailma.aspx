<%@ Page Language="C#" AutoEventWireup="true" CodeFile="moiMaailma.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Heippa maailma</h1>
        <asp:Label ID="lblHello" runat="server" Text="label"> Yo, anna nimi</asp:Label>
        <asp:TextBox ID="tebNimi" runat="server"></asp:TextBox>
        <asp:Button ID="btnFire" Text="paina Tästä"  runat ="server" OnClick="btnFire_Click"/>

    </div>
    </form>
</body>
</html>
