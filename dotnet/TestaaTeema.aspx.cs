using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TestaaTeema : System.Web.UI.Page
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        //Teeman dynaaminen vaihto tapahtuu tästä ja vain tästä
        switch (Request.QueryString["theme"])
        {
            case "SuperHappyFunTimes":
                Page.Theme = "SuperHappyFunTimes";
                break;
            case "VerySuperHappyFunTimes":
                Page.Theme = "VerySuperHappyFunTimes";
                break;
            default:
                break;
        }

    }

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
}