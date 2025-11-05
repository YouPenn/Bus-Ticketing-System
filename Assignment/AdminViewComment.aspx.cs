using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment
{
    public partial class AdminViewComment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminHome.aspx");
        }

        protected void ddlNavigation1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddl = (DropDownList)sender;
            string selectedValue = ddl.SelectedValue;

            if (!string.IsNullOrEmpty(selectedValue))
            {
                Response.Redirect(selectedValue);
            }
        }

        protected void ddlNavigation2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddl = (DropDownList)sender;
            string selectedValue = ddl.SelectedValue;

            if (!string.IsNullOrEmpty(selectedValue))
            {
                Response.Redirect(selectedValue);
            }
        }

        protected void ddlNavigation3_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddl = (DropDownList)sender;
            string selectedValue = ddl.SelectedValue;

            if (!string.IsNullOrEmpty(selectedValue))
            {
                Response.Redirect(selectedValue);
            }
        }
    }
}