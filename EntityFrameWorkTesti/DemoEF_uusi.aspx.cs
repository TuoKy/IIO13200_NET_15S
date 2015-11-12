using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DemoEF_uusi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAddCustomer_Click(object sender, EventArgs e)
    {
        //luodaan uusi entiteetti kokoelmaan ja luodaan muutos kantaan
        //pöljän pojan tarkistus että kakissa kentissä on arvot
        try
        {
            if(txtCity.Text.Length * txtFirstName.Text.Length * txtAdress.Text.Length * txtLastName.Text.Length * txtZip.Text.Length > 0)
            {
                ViiniEntities ctx = new ViiniEntities();
                customer uusi = new customer();
                uusi.Firstname = txtFirstName.Text;
                uusi.Lastname = txtLastName.Text;
                uusi.Address = txtAdress.Text;
                uusi.City = txtCity.Text;
                uusi.ZIP = txtZip.Text;
                ctx.SaveChanges();
                lblMessages.Text = string.Format("Uusi asiakas {0} lisätty kantaan", uusi.Firstname + " " + uusi.Lastname);
            }
            else
            {
                lblMessages.Text = "Jokin kentistä on tyhjä";
            }
        }
        catch (Exception ex)
        {

           lblMessages.Text = ex.Message;
        }

    }
}