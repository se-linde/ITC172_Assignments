<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>    
    <div id="main">

    <form id="form1" runat="server">
        Enter Your Name:
        <asp:TextBox ID="TextBox1" runat="server" Height="31px" OnTextChanged="TextBox1_TextChanged" Width="229px"></asp:TextBox>
        <br />
        <br />
        And then sellect your birthday on the calendar below:<br />
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    
        <p>
            Click this&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />    
    &nbsp;and I will tell you how many more days until your birthday.</p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="" ForeColor="Lime"></asp:Label></p>
    </form>


    </div>
</body>
</html>
