<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddArtist.aspx.cs" Inherits="AddArtist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
        <tr>
            <td>Artist Name</td>
            <td><asp:TextBox ID="ArtistNameTextBox" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="ArtistNameRequiredFieldValidator" runat="server" ErrorMessage="Artist name requiered" ControlToValidate="ArtistNameTextBox"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Email</td>
            <td>
            <asp:TextBox ID="ArtistEmailTextBox" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="ArtistEmailRequiredFieldValidator" runat="server" ErrorMessage="Email requiered" ControlToValidate="ArtistEmailTextBox"></asp:RequiredFieldValidator>
            </td>
        </tr>
          <tr>
            <td>Web Page</td>
            <td>
                <asp:TextBox ID="ArtistWebPageTextBox" runat="server"></asp:TextBox>
            </td>

        </tr>
 
        <tr>
            <td>
                <asp:Button ID="AddArtistSubmitButton" runat="server" Text="Add Artist" OnClick="SubmitButton_Click" />
            </td>
            <td>
                <asp:Label ID="ResultLabel" runat="server" Text=""></asp:Label>
            </td>
            <td></td>
            
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
