<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Book Review</h1>
        <hr />
        <p>Select an author from the drop down list to see the book he or she has written.</p>
        <asp:DropDownList ID="DDLAuthor" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DDLAuthor_SelectedIndexChanged"></asp:DropDownList>
        <asp:GridView ID="GVBooks" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
