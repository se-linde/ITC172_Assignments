using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data; //Data table and data set
using System.Data.SqlClient; //The tools for talking with sql server
using System.Configuration; // lets me read the config file - we put our connection data in the config file

/// <summary>
/// BookAuthors class
/// </summary>
public class BookAuthors
{
    SqlConnection connect;

    public BookAuthors()
    {
        connect = new SqlConnection(ConfigurationManager.ConnectionStrings["BookReviewDBConnectionString"].ToString());
    }
    public DataTable GetAuthors()
    {
        string sql = "SELECT AuthorKey, AuthorName FROM Author";
        SqlCommand cmd = new SqlCommand(sql, connect);
        DataTable tbl = null;

        try
        {
            tbl = ProcessQuery(cmd);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return tbl;
    }
    public DataTable GetBooks(int authorKey)
    {
        string sql = "SELECT * FROM book INNER JOIN authorbook ON book.bookkey = authorbook.bookkey WHERE authorkey = @authorkey"; //@ is an sql variable
        SqlCommand cmd = new SqlCommand(sql, connect);
        cmd.Parameters.AddWithValue("@AuthorKey", authorKey);
        DataTable tbl = null;

        try
        {
            tbl = ProcessQuery(cmd);
        }
        catch(Exception ex)
        {
            throw ex;
        }
        return tbl;
    }
    private DataTable ProcessQuery(SqlCommand cmd)
    {
        DataTable table = new DataTable();
        SqlDataReader reader;

        try
        {
            connect.Open(); //here is where error may occur
            reader = cmd.ExecuteReader(); //here is where error may occur
            table.Load(reader);
            connect.Close();
        }
        catch(Exception ex)
        {
            throw ex;
        }
        return table;
    }
}