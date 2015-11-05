using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnLogin_Click(object sender, EventArgs e)
    {
        //Jos kreditit oikein niin kirjoitetaan
        if (Page.IsValid)
        {
            Session["user"] = TxtName;
            Server.Transfer("IndexMP.aspx");
            //Session["email"] = TxtEmail;
        }
    }
}