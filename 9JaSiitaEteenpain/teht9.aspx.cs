using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class teht9 : System.Web.UI.Page
{
    

    protected void Page_Load(object sender, EventArgs e)
    {
        //Ladataan jutut tietokannast
        getRealData();
    }
    protected void getDemonData()
    {
        //täytetään gridview jollain
        DataTable dt = teht9Koodi.GetDataSimple();
        gvCustomers.DataSource = dt;
        gvCustomers.DataBind();
    }

    protected void getRealData()
    {
        DataTable dt = teht9Koodi.GetDataReal();
        gvCustomers.DataSource = dt;
        gvCustomers.DataBind();
    }
}