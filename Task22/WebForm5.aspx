<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="Task22.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAllDepartments" TypeName="Task22.DepartmentDataAccessLayer"></asp:ObjectDataSource>
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource1" DataTextField="DepartmentName" DataValueField="DepartmentId">
        </asp:DropDownList>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetEmployeesByDepartment" TypeName="Task22.EmployeeDataAccessLayer">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="departmentId" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2">
            <Columns>
                <asp:BoundField DataField="EmployeeId" HeaderText="EmployeeId" SortExpression="EmployeeId" />
                <asp:BoundField DataField="EmployeeName" HeaderText="EmployeeName" SortExpression="EmployeeName" />
                <asp:BoundField DataField="DepartmentName" HeaderText="DepartmentName" SortExpression="DepartmentName" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
