using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["person"]!=null)
        {
            People p = (People)Session["person"];

            txtLastName.Text = p.LastName;
            txtFirstName.Text = p.FirstName;
            txtEmail.Text = p.Email;
            txtAddress.Text = p.StreetAddress;
            txtCity.Text = p.City;
            txtState.Text = p.State;
            txtPostalCode.Text = p.PostalCode;
            txtHomePhone.Text = p.HomePhone;

        }
        else
        {
            Response.Redirect("Default.aspx");
        }
    }

    protected void btnSumbit_Click(object sender, EventArgs e)
    {
        string last = txtLastName.Text;
        string first = txtFirstName.Text;
        Response.Redirect("Default3.aspx?name=" + first +" "+ last);
    }

}