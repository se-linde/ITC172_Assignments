<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Steve Conger's Show Tracker Northwest</h1>

     <form id="formDefault" runat="server">
  <div id ="dropdowns">
      <h2>Artists, Venues, and Shows</h2>
        <asp:DropDownList ID="DropDownListArtist" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListArtist_SelectedIndexChanged"></asp:DropDownList>
        
        <asp:DropDownList ID="DropDownListVenue" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListVenue_SelectedIndexChanged"></asp:DropDownList>
        <asp:DropDownList ID="DropDownListShow" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListShow_SelectedIndexChanged"></asp:DropDownList>

        <asp:GridView ID="GridViewArtistandVennue" runat="server"></asp:GridView>


  </div>         
  <div id="venuelogin">
  <h2>Venue Login</h2>
      
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
     <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/VenueRegistration.aspx" Target="_blank">New Venue Registration</asp:HyperLink>
           
   </div>
    

    <div id="fanlogin">   
    <h2>Fan Login</h2>

   
            <table>
        <tr>
            <td>Fan UserName</td>
            <td>
                <asp:TextBox ID="FanUserNameTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>Password</td>
            <td>
                <asp:TextBox ID="FanPasswordTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Button ID="FanLoginButton" runat="server" Text="Login" OnClick="FanLoginButton_Click" />
            </td>

             <td>
                 <asp:Label ID="FanErrorLabel" runat="server" Text=""></asp:Label>
            </td>

        </tr>
        </table>
     <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/FanRegistration.aspx" Target="_blank">New Fan Registration</asp:HyperLink>

    
    </div>
    </form>
     

</body>
</html>
