using ServiceReference;
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
    protected void LoginButton_Click(object sender, EventArgs e)
    {
        VenueLogin();
    }
    protected void VenueLogin()
    {
        ShowTrackerLoginServiceClient lsr =
            new ShowTrackerLoginServiceClient();
        int key = lsr.VenueLogin(PasswordTextBox.Text, UserNameTextBox.Text);
        if (key != -1)
        {
            
            Session["userKey"] = key;
            Response.Redirect("Place.aspx");
        }
        else
        {
            ErrorLabel.Text = "Login Failed";
        }
    }
}