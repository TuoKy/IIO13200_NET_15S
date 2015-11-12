<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DemoEF_uusi.aspx.cs" Inherits="DemoEF_uusi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Asiakkaan lisäys</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h3>Aasiakkaan tiedot</h3>
        <table>
            <tr>
                <td>Etunimi</td>
                <td><asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Sukunimi</td>
                <td><asp:TextBox ID="txtLastName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Osoite</td>
                <td><asp:TextBox ID="txtAdress" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Zip</td>
                <td><asp:TextBox ID="txtZip" runat="server"></asp:TextBox></td>
            </tr>
             <tr>
                <td>Kaupunki</td>
                <td><asp:TextBox ID="txtCity" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="lblMessages" runat="server" Text="..."></asp:Label></td>
                <td><asp:Button ID="btnAddCustomer" runat="server" Text="Lisää aasiakas" OnClick="btnAddCustomer_Click" /></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
