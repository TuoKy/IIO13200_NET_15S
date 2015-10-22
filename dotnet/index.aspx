<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>IIO13200 .NET Ohjelmointi</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:HyperLink ID="linkki" runat="server" NavigateUrl="~/Default.aspx">Eka sivuni</asp:HyperLink>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Viinit.aspx">Perjantai softa</asp:HyperLink>
    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/DemoxOy.aspx">Kari Grandi</asp:HyperLink>
    </div>
    </form>
</body>
</html>
