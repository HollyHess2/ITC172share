using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            NewContributor ncont = new NewContributor();

            ncont.firstName = txtFirstName.Text;
            ncont.lastName = txtLastName.Text;
            ncont.email = txtEmail.Text;
            ncont.streetAddress = txtAddress.Text;
            ncont.city = txtCity.Text;
            ncont.state = txtState.Text;
            ncont.postalCode = txtPostalCode.Text;
            ncont.homePhone = txtHomePhone.Text;
            ncont.plainTextPassword = txtPassword.Text;

            Session["newCont"]=ncont;

            Response.Redirect("ConfirmRegisterInfo.aspx");

        }
        catch (Exception ex)
        {
            lblError.Text = "unable either to create session variable NewContributor or assign values to session variable" +
                ex.Message;

        }
    }

}