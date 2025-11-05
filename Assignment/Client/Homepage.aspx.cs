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
    public partial class Homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if(Session["Email"] != null)
                {
                    txtUser.Text = Session["Email"].ToString();
                    Session["Email"] = txtUser.Text;
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }

                // Set the default value of the TextBox to the current date
                //CurrentDateTextBox.Text = DateTime.Now.ToShortDateString();

                //if(LoginName1 == null)
                //{
                //    Response.Redirect("Login.aspx");
                //}
            }
        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            // Store the selected date in a session variable
            //Session["SelectedDate"] = Calendar.SelectedDate;

            // Redirect to Ticket.aspx
            Response.Redirect("Ticket.aspx");
        }



        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Store selected values in session variables
            //Session["SelectedOrigin"] = HomepageOrigin.SelectedItem.Text;
            //Session["SelectedDestination"] = HomepageDestination.SelectedItem.Text;

            
        }

        protected void Calendar_SelectionChanged(object sender, EventArgs e)
        {
            //CurrentDateTextBox.Text = Calendar.SelectedDate.ToShortDateString();

        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Session["Email"] = null;
            txtUser.Text = null;
            Response.Redirect("Login.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //protected void CurrentDateTextBox_TextChanged(object sender, EventArgs e)
        //{

        //}

        protected void CurrentDateTextBox_TextChanged(object sender, EventArgs e)
        {
            DateTime selectedDate;
            if (DateTime.TryParse(CurrentDateTextBox.Text, out selectedDate))
            {
                if (selectedDate < DateTime.Now)
                {
                    cvDateValidation.IsValid = false;
                    CurrentDateTextBox.Text = string.Empty; // Clear the textbox if the date is invalid
                }
                else
                {
                    cvDateValidation.IsValid = true;
                }
            }
            else
            {
                cvDateValidation.IsValid = false;
                CurrentDateTextBox.Text = string.Empty; // Clear the textbox if the date is invalid
            }
        }

        protected void txtSelect_TextChanged(object sender, EventArgs e)
        {

        }



        protected void btnGoSelectSeat_Click(object sender, EventArgs e)
        {
            // Store ScheduleID in session
            string scheduleID = txtSelect.Text.Trim();
            Session["ScheduleID"] = scheduleID;

            Response.Redirect("Seat.aspx");
        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            txtSelect.Text = GridView1.SelectedRow.Cells[1].Text;
        }

        protected void Search_Click(object sender, EventArgs e)
        {

        }

        protected void cvDateValidation_ServerValidate(object source, ServerValidateEventArgs args)
        {

        }
    }
    
}