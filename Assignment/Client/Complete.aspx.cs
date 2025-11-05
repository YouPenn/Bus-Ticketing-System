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
    public partial class Complete : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BusDB.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(Session["CustomerName"] != null)
                {
                    con.Open();

                    txtCustomerName.Text = Session["CustomerName"].ToString();
                    txtContectNo.Text = Session["CustomerPhoneNumber"].ToString();
                    txtDate.Text = Session["Date"].ToString();
                    txtTime.Text = Session["Time"].ToString();
                    txtOrigin.Text = Session["Start"].ToString();
                    txtDestination.Text = Session["Destination"].ToString();
                    txtTicketID.Text = Session["TicketID"].ToString();
                    txtBusID.Text = Session["BusID"].ToString();
                    txtSeatNumber.Text = Session["SeatNumber"].ToString();
                    txtPrice.Text = Session["Price"].ToString();
                    CompleteDatePayment.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    string customerName = txtCustomerName.Text;
                    string customerPhoneNumber = txtContectNo.Text;
                    string customerID = "";

                    DataTable dataTable = new DataTable();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = System.Data.CommandType.Text;

                    cmd.CommandText = "SELECT CustomerID FROM customer WHERE customerName = @CustomerName AND customerPhoneNumber = @CustomerPhoneNumber";
                    cmd.Parameters.AddWithValue("@CustomerName", customerName);
                    cmd.Parameters.AddWithValue("@CustomerPhoneNumber", customerPhoneNumber);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dataTable);

                    foreach (DataRow customer in dataTable.Rows)
                    {
                        customerID = customer["CustomerID"].ToString();
                    }

                    DataTable dataTable1 = new DataTable();
                    SqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = System.Data.CommandType.Text;

                    cmd1.CommandText = "SELECT PaymentID FROM payment WHERE customerID = @CustomerID";
                    cmd1.Parameters.AddWithValue("@CustomerID", customerID);

                    SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                    da1.Fill(dataTable1);

                    foreach (DataRow payment in dataTable1.Rows)
                    {
                        txtPaymentID.Text = payment["PaymentID"].ToString();
                    }


                    string ticketID = Session["TicketID"].ToString();
                    string paymentDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    SqlCommand cmd10 = con.CreateCommand();
                    cmd10.CommandType = System.Data.CommandType.Text;
                    cmd10.CommandText = "UPDATE payment SET PaymentDateTime = @PaymentDateTime WHERE ticketID = @TicketID";
                    cmd10.Parameters.AddWithValue("@TicketID", ticketID);
                    cmd10.Parameters.AddWithValue("@PaymentDateTime", paymentDateTime);
                    cmd10.ExecuteNonQuery();

                    con.Close();
                }
                else
                {
                    Response.Redirect("Homepage.aspx");
                }
 
            }
        }

        protected void HomeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Homepage.aspx");
        }

        protected void CompleteDatePayment_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
