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
    public partial class SearchResult : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BusDB.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["CustomerName"] == null)
                {
                    Response.Redirect("Search.aspx");
                }

                string customerName = Session["CustomerName"].ToString();
                string customerPhoneNumber = Session["CustomerPhoneNumber"].ToString();
                string ticketID = Session["TicketID"].ToString(); ;
                string seatID = "";
                string origin = "";
                string destination = "";
                string date = "";
                string time = "";
                string busID = "";
                string seatNumber = "";
                string paymentID = "";
                string paymentDateTime = "";
                string price = "";


                con.Open();

                //Ticket
                DataTable dataTable1 = new DataTable();
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = System.Data.CommandType.Text;

                cmd1.CommandText = "SELECT TicketID, SeatID FROM ticket WHERE TicketID = @TicketID";
                cmd1.Parameters.AddWithValue("@TicketID", ticketID);

                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                da1.Fill(dataTable1);

                foreach (DataRow ticket in dataTable1.Rows)
                {
                    //ticketID = ticket["TicketID"].ToString();
                    seatID = ticket["SeatID"].ToString();
                }

                //Payment
                DataTable dataTable2 = new DataTable();
                SqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = System.Data.CommandType.Text;

                cmd2.CommandText = "SELECT PaymentID, PaymentPrice, PaymentDateTime FROM payment WHERE TicketID = @TicketID";
                cmd2.Parameters.AddWithValue("@TicketID", ticketID);

                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                da2.Fill(dataTable2);

                foreach (DataRow payment in dataTable2.Rows)
                {
                    paymentID = payment["PaymentID"].ToString();
                    price = payment["PaymentPrice"].ToString();
                    paymentDateTime = payment["PaymentDateTime"].ToString();
                }

                //Schedule
                DataTable dataTable3 = new DataTable();
                SqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = System.Data.CommandType.Text;

                cmd3.CommandText = "SELECT ScheduleID, BusID, StartCityName, DestinationCityName, Time, Date FROM schedule WHERE ScheduleID = (SELECT scheduleID FROM ticket WHERE TicketID = @TicketID)";
                cmd3.Parameters.AddWithValue("@TicketID", ticketID);

                SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                da3.Fill(dataTable3);

                foreach (DataRow schedule in dataTable3.Rows)
                {
                    origin = schedule["StartCityName"].ToString();
                    destination = schedule["DestinationCityName"].ToString();
                    time = schedule["Time"].ToString();
                    date = schedule["Date"].ToString();
                    busID = schedule["BusID"].ToString();
                }

                //Seat
                DataTable dataTable4 = new DataTable();
                SqlCommand cmd4 = con.CreateCommand();
                cmd4.CommandType = System.Data.CommandType.Text;

                cmd4.CommandText = "SELECT SeatNumber FROM seat WHERE SeatID = @SeatID";
                cmd4.Parameters.AddWithValue("@SeatID", seatID);

                SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
                da4.Fill(dataTable4);

                foreach (DataRow seat1 in dataTable4.Rows)
                {
                    seatNumber = seat1["SeatNumber"].ToString();

                }

                con.Close();











                //if customerName and customerPhoneNo not exist print error message in lblMessage

                if (ticketID == "")
                {
                    lblMessage.Text = "No record or Expired";
                }
                else
                {
                    txtCustomerName.Text = customerName;
                    txtContectNo.Text = customerPhoneNumber;
                    txtTicketID.Text = ticketID;
                    //txtDate.Text = date;
                    DateTime parsedDate;
                    if (DateTime.TryParse(date, out parsedDate))
                    {
                        txtDate.Text = parsedDate.ToString("yyyy/MM/dd");
                    }
                    txtTime.Text = time;
                    txtOrigin.Text = origin;
                    txtDestination.Text = destination;
                    txtTicketID.Text = ticketID;
                    txtBusID.Text = busID;
                    txtSeatNumber.Text = seatNumber;
                    txtPaymentID.Text = paymentID;
                    txtPrice.Text = price;
                    txtPaymentDateTime.Text = paymentDateTime;
                }
                
            }
        }

        protected void btnPrint_Click(object sender, EventArgs e)
        {

        }

        protected void HomeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Homepage.aspx");
        }
    }
}