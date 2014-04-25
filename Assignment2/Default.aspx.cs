using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            People p = new People();
            p.FirstName = txtFirstName.Text;
            p.LastName = txtLastName.Text;
            p.Email = txtEmail.Text;
            p.StreetAddress = txtAddress.Text;
            p.City = txtCity.Text;
            p.State = txtState.Text;
            p.PostalCode = txtPostalCode.Text;
            p.HomePhone = txtHomePhone.Text;
            p.Password = txtPassword.Text;

            Session["person"]=p;

            Response.Redirect("Default2.aspx");
            

        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
    }
}