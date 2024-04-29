<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="Button2" runat="server" BorderStyle="Double" style="z-index: 1; left: 614px; top: 320px; position: absolute" Text="Insert" OnClick="Button2_Click" />
        <asp:Button ID="Button3" runat="server" BorderStyle="Double" style="z-index: 1; left: 722px; top: 320px; position: absolute" Text="Delete" />
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 588px; top: 94px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 588px; top: 144px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 590px; top: 192px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 543px; top: 94px; position: absolute" Text="EID"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 590px; top: 244px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 512px; top: 150px; position: absolute; bottom: 395px" Text="ENAME"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 520px; top: 197px; position: absolute; bottom: 348px" Text="EMAIL"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 475px; top: 244px; position: absolute" Text="MOBILE NO."></asp:Label>
        <asp:Button ID="Button4" runat="server" BorderStyle="Double" style="z-index: 1; left: 506px; top: 320px; position: absolute" Text="Update" OnClick="Button4_Click" />
    </form>
</body>
</html>
