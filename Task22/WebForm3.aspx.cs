using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task22
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.AllCultures))
            {
                Response.Write(ci.Name + "=>" + ci.DisplayName + "<br/>");
            }
        }
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if (e.Row.Cells[3].Text == "US")
                {
                    int salary = Convert.ToInt32(e.Row.Cells[2].Text);
                    string formattedString = string.Format(new System.Globalization.CultureInfo("en-US"), "{0:c}", salary);
                    e.Row.Cells[2].Text = formattedString;
                }
                else if (e.Row.Cells[3].Text == "UK")
                {
                    int salary = Convert.ToInt32(e.Row.Cells[2].Text);
                    string formattedString = string.Format(new System.Globalization.CultureInfo("en-GB"), "{0:c}", salary);
                    e.Row.Cells[2].Text = formattedString;
                }
                else if (e.Row.Cells[3].Text == "India")
                {
                    int salary = Convert.ToInt32(e.Row.Cells[2].Text);
                    string formattedString = string.Format(new System.Globalization.CultureInfo("en-IN"), "{0:c}", salary);
                    e.Row.Cells[2].Text = formattedString;
                }
                else if (e.Row.Cells[3].Text == "South Africa")
                {
                    int salary = Convert.ToInt32(e.Row.Cells[2].Text);
                    string formattedString = string.Format(new System.Globalization.CultureInfo("en-ZA"), "{0:c}", salary);
                    e.Row.Cells[2].Text = formattedString;
                }
                else if (e.Row.Cells[3].Text == "Malaysia")
                {
                    int salary = Convert.ToInt32(e.Row.Cells[2].Text);
                    string formattedString = string.Format(new System.Globalization.CultureInfo("en-MY"), "{0:c}", salary);
                    e.Row.Cells[2].Text = formattedString;
                }
            }
        }
    }
}

