<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Steve Conger's Show Tracker Northwest</h1>

    <!-- Venue Login -->
   <div id="venueShowTracker">
    <form id="form1" runat="server">
        <div>
        <table>
        <tr>
            <td>User Name</td>
            <td>
                <asp:TextBox ID="UserNameTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>Password</td>
            <td>
                <asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="LoginButton_Click" />
            </td>

             <td>
                 <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>
            </td>

        </tr>
        </table>
     <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/VenueRegistration.aspx" Target="_blank">Registration</asp:HyperLink>
            </div>
    </form>
    </div>


</body>
</html>
