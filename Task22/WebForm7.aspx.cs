using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task22
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            lblMessage.Visible = true;
            // AffectedRows property will be zero, if no rows are deleted
            if (true)
            {
                lblMessage.Text = "Employee row with EmployeeID = \""
                    + e.Keys[0].ToString() + "\" is successfully deleted";
                lblMessage.ForeColor = System.Drawing.Color.Navy;
            }
            else
            {
                lblMessage.Text = "Employee Row with EmployeeID = \""
                    + e.Keys[0].ToString() + "\" is not deleted due to data conflict";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}