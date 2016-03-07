<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Place.aspx.cs" Inherits="Place" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <asp:Label ID="Label1" runat="server" Text="Welcome, You made it this far."></asp:Label>
    <form id="form1" runat="server">
    <div>
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/VenueRegistration.aspx">Add Venue</asp:HyperLink><br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AddShow.aspx">Add Show</asp:HyperLink><br />
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/AddArtist.aspx">Add Artist</asp:HyperLink><br />
    </div>
    </form>
</body>
</html>
