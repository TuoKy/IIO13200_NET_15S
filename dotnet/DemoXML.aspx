<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DemoXML.aspx.cs" Inherits="DemoXML" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <!-- 1 XMLdatasourcen määritely -->
        <asp:XmlDataSource ID="srcMuuvit"
            DataFile="~/App_Data/Movies.xml"
             runat="server"></asp:XmlDataSource>
        <asp:XmlDataSource ID="srcLevyt"
            DataFile="~/App_Data/LevykauppaX.xml"
            XPath="Records/genre[@name='Pop']/record" 
            runat="server"></asp:XmlDataSource>
        <!-- 2 datakontrolli datan esittämistä varten -->
        <h2>Kinnfino ylpeänä esittää </h2>
        <asp:GridView ID="gvMuuvit" 
            DataSourceID="srcMuuvit"
            runat="server"></asp:GridView>
        <!-- 2b. Vaihtoehtoinen tapa datan esittämistä varten käyttäen data repeatteriä -->
        <h2>Kinnfino toisen kerran ylpeänä esittää</h2>
        <asp:Repeater ID="Repeater1" DataSourceID="srcMuuvit" runat="server">
             <HeaderTemplate>
                <table border="1">
                    <tr>
                        <th>Nimi</th>
                        <th>Maa</th>
                        <th>Ohjaaja</th>
                    </tr>
                
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Eval("Name") %></td>
                    <td><%# Eval("Country") %></td>
                    <td><%# Eval("Director") %></td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>            
        </asp:Repeater>

        <h2>raah</h2>
        <asp:Repeater ID="Repeater2" DataSourceID="srcMuuvit" runat="server">
                        <ItemTemplate><b><%# Eval("Name") %></b> directed by <%# Eval("Director") %> <br /></ItemTemplate>
        </asp:Repeater>

        <h2>Levykaupan erikoistarjoukset vain tänään Repeater-lla</h2>
         <asp:Repeater ID="Repeater3" DataSourceID="srcLevyt" runat="server">
                        <ItemTemplate><b><%# Eval("Artist") %></b> presents <%# Eval("Title") %> 
                            <img alt="Kansikuva" src='<%# "images/" + Eval("ISBN") + ".jpg" %>' /><br />
                        </ItemTemplate>
        </asp:Repeater>
    </div>
    </form>
</body>
</html>
