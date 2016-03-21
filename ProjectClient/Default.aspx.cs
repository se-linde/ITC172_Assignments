using ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    ShowTrackerLoginServiceClient db
   = new ShowTrackerLoginServiceClient();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadDropDownArtist();
            LoadDropDownVenue();
            LoadDropDownShow();
        }
    }

    protected void DropDownListShow_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillGridbyShow();
        DropDownListArtist.SelectedIndex = 0;
        DropDownListVenue.SelectedIndex = 0;

    }
 
    protected void DropDownListArtist_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillGridbyArtist();
        DropDownListVenue.SelectedIndex = 0;
        DropDownListShow.SelectedIndex = 0;

    }


    protected void DropDownListVenue_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillGridbyVenue();
        DropDownListArtist.SelectedIndex = 0;
        DropDownListShow.SelectedIndex = 0;

    }

    protected void LoadDropDownArtist()
    {
        string[] artists = db.GetArtists();
        DropDownListArtist.DataSource = artists;
        DropDownListArtist.DataBind();
        DropDownListArtist.Items.Add("Choose an Artist");
        DropDownListArtist.Items.Insert(0, "Choose an Artist");
    }



    protected void LoadDropDownVenue()
    {
        string[] venues = db.GetVenue();
        DropDownListVenue.DataSource = venues;
        DropDownListVenue.DataBind();
        DropDownListVenue.Items.Add("Choose a Venue");
        DropDownListVenue.Items.Insert(0, "Choose a Venue");
    }

    protected void LoadDropDownShow()
    {
        string[] shows = db.GetShow();
        DropDownListShow.DataSource = shows;
        DropDownListShow.DataBind();
        DropDownListShow.Items.Add("Choose a Show");
        DropDownListShow.Items.Insert(0, "Choose a Show");
    }


    protected void FillGridbyArtist()
    {
        string artist = DropDownListArtist.SelectedItem.Text;
        ServiceReference.ArtistShows[] shows = db.GetShowsByArtist(artist);
        GridViewArtistandVennue.DataSource = shows;
        GridViewArtistandVennue.DataBind();

    }

    protected void FillGridbyShow()
    {
        string show = DropDownListShow.SelectedItem.Text;
        ServiceReference.NewShow shows = db.GetShow;
        GridViewArtistandVennue.DataSource = shows;
        GridViewArtistandVennue.DataBind();


    }

    protected void FillGridbyVenue()
    {
        string venue = DropDownListVenue.SelectedItem.Text;
        ServiceReference.VenueShow[] shows = db.GetShowsByVenue(venue);
        GridViewArtistandVennue.DataSource = shows;
        GridViewArtistandVennue.DataBind();

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
    protected void FanLoginButton_Click(object sender, EventArgs e)
    {
        LoginFan();
    }

    protected void LoginFan()
    {
        ShowTrackerLoginServiceClient lsr =
            new ShowTrackerLoginServiceClient();
        int key = lsr.FanLogin(FanPasswordTextBox.Text, FanUserNameTextBox.Text);
        if (key != -1)
        {

            Session["userKey"] = key;
            Response.Redirect("FanPage.aspx");
        }
        else
        {
            FanErrorLabel.Text = "Login Failed";
        }
    }

}