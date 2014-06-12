using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient; //allow comm with sql server
using System.Configuration;  //allow comm with web config file where the connection string is

public partial class Apply : System.Web.UI.Page
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
    protected void btnApplyNow_Click(object sender, EventArgs e)
    {
        CommunityAssistEntities ent = new CommunityAssistEntities();

        ServiceGrant sgrant = new ServiceGrant();
        sgrant.PersonKey = pk;
        decimal dec = Convert.ToDecimal(txtGrantAmt.Text);
        sgrant.GrantAmount = dec;
        sgrant.GrantDate = DateTime.Now;
        int typekey = Convert.ToInt32(txtGrantTypeKey.Text);
        sgrant.ServiceKey = typekey;
        sgrant.GrantNeedExplanation = txtGrantNeedExplain.Text;

        ent.ServiceGrants.Add(sgrant);

        //write to database
        ent.SaveChanges();

        //add transaction with rollbackoption and error reporting

        Response.Redirect("ThankYou.aspx?action=applying&amount=" + txtGrantAmt.Text);
    }
}