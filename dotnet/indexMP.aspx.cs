using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class indexMP : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Tutkitaan onko Sessionissa muutujaa user
        if(Session["user"] != null)
        {
            sessionTarkistus.Text = "Terve: " + Session["user"].ToString();
        }
    }
}