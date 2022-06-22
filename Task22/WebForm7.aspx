<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="Task22.WebForm7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="EmployeeId" DataSourceID="SqlDataSource1" OnRowDeleting="GridView1_RowDeleting">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" />
                <asp:BoundField DataField="EmployeeId" HeaderText="EmployeeId" InsertVisible="False" ReadOnly="True" SortExpression="EmployeeId" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="DeptId" HeaderText="DeptId" SortExpression="DeptId" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:Label ID="lblMessage" runat="server" Font-Bold="true"></asp:Label>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ivydevConnectionString %>" DeleteCommand="DELETE FROM [tblEmployee] WHERE [EmployeeId] = @EmployeeId" InsertCommand="INSERT INTO [tblEmployee] ([Name], [DeptId]) VALUES (@Name, @DeptId)" SelectCommand="SELECT * FROM [tblEmployee]" UpdateCommand="UPDATE [tblEmployee] SET [Name] = @Name, [DeptId] = @DeptId WHERE [EmployeeId] = @EmployeeId">
            <DeleteParameters>
                <asp:Parameter Name="EmployeeId" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="DeptId" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="DeptId" Type="Int32" />
                <asp:Parameter Name="EmployeeId" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
