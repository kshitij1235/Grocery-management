<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Manage.aspx.cs" Inherits="Library_simple.Manage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    

    <h1>Users : </h1>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="username" DataSourceID="SqlDataSource2">
            <Columns>
                <asp:BoundField DataField="username" HeaderText="username" ReadOnly="True" SortExpression="username"></asp:BoundField>
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name"></asp:BoundField>
                <asp:BoundField DataField="password" HeaderText="password" SortExpression="password"></asp:BoundField>
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString='<%$ ConnectionStrings:RegConnectionString %>' SelectCommand="SELECT * FROM [users]"></asp:SqlDataSource>
    </form>
</body>
</html>
