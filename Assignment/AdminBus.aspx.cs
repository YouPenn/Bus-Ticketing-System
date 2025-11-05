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
    public partial class AdminBus : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BusDB.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminHome.aspx");
        }

        protected void btnEditDriver_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminDriver.aspx");
        }

        protected void AddSave_Click(object sender, EventArgs e)
        {
            string busID = txtBusID.Text;
            string driverID = ddlDriverID.Text;
            string busName = txtBusName.Text;
            string totalSeat = lblTotalSeat.Text;

            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into bus values(@BusID,@DriverID,@BusName,@TotalSeat)";
            cmd.Parameters.AddWithValue("@BusID", busID);
            cmd.Parameters.AddWithValue("@DriverID", driverID);
            cmd.Parameters.AddWithValue("@BusName", busName);
            cmd.Parameters.AddWithValue("@TotalSeat", totalSeat);

            cmd.ExecuteNonQuery();

            con.Close();
            Response.Redirect("AdminBus.aspx");
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

        protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            txtBusID.Text = "ABC1234";
            txtBusName.Text = "Bus Name";
            AddSave.Enabled = false;
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            txtBusID.Text = "";
            txtBusName.Text = "";
            AddSave.Enabled = true;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}