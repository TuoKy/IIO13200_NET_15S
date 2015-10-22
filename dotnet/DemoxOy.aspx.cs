using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class DemoxOy : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Ladataan jutut tietokannast
        getRealData();
    }
    protected void getDemonData()
    {
        //täytetään gridview jollain
        DataTable dt = JAMK.IT.DBDemoxOy.GetDataSimple();
        gvCustomers.DataSource = dt;
        gvCustomers.DataBind();
    }

    protected void getRealData()
    {
        DataTable dt = JAMK.IT.DBDemoxOy.GetDataReal();
        gvCustomers.DataSource = dt;
        gvCustomers.DataBind();
    }
}