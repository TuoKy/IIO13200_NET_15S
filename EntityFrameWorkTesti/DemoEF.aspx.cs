using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DemoEF : System.Web.UI.Page
{
    ViiniEntities ctx; //tässä on kaikki db tiedot entiteetteinä ja entiteettikokoelmina   
    protected void Page_Load(object sender, EventArgs e)
    {
        //Ladataan vain kerran
        if (!IsPostBack)
        {
            Fillcontrols();
        }        
    }

    protected void buttonGetAllcustomers_Click(object sender, EventArgs e)
    {
        //Haetaan kaikki aasiakkaat LINQ-kyselyllä
        ctx = new ViiniEntities();
        var kysely = from c in ctx.customers select c;

        //Kyselyn tulos sidotaan datakontrolliin
        gvData.DataSource = kysely.ToList();
        gvData.DataBind();
        tulos.InnerHtml = "";
    }

    protected void Fillcontrols()
    {
        //Täytetään kontrollit ctx-tiedoilla
        ctx = new ViiniEntities();
        var kysely = (from c in ctx.customers
                      orderby c.City
                      select c.City)
                      .Distinct();
        ddlCities.DataSource = kysely.ToList();
        ddlCities.DataBind();
    }

    protected void buttongetAllCustomersFromCity_Click(object sender, EventArgs e)
    {
        //valitaan aasiakkaat valitusta kaupungista
        ctx = new ViiniEntities();
        var kysely = from c in ctx.customers
                     where c.City.Equals(ddlCities.SelectedValue.ToString())
                     select c;

        gvData.DataSource = kysely.ToList();
        gvData.DataBind();
        tulos.InnerHtml = "";
    }

    protected void buttonGetCustomerByCicy_Click(object sender, EventArgs e)
    {
        //Näytetään kunkin kaupungin asiakkaat, käytetään HTML:ää
        //tyhjätään datagrid
        gvData.DataSource = null;
        gvData.DataBind();
        //LINQ kyselyssä luodaan lennosta uusi entiteetti asiakkaan tiedoista
        ctx = new ViiniEntities();
        var kysely = from c in ctx.customers
                     orderby c.City
                     select new { Etunimi = c.Firstname, Sukunimi = c.Lastname, Kaupunki = c.City };
        string ryhma = "";
        foreach (var a in kysely)
        {
            if(ryhma == a.Kaupunki)
            {
                tulos.InnerHtml += a.Etunimi + " " + a.Sukunimi + "<br/>";
            }
            else
            {
                tulos.InnerHtml += "<h3>" + a.Kaupunki + "</h3>";
                tulos.InnerHtml += a.Etunimi + " " + a.Sukunimi + "<br/>";
                ryhma = a.Kaupunki;
            }

        }
    }
}