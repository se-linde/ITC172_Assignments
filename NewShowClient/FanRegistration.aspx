<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FanRegistration.aspx.cs" Inherits="FanRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
        <h1>Add New Fan Registration Page</h1>
    <form id="form1" runat="server">
    <div>
        <table>
        <tr>
            <td>Fan Name</td>
            <td><asp:TextBox ID="FanNameTextBox" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="FanNameRequiredFieldValidator" runat="server" ErrorMessage="Fan name requiered" ControlToValidate="FanNameTextBox"></asp:RequiredFieldValidator>
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
            <td>Fan UserName</td>
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
                <asp:Button ID="FanRegistrationSubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
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
