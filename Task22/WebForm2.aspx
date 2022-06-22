<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Task22.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="empid" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="empid" HeaderText="empid" ReadOnly="True" SortExpression="empid" />
                <asp:BoundField DataField="firstname" HeaderText="firstname" SortExpression="firstname" />
                <asp:BoundField DataField="lastname" HeaderText="lastname" SortExpression="lastname" />
                <asp:CheckBoxField DataField="namestyle" HeaderText="namestyle" SortExpression="namestyle" />
                <asp:BoundField DataField="persontype" HeaderText="persontype" SortExpression="persontype" />
                <asp:BoundField DataField="DOB" HeaderText="DOB" SortExpression="DOB" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ivydevConnectionString %>" SelectCommand="SELECT * FROM [employees]"></asp:SqlDataSource>
    </form>
</body>
</html>
