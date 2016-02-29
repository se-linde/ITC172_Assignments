<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ITC172 Assignment 3</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Select Service</h1>
        <p>From here on in the Assignments will use the ShowTracker database. We will also use ADO Data Entities rather than classic AD0.</p>
        <ol>
            <li>In this assignment we will create a new service that returns various data from the database. In particular it should list of all venues (just the names of the venues)</li>
            <li>A list of all artists (just the names)</li>
            <li>list of all shows (just the names)</li>
            <li>list of all shows for a particular venue (for this list the show name, show date,  show start time)</li>
            <li>list of all shows for a particular artist (Show name, show date, show time and venue Name)</li>
        </ol>
        <p>Additionally Create tests for each of the methods and test whether they succeed or fail.</p>
        <asp:CheckBoxList ID="cblShowTracker" runat="server"></asp:CheckBoxList>
        <asp:GridView ID="gvShows" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
