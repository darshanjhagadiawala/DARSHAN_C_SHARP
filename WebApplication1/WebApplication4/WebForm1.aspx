<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 521px; top: 125px; position: absolute" Text="First Name" BorderStyle="None"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 520px; top: 171px; position: absolute" Text="Last Name"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 521px; top: 214px; position: absolute" Text="Location"></asp:Label>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 590px; top: 275px; position: absolute" Text="Insert" BorderStyle="Solid" />
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 624px; top: 123px; position: absolute" BorderStyle="Solid"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 624px; top: 169px; position: absolute" BorderStyle="Solid"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 624px; top: 212px; position: absolute" BorderStyle="Solid"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click1" style="z-index: 1; left: 674px; top: 275px; position: absolute" Text="Update" BorderStyle="Solid" />
        <asp:Button ID="Button3" runat="server" BorderStyle="Solid" OnClick="Button3_Click" style="z-index: 1; left: 773px; top: 275px; position: absolute" Text="Delete" />
    </form>
</body>
</html>
