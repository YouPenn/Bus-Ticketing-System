using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data.SqlClient;
using System.Data;

namespace Assignment.Admin
{
    public partial class AdminDestination : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BusDB.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminHome.aspx");
        }

        protected void AddSave_Click(object sender, EventArgs e)
        {
            string destinationCityName = txtCityName.Text;
            string destinationBusStopName = txtBusStopName.Text;

            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into destination values(@DestinationCityName,@DestinationBusStopName)";
            cmd.Parameters.AddWithValue("@DestinationCityName", destinationCityName);
            cmd.Parameters.AddWithValue("@DestinationBusStopName", destinationBusStopName);

            cmd.ExecuteNonQuery();

            con.Close();

            Response.Redirect("AdminDestination.aspx");
        }

        protected void txtCityName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtBusStopName_TextChanged(object sender, EventArgs e)
        {

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

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            txtBusStopName.Text = "Bus Stop Name";
            txtCityName.Text = "City Name";
            AddSave.Enabled = false;

        }

        protected void GridView1_RowUpdating1(object sender, GridViewUpdateEventArgs e)
        {
            txtBusStopName.Text = "";
            txtCityName.Text = "";
            AddSave.Enabled = true;
        }

        protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {
            txtBusStopName.Text = "";
            txtCityName.Text = "";
            AddSave.Enabled = true;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}