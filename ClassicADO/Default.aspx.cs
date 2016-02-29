using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    BookAuthors ba = new BookAuthors();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillAuthorDropDown();
        }
    }
    protected void DDLAuthor_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillBookGridView();
    }
    protected void FillAuthorDropDown()
    {
        DataTable table = ba.GetAuthors();

        DDLAuthor.DataSource = table;
        DDLAuthor.DataTextField = "AuthorName";
        DDLAuthor.DataValueField = "AuthorKey";
        DDLAuthor.DataBind();
    }
    protected void FillBookGridView()
    {
        int key = int.Parse(DDLAuthor.SelectedValue.ToString());
        DataTable table = null;

        try
        {
            table = ba.GetBooks(key);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        GVBooks.DataSource = table;
        GVBooks.DataBind();
    }
}