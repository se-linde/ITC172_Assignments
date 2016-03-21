using ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FanPage : System.Web.UI.Page
{

    ShowTrackerLoginServiceClient sc = new ShowTrackerLoginServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        //I hard coded the key in so I didn't have to do the login 
        //for this example
        Session["key"] = 2;
        if (!IsPostBack)
            PopulateArtists();
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        AddArtists();
    }

    protected void PopulateArtists()
    {
        //this method populates the CheckboxList
        //with artist names
        string[] artists = sc.GetArtist();
        CheckBoxList1.DataSource = artists;
        CheckBoxList1.DataBind();
    }

    protected void AddArtists()
    {
        //get the fan's key
        int key = (int)Session["key"];

        //loop through the checkboxList
        //to see what's checked
        foreach(ListItem i in CheckBoxList1.Items)
        {
            //if it is checked call the service method to add
            //it to the database
            if(i.Selected)
            {
                int x = sc.AddFanArtist(key, i.Text);
            }
        }
        Label1.Text = "Artist have been added";
        CheckBoxList1.Items.Clear();
    }

}