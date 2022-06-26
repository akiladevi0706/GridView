<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Task22.WebForm1" %>

<!DOCTYPE html>
<asp:objectdatasource runat="server" SelectMethod="GetAllProducts" TypeName="Task22.ProductDataAccessLayer"></asp:objectdatasource>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body>
    <form id="form1" runat="server">
        <asp:XmlDataSource  runat="server" ID="Souece" DataFile="~/Data/Countries.xml"></asp:XmlDataSource>
    <div>
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/Data/Countries.xml" TransformFile="~/Data/CountriesXSLT.xslt"></asp:XmlDataSource>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
    ConnectionString="<%$ ConnectionStrings:DBConnectionString %>" 
    SelectCommand="SELECT * FROM [Products]" ProviderName="System.Data.SqlClient">
</asp:SqlDataSource>
<br />
        

    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="Souece">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id"></asp:BoundField>
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name"></asp:BoundField>
                <asp:BoundField DataField="Continent" HeaderText="Continent" SortExpression="Continent"></asp:BoundField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
