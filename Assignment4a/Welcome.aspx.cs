using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Welcome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["person"] != null)
        {
            int personKey = (int)Session["person"];
            //NewContributor ncont = (NewContributor)Session["person"];

            //txtFirstName.Text = ncont.firstName;
        }
        else
        {

        }
    }
}