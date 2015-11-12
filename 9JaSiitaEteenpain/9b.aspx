<%@ Page Language="C#" AutoEventWireup="true" CodeFile="9b.aspx.cs" Inherits="_9b" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <!-- 1 datasourcen määritely -->
        <asp:SqlDataSource ID="srcMuuvit"
            ConnectionString="<%$ ConnectionStrings:Muuvit %>"
            SelectCommand="SELECT title, director, year FROM movies"
            runat="server"> </asp:SqlDataSource>
        <!-- 2 datakontrolli datan esittämistä varten -->
        <h2>Movies from SQL Server</h2>
        <asp:GridView ID="gvMuuvit" 
            DataSourceID="srcMuuvit"
            runat="server" BorderStyle="Solid">
            <HeaderStyle BackColor="#0066FF" ForeColor="White" />
        </asp:GridView>
    </div>
        <div>
        <!-- 1 XMLdatasourcen määritely -->
        <asp:XmlDataSource ID="XmlDataSource1"
            DataFile="~/App_Data/Movies.xml"
             runat="server"></asp:XmlDataSource>
        <!-- 2 datakontrolli datan esittämistä varten -->
        <h2>Movies from XML File</h2>
        <asp:GridView ID="GridView1" 
            DataSourceID="XmlDataSource1"
            runat="server">
            <HeaderStyle BackColor="#CC0000" ForeColor="White" />
            </asp:GridView>
    </div>
    </form>
</body>
</html>
