<%@ Page Language="C#" AutoEventWireup="true" CodeFile="10b.aspx.cs" Inherits="_10b" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <img src="Images/logo.png" />
        <asp:XmlDataSource ID="srcLevyt"
            DataFile="~/App_Data/LevykauppaX.xml"
            runat="server">
        </asp:XmlDataSource>
        <!--Olis tosi kätevää jos osaisin muokata haettavien objektien xpathia nini voisin asettaa että hae kaikki lapset-->
        <asp:XmlDataSource ID="srcKappaleet"
            DataFile="~/App_Data/LevykauppaX.xml"
            runat="server">
        </asp:XmlDataSource>
        <p>
        <asp:Repeater ID="Repeater1" DataSourceID="srcLevyt" runat="server">
                        <ItemTemplate>
                            <img alt="Kansikuva" src='<%# "images/" + Eval("ISBN") + ".jpg" %>' /><br />
                            <h2><%# Eval("Artist")%> <%# Eval("Title") %> </h2>
                            <b>ISBN: </b><%# Eval("ISBN") %> <br />
                            <b>Hinta: </b><%# Eval("Price") %> <br />
                            <b>Levyn biisit</b>   
                        </ItemTemplate>
        </asp:Repeater>
        <asp:Repeater ID="Repeater2" DataSourceID="srcKappaleet" runat="server">
            <HeaderTemplate>
                <ul>
            </HeaderTemplate>
            <ItemTemplate>
                <li>
                    <%# Eval("name") %>
                </li>
            </ItemTemplate>
            <FooterTemplate>
                </ul>
            </FooterTemplate>
        </asp:Repeater>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/teht10.aspx">Takaisin</asp:HyperLink>
        </p>

    </div>
    </form>
</body>
</html>
