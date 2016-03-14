using ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddShow : System.Web.UI.Page
{
    ShowTrackerLoginServiceClient bd = new ShowTrackerLoginServiceClient();
    ServiceReference.ShowTrackerLoginServiceClient db = new ServiceReference.ShowTrackerLoginServiceClient();
    ServiceReference.NewShow ns = new ServiceReference.NewShow();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userkey"] != null)
        {
            if (!IsPostBack)
            {
                LoadDropDownArtist();
                LoadDropDownVenue();
            }
        }
        else
        {
            Response.Redirect("Default.aspx");
        }
    }
    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        
        ns.ShowName = ShowNameTextBox.Text;
        ns.ShowDate = ShowDateTextBox.Text;
        ns.ShowTime = ShowTimeTextBox.Text;
        ns.ShowTicketInfo = ShowTicketInfoTextBox.Text;
        ns.VenueKey = Session["userkey"].ToString();
        ns.AritstKey = "1";
        ns.ShowDetailArtistStartTime = ShowDetailAritstStartTime.Text;
        ns.ShowDetailAdditional = ShowAdditionalDetail.Text;
   
    

        int result = db.AddShow(ns);

        if (result != -1)
            ResultLabel.Text = "Succesfully Scheduled";
        else
            ResultLabel.Text = "Show Schedule Failed";

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
   

}