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

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DateTime thisDay = DateTime.Today;
       
        double days = 0;
        DateTime birthDay = Calendar1.SelectedDate;
        days = (birthDay - thisDay).TotalDays;
     
        Label1.Text = TextBox1.Text + ", Your next birthday is in " + Convert.ToString( days) + " days.";
    }
}