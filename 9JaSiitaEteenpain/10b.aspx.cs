using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _10b : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string ISBN = Request.QueryString["ISBN"];
            srcLevyt.XPath = "Records/genre/record[@ISBN='" + ISBN + "']";
            srcKappaleet.XPath = "Records/genre/record[@ISBN='" + ISBN + "']/song";
        }
        catch (Exception ex)
        {

            throw ex;
        }

    }
}