using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ConfirmRegisterInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["newCont"]!=null){

            NewContributor ncont = (NewContributor)Session["newCont"];

            txtFirstName.Text = ncont.firstName;
            txtLastName.Text = ncont.lastName;
            txtEmail.Text = ncont.email;
            txtAddress.Text = ncont.streetAddress;
            txtCity.Text = ncont.city;
            txtState.Text = ncont.state;
            txtPostalCode.Text = ncont.state;
            txtHomePhone.Text = ncont.homePhone;
            

        }else{
            Response.Redirect("Register.aspx");
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //NewContributor ncont = new NewContributor();
        NewContributor ncont = (NewContributor)Session["newCont"];
        //ncont.lastname = txtLastName.Text;
        //ncont.firstname = txtFirstName.Text;
        //ncont.email = txtEmail.Text;
        //ncont.streetAddress = txtAddress.Text;
        //ncont.city = txtCity.Text;
        //ncont.state = txtState.Text;
        //ncont.homePhone = txtHomePhone.Text;
        //ncont.PlainPassword = txtPWordConfirm.Text;

        ManageContributor manageCont = new ManageContributor();
        //try{
        manageCont.WriteContributor(ncont);
        lblError.Text = "Thanks for registering";
        //}catch(Exception ex){
        //lblError.Text = ex.Message;
        //}

        //lblError.Text = "Thanks for registering";

        Response.Redirect("loginOrRegister.aspx");
    }
}