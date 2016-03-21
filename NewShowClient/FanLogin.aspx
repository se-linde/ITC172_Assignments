<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FanLogin.aspx.cs" Inherits="FanLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Fan Login Page</h1>
    <form id="form1" runat="server">
    <div>
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
                <asp:Button ID="FanLoginButton" runat="server" Text="Login" OnClick="LoginButton_Click" />
            </td>

             <td>
                 <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>
            </td>

        </tr>
        </table>
     <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/FanRegistration.aspx" Target="_blank">Sign Up New Fan</asp:HyperLink>

    
    </div>
    </form>
</body>
</html>
