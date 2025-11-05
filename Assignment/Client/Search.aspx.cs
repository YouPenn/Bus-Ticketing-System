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
    public partial class SearchHistory : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BusDB.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {

                string customerName = txtCustomerName.Text.Trim();
                string customerPhoneNumber = txtCustomerPhoneNumber.Text.Trim();
                string customerID = "";

                con.Open();

                //Ticket
                DataTable dataTable1 = new DataTable();
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = System.Data.CommandType.Text;

                cmd1.CommandText = "SELECT CustomerID FROM customer WHERE CustomerName = @CustomerName AND CustomerPhoneNumber = @CustomerPhoneNumber";
                cmd1.Parameters.AddWithValue("@CustomerName", customerName);
                cmd1.Parameters.AddWithValue("@CustomerPhoneNumber", customerPhoneNumber);

                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                da1.Fill(dataTable1);

                foreach (DataRow customer in dataTable1.Rows)
                {
                    customerID = customer["CustomerID"].ToString();
                }

                con.Close();

                txtCustomerID.Text = customerID;

            }

          
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                if (row.RowIndex == GridView1.SelectedIndex)
                {
                    row.CssClass = "selected-row";
                }
                else
                {
                    row.CssClass = "";
                }
            }

            txtSelection.Text = GridView1.SelectedRow.Cells[1].Text;
        }

        protected void btnSearch_Click2(object sender, EventArgs e)
        {
            Session["CustomerName"] = txtCustomerName.Text;
            Session["CustomerPhoneNumber"] = txtCustomerPhoneNumber.Text;
            Session["CustomerID"] = txtCustomerID.Text;
            Session["TicketID"] = txtSelection.Text;
            Response.Redirect("SearchResult.aspx");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Homepage.aspx");
        }
    }
}