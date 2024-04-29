<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button2" runat="server" Text="Submit" BackColor="#66FF33" ForeColor="Black" OnClick="Visibility" style="z-index: 1; left: 10px; top: 97px; position: absolute" />
            <asp:Button ID="Button3" runat="server" style="z-index: 1; left: 705px; top: 337px; position: absolute" Text="Button For Table" OnClick="Visibility1" />
        </p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" DataKeyNames="c_id" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical" style="z-index: 1; left: 537px; top: 116px; position: absolute; height: 152px; width: 232px">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <Columns>
                <asp:BoundField DataField="c_id" HeaderText="c_id" ReadOnly="True" SortExpression="c_id" />
                <asp:BoundField DataField="c_name" HeaderText="c_name" SortExpression="c_name" />
                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                <asp:BoundField DataField="location" HeaderText="location" SortExpression="location" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:FullStacksConnectionString2 %>" ProviderName="<%$ ConnectionStrings:FullStacksConnectionString2.ProviderName %>" SelectCommand="SELECT * FROM [customer1]"></asp:SqlDataSource>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 197px; top: 319px; position: absolute; height: 30px" Text="My Name is Darshan Jhagadiawala."></asp:Label>
        
    </form>
</body>
</html>
