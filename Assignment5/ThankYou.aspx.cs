using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ThankYou : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string action = Request.QueryString["action"];
        string amount = Request.QueryString["amount"];
        lblThankyou.Text = "Thank you for " + action + " !  The amount of " + amount + " will be reviewed and processed";

    }
}