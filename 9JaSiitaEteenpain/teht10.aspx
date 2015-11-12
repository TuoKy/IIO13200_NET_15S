<%@ Page Language="C#" AutoEventWireup="true" CodeFile="teht10.aspx.cs" Inherits="teht10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Reilunkaupan levykauppa</title>
    <link href="teht10Style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <img src="Images/logo.png" />
        <asp:XmlDataSource ID="srcLevyt"
            DataFile="~/App_Data/LevykauppaX.xml"
            XPath="Records/genre/record" 
            runat="server">
        </asp:XmlDataSource>
        
        <asp:Repeater ID="Repeater1" DataSourceID="srcLevyt" runat="server">
            <ItemTemplate>
                <div id="Kehys">
                    <img alt="Kansikuva" id="pikkukuva" src='<%# "images/" + Eval("ISBN") + ".jpg" %>' />
                    <div id="tekstiKakat">
                        <b><%# Eval("Artist") %></b> : <%# Eval("Title") %> 
                        <br />
                        <b>ISBN: </b><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "~/10b.aspx/?ISBN=" + Eval("ISBN")%>'> <%#Eval("ISBN")%> </asp:HyperLink>
                        <br/>
                        <b>Hinta: </b><%# Eval("Price") %> <br />
                    </div>   
                </div>                 
            </ItemTemplate>
        </asp:Repeater>
        
    </div>
    </form>
</body>
</html>
