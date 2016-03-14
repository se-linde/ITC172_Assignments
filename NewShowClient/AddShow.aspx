<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddShow.aspx.cs" Inherits="AddShow" %>

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
            <td>Show Name</td>
            <td><asp:TextBox ID="ShowNameTextBox" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="ShowNameRequiredFieldValidator" runat="server" ErrorMessage="Show name requiered" ControlToValidate="ShowNameTextBox"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Show Date</td>
            <td>
                <asp:TextBox ID="ShowDateTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="ShowDateRequiredFieldValidator" runat="server" ErrorMessage="Show Date requiered" ControlToValidate="ShowDateTextBox"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Show Time</td>
            <td>
                <asp:TextBox ID="ShowTimeTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="ShowTimeRequiredFieldValidator" runat="server" ErrorMessage="Show Time requiered" ControlToValidate="ShowTimeTextBox"></asp:RequiredFieldValidator>
            </td>
        </tr>

         <tr>
            <td>Show Ticket Info</td>
            <td>
                <asp:TextBox ID="ShowTicketInfoTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="ShowTicketInfoRequiredFieldValidator" runat="server" ErrorMessage="Show Ticket Info requiered" ControlToValidate="ShowTicketInfoTextBox"></asp:RequiredFieldValidator>
            </td>
        </tr>
                <tr>      
        <td>Venues</td>
        <td>
        <asp:DropDownList ID="DropDownListVenue" runat="server"></asp:DropDownList>
        </td>
        <td>
            <asp:HyperLink ID="HyperLink2" runat="server" Target="_blank" NavigateUrl="~/VenueRegistration.aspx">Add Venue</asp:HyperLink></td>
        </tr>
                <tr>
        <td>Artist</td>
        <td>
        <asp:DropDownList ID="DropDownListArtist" runat="server"></asp:DropDownList>
        </td>
        <td>
            <asp:HyperLink ID="HyperLink1" runat="server" target="_blank" NavigateUrl="~/AddArtist.aspx">Add Artist</asp:HyperLink></td>
        </tr> 
         <tr>
            <td>Show Artist Start Time</td>
            <td>
                <asp:TextBox ID="ShowDetailAritstStartTime" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Show Artist Start Time requiered" ControlToValidate="ShowDetailAritstStartTime"></asp:RequiredFieldValidator>
            </td>
        </tr>

         <tr>
            <td>Show Additional Info</td>
            <td>
                <asp:TextBox ID="ShowAdditionalDetail" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Show Additional Info requiered" ControlToValidate="ShowAdditionalDetail"></asp:RequiredFieldValidator>
            </td>
        </tr>


        <tr>
            <td>
                <asp:Button ID="AddShowSubmitButton" runat="server" Text="Add Show" OnClick="SubmitButton_Click" />
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
