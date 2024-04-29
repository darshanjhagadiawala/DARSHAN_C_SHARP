<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 484px; top: 106px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 391px; top: 106px; position: absolute" Text="First Name"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 484px; top: 150px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 394px; top: 149px; position: absolute" Text="Last Name"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 405px; top: 189px; position: absolute" Text="Location"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 483px; top: 186px; position: absolute"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" BorderStyle="Solid" OnClick="Button1_Click" style="z-index: 1; left: 534px; top: 233px; position: absolute" Text="Submit" />
    </form>
</body>
</html>
