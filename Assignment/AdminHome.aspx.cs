using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data.SqlClient;
using System.Data;

namespace Assignment
{
    public partial class AdminHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["AdminID"] != null && Session["AdminName"] != null)
                {
                    AdID.Text = Session["AdminID"].ToString(); // Set AdminID in textbox
                    AdName.Text = Session["AdminName"].ToString(); // Set AdminName in textbox
                }
                else
                {
                    Response.Redirect("AdminLogin.aspx");
                }
            }
        }

        protected void AdID_TextChanged(object sender, EventArgs e)
        {

        }

        protected void AdName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void imgbtnToAdminSchedule_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("AdminSchedule.aspx");
        }

        protected void imgbtnToAdminStart_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("AdminStart.aspx");
        }

        protected void imgbtnToAdminEnd_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("AdminDestination.aspx");
        }

        protected void imgbtnToAdminEditTicket_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("AdminEditTicket.aspx");
        }

        protected void imgbtnToAdminViewMember_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("AdminViewMember.aspx");
        }

        protected void imgbtnToAdminViewCustomer_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("AdminViewCustomer.aspx");
        }

        protected void imgbtnToAdminViewPayment_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("AdminViewPayment.aspx");
        }

        protected void imgbtnToAdminViewComment_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("AdminViewComment.aspx");
        }

        protected void imgbtnToAdminEditSeat_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("AdminEditSeat.aspx");
        }

        protected void imgbtnToAdminBus_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("AdminBus.aspx");
        }

        protected void imgbtnToAdminDriver_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("AdminDriver.aspx");
        }

        protected void imgbtnToLogout_Click(object sender, ImageClickEventArgs e)
        {
            FormsAuthentication.SignOut();
            Session["AdminID"] = null;
            Session["AdminName"] = null;
            AdID.Text = null;
            AdName.Text = null;
            Response.Redirect("AdminLogin.aspx");
        }
    }
}