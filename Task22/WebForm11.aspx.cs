using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task22
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {
            if (e.AffectedRows < 1)
            {
                e.KeepInEditMode = true;
                lblMessage.Text = "Row with EmployeeId = " + e.Keys[0].ToString() +
                    " is not update due to data conflict";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblMessage.Text = "Row with EmployeeId = " + e.Keys[0].ToString() +
                    " is successfully updated";
                lblMessage.ForeColor = System.Drawing.Color.Navy;
            }
        }

    }
}