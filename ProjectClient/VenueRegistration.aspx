<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VenueRegistration.aspx.cs" Inherits="VenueRegistration" %>

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
            <td>Venue Name</td>
            <td><asp:TextBox ID="VenueNameTextBox" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="VenueNameRequiredFieldValidator" runat="server" ErrorMessage="Venue name requiered" ControlToValidate="VenueNameTextBox"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Venue Address</td>
            <td>
                <asp:TextBox ID="VenueAddressTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="VenueAddressRequiredFieldValidator" runat="server" ErrorMessage="Venue address requiered" ControlToValidate="VenueAddressTextBox"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Venue City</td>
            <td>
                <asp:TextBox ID="VenueCityTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="VenueCityRequiredFieldValidator" runat="server" ErrorMessage="Venue city requiered" ControlToValidate="VenueCityTextBox"></asp:RequiredFieldValidator>
            </td>
        </tr>

         <tr>
            <td>Venue State</td>
            <td>
                <asp:TextBox ID="VenueStateTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="VenueStateRequiredFieldValidator" runat="server" ErrorMessage="Venue state requiered" ControlToValidate="VenueStateTextBox"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Venue Zip Code</td>
            <td>
                <asp:TextBox ID="VenueZipCodeTextBox" runat="server"></asp:TextBox>
            </td>

        </tr>

        <tr>
            <td>Venue Phone</td>
            <td>
                <asp:TextBox ID="VenuePhoneTextBox" runat="server"></asp:TextBox>
            </td>

        </tr>
        <tr>
            <td>Email</td>
            <td>
            <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="EmailRequiredFieldValidator" runat="server" ErrorMessage="Email requiered" ControlToValidate="EmailTextBox"></asp:RequiredFieldValidator>
            </td>
        </tr>
          <tr>
            <td>Venue Web Page</td>
            <td>
                <asp:TextBox ID="VenueWebPageTextBox" runat="server"></asp:TextBox>
            </td>

        </tr>

        <tr>
            <td>Venue Age Restriction</td>
            <td>
                <asp:TextBox ID="VenueAgeRestrictionTextBox" runat="server"></asp:TextBox>
            </td>

        </tr>
        <tr>
            <td>User Name</td>
            <td>
            <asp:TextBox ID="UserNameTextBox" runat="server"></asp:TextBox></td>
            <td></td>
        </tr>
        <tr>
            <td>Password</td>
            <td>
            <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="PasswordRequiredFieldValidator1" runat="server" ErrorMessage="Password requiered" ControlToValidate="PasswordTextBox"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Confirm Password</td>
            <td>
            <asp:TextBox ID="ConfirmTextBox" runat="server" TextMode="Password"></asp:TextBox></td>
            <td>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password dont match" ControlToValidate="ConfirmTextBox" ControlToCompare="PasswordTextBox"></asp:CompareValidator> 

            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
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
