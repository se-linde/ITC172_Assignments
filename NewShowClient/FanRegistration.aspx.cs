using ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FanRegistration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        FanSubmit();
    }

    protected void FanSubmit()
    {
        ShowTrackerLoginServiceClient lsc = new ShowTrackerLoginServiceClient();

        FanLite fLite = new FanLite();

        fLite.FanName = FanNameTextBox.Text;
        fLite.FanEmail = EmailTextBox.Text;
        fLite.FanLoginUserName = UserNameTextBox.Text;
        fLite.FanLoginPasswordPlain = ConfirmTextBox.Text;


        int result = lsc.FanRegistration(fLite);

        if (result != -1)
            ResultLabel.Text = "Succesfully registration";
        else
            ResultLabel.Text = "Registration Failed";

    }
}