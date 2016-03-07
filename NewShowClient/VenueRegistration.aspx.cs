using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class VenueRegistration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        SubmitVenue();
    }

    protected void SubmitVenue()
    {
        LoginServiceReference1.ShowTrackerLoginServiceClient lsc = new LoginServiceReference1.ShowTrackerLoginServiceClient();

        LoginServiceReference1.VenueLite lLite = new LoginServiceReference1.VenueLite();

        lLite.VenueName = VenueNameTextBox.Text;
        lLite.VenueAddress = VenueAddressTextBox.Text;
        lLite.VenueCity = VenueCityTextBox.Text;
        lLite.VenueState = VenueStateTextBox.Text;
        lLite.VenueZipCode = VenueZipCodeTextBox.Text;
        lLite.VenuePhone = VenuePhoneTextBox.Text;
        lLite.VenueEmail = EmailTextBox.Text;
        lLite.VenueWebPage = VenueWebPageTextBox.Text;
        lLite.VenueAgeRestriction = int.Parse(VenueAgeRestrictionTextBox.Text);
        lLite.VenueLoginUserName = UserNameTextBox.Text;
        lLite.VenueLoginPasswordPlain = ConfirmTextBox.Text;


        int result = lsc.VenueRegistration(lLite);

        if (result != -1)
            ResultLabel.Text = "Succesfully registration";
        else
            ResultLabel.Text = "Registration Failed";

    }
}