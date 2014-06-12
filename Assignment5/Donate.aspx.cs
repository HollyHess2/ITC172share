using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient; //allow comm with sql server
using System.Configuration;  //allow comm with web config file where the connection string is


public partial class Donate : System.Web.UI.Page
{
    int pk;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["personkey"] != null)
        {
            pk = (int)Session["personkey"];
        }
        else
        {
            lblError.Text = "there was an error";
        }
    }
    protected void btnDonateNow_Click(object sender, EventArgs e)
    {
        CommunityAssistEntities ent = new CommunityAssistEntities();

        Donation don = new Donation();
        don.PersonKey = pk;
        decimal dec = Convert.ToDecimal(txtDonateAmt.Text);
        don.DonationAmount = dec;
        don.DonationDate = DateTime.Now;

        ent.Donations.Add(don);

        //write to database
        ent.SaveChanges();

        //add transaction with rollbackoption and error reporting

        Response.Redirect("ThankYou.aspx?action=donating&amount="+ txtDonateAmt.Text);

    }
}