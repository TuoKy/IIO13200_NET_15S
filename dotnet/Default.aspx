﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>IIO13200 .NET Ohjelmointi</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>22.10</h1>
        <asp:HyperLink ID="linkki" runat="server" NavigateUrl="~/moiMaailma.aspx">Eka sivuni</asp:HyperLink>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Viinit.aspx">Perjantai softa</asp:HyperLink>
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/DemoxOy.aspx">Kari Grandi</asp:HyperLink>
    </div>
    <div>
        <h1>29.10</h1>
        <asp:HyperLink runat="server" NavigateUrl="~DemoSQL.aspx">Raah </asp:HyperLink>
        <asp:HyperLink runat="server" NavigateUrl="~DemoXML.aspx">Raah </asp:HyperLink>
    </div>
    <div>
        <h1>5.11</h1>
        <asp:HyperLink runat="server" NavigateUrl="~indexMP.aspx">Raah </asp:HyperLink>
    </div>
        
    </form>
</body>
</html>
