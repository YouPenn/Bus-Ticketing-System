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
    public partial class AdminAdd : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BusDB.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownAddBusID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void DropDownAddToCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void DropDownAddFromCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminHome.aspx");
        }

        protected void AddSave_Click(object sender, EventArgs e)
        {
            string scheduleID = txtAddScheduleID.Text;
            string busID = ddlAddBusID.Text;
            string formCity = ddlAddFromCity.Text;
            string toCity = ddlAddToCity.Text;
            string time = txtAddTime.Text;
            string date = txtAddDate.Text;
            string price = txtAddPrice.Text;


            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into schedule values(@ScheduleID,@BusID,@StartCityName,@EndCityName,@Time,@Date,@Price)";
            cmd.Parameters.AddWithValue("@ScheduleID", scheduleID);
            cmd.Parameters.AddWithValue("@BusID", busID);
            cmd.Parameters.AddWithValue("@StartCityName", formCity);
            cmd.Parameters.AddWithValue("@EndCityName", toCity);
            cmd.Parameters.AddWithValue("@Time", time);
            cmd.Parameters.AddWithValue("@Date", date);
            cmd.Parameters.AddWithValue("@Price", price);
            cmd.ExecuteNonQuery();

            con.Close();



            
            for (int i = 1; i < 21; i++)
            {

                SqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = System.Data.CommandType.Text;
                con.Open();
                cmd2.CommandText = "insert into seat values(@BusID,@ScheduleID,@AvailableSeat,@SeatNumber)";
                cmd2.Parameters.AddWithValue("@BusID", busID);
                cmd2.Parameters.AddWithValue("@ScheduleID", scheduleID);
                cmd2.Parameters.AddWithValue("@AvailableSeat", "available");
                cmd2.Parameters.AddWithValue("@SeatNumber", i);
                cmd2.ExecuteNonQuery();
                con.Close();
            }


            //ticket
            for (int i = 1; i < 21; i++)
            {

                SqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = System.Data.CommandType.Text;
                con.Open();
                cmd3.CommandText = "insert into ticket (SeatID, ScheduleID) values((SELECT SeatID FROM seat WHERE ScheduleID = @ScheduleID AND SeatNumber = @SeatNumber),@ScheduleID2)";
                cmd3.Parameters.AddWithValue("@SeatNumber", i);
                cmd3.Parameters.AddWithValue("@ScheduleID", scheduleID);
                cmd3.Parameters.AddWithValue("@ScheduleID2", scheduleID);
                cmd3.ExecuteNonQuery();
                con.Close();
            }

            Response.Redirect("AdminSchedule.aspx");
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

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void OnGV1Update(object sender, GridViewEditEventArgs e)
        {
            txtAddScheduleID.Text = "S000";
            txtAddDate.Text = DateTime.Today.ToString("yyyy-MM-dd");
            txtAddTime.Text = "00:00:00";
            txtAddPrice.Text = "00";

            AddSave.Enabled = false;
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            txtAddScheduleID.Text = "";
            txtAddDate.Text = "";
            txtAddTime.Text = "";
            txtAddPrice.Text = "";

            AddSave.Enabled = true;
        }

        protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {
            txtAddScheduleID.Text = "";
            txtAddDate.Text = "";
            txtAddTime.Text = "";
            txtAddPrice.Text = "";

            AddSave.Enabled = true;
        }
    }
}