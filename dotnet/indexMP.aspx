<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="indexMP.aspx.cs" Inherits="indexMP" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <asp:Label ID="sessionTarkistus" runat="server" Text="..."></asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

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
       
</asp:Content>

