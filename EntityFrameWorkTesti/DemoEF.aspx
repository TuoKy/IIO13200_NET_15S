<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DemoEF.aspx.cs" Inherits="DemoEF" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customers from Viini with EF</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Viini-tietokannan Asiakkaat 12.11.2015</h1>
        <asp:Button ID="buttonGetAllcustomers" runat="server" Text="Hae kaikki asiakkaat" OnClick="buttonGetAllcustomers_Click" />
        <asp:DropDownList ID="ddlCities" runat="server"></asp:DropDownList>
        <asp:Button ID="buttongetAllCustomersFromCity" runat="server" Text="Hae aasiakkaat valitusta kaupungista" OnClick="buttongetAllCustomersFromCity_Click" />
        <asp:Button ID="buttonGetCustomerByCicy" runat="server" Text="Hae kaikki asiakkaat kaupungittain" OnClick="buttonGetCustomerByCicy_Click" />
         <br />
        <asp:Label ID="lblMessages" runat="server" Text="..."></asp:Label>
        <div id="tulos" runat="server">

        </div>
        <asp:GridView ID="gvData" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
