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
    public partial class Payment : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BusDB.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (Session["SeatNumber"] != null)
                {
                    BtnPay.Enabled = true;
                    string user = Session["Email"].ToString();
                    Session["Email"] = user;

                    txtSeatNumber.Text = Session["SeatNumber"].ToString();
                    txtSeatID.Text = Session["SeatID"].ToString();
                    txtTicketID.Text = Session["TicketID"].ToString();
                    txtScheduleID.Text = Session["ScheduleID"].ToString();

                    string scheduleID = txtScheduleID.Text;
                    //string seatNumber = txtSeatNumber.Text;
                    //string seatID = txtSeatNumber.Text;
                    //string ticketID = txtTicketID.Text;

                    con.Open();

                    //Date  (Original)
                    //DataTable dataTable1 = new DataTable();
                    //SqlCommand cmd1 = con.CreateCommand();
                    //cmd1.CommandType = System.Data.CommandType.Text;

                    //cmd1.CommandText = "SELECT Date FROM schedule WHERE scheduleID = @ScheduleID";
                    //cmd1.Parameters.AddWithValue("@ScheduleID", scheduleID);

                    //SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                    //da1.Fill(dataTable1);

                    //foreach (DataRow date in dataTable1.Rows)
                    //{
                    //    txtDate.Text = date["Date"].ToString();
                    //    //seatID = seat["SeatID"].ToString();
                    //}



                    //Date  (i change the display format)
                    DataTable dataTable1 = new DataTable();
                    SqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = System.Data.CommandType.Text;

                    // Modify the SQL query to retrieve the date in 'yyyy/mm/dd' format
                    cmd1.CommandText = "SELECT CONVERT(VARCHAR, Date, 111) AS Date FROM schedule WHERE scheduleID = @ScheduleID";
                    cmd1.Parameters.AddWithValue("@ScheduleID", scheduleID);

                    SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                    da1.Fill(dataTable1);

                    foreach (DataRow date in dataTable1.Rows)
                    {
                        txtDate.Text = date["Date"].ToString();
                    }




                    //Time
                    DataTable dataTable2 = new DataTable();
                    SqlCommand cmd2 = con.CreateCommand();
                    cmd2.CommandType = System.Data.CommandType.Text;

                    cmd2.CommandText = "SELECT Time FROM schedule WHERE scheduleID = @ScheduleID";
                    cmd2.Parameters.AddWithValue("@ScheduleID", scheduleID);

                    SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                    da2.Fill(dataTable2);

                    foreach (DataRow time in dataTable2.Rows)
                    {
                        txtTime.Text = time["Time"].ToString();
                    }


                    //Origin
                    DataTable dataTable3 = new DataTable();
                    SqlCommand cmd3 = con.CreateCommand();
                    cmd3.CommandType = System.Data.CommandType.Text;

                    cmd3.CommandText = "SELECT StartCityName FROM schedule WHERE scheduleID = @ScheduleID";
                    cmd3.Parameters.AddWithValue("@ScheduleID", scheduleID);

                    SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                    da3.Fill(dataTable3);

                    foreach (DataRow start in dataTable3.Rows)
                    {
                        txtOrigin.Text = start["StartCityName"].ToString();
                    }


                    //Destination
                    DataTable dataTable4 = new DataTable();
                    SqlCommand cmd4 = con.CreateCommand();
                    cmd4.CommandType = System.Data.CommandType.Text;

                    cmd4.CommandText = "SELECT DestinationCityName FROM schedule WHERE scheduleID = @ScheduleID";
                    cmd4.Parameters.AddWithValue("@ScheduleID", scheduleID);

                    SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
                    da4.Fill(dataTable4);

                    foreach (DataRow destination in dataTable4.Rows)
                    {
                        txtDestination.Text = destination["DestinationCityName"].ToString();
                    }


                    //Bus
                    DataTable dataTable5 = new DataTable();
                    SqlCommand cmd5 = con.CreateCommand();
                    cmd5.CommandType = System.Data.CommandType.Text;

                    cmd5.CommandText = "SELECT BusID FROM schedule WHERE scheduleID = @ScheduleID";
                    cmd5.Parameters.AddWithValue("@ScheduleID", scheduleID);

                    SqlDataAdapter da5 = new SqlDataAdapter(cmd5);
                    da5.Fill(dataTable5);

                    foreach (DataRow bus in dataTable5.Rows)
                    {
                        txtBusID.Text = bus["BusID"].ToString();
                    }


                    //Price
                    DataTable dataTable6 = new DataTable();
                    SqlCommand cmd6 = con.CreateCommand();
                    cmd6.CommandType = System.Data.CommandType.Text;

                    cmd6.CommandText = "SELECT Price FROM schedule WHERE scheduleID = @ScheduleID";
                    cmd6.Parameters.AddWithValue("@ScheduleID", scheduleID);

                    SqlDataAdapter da6 = new SqlDataAdapter(cmd6);
                    da6.Fill(dataTable6);

                    foreach (DataRow price in dataTable6.Rows)
                    {
                        txtPrice.Text = price["Price"].ToString();
                    }

                    con.Close();

                }
                else
                {
                    Response.Redirect("Homepage.aspx");
                }
            }
        }

        protected void PayButton_Click(object sender, EventArgs e)
        {

            string customerName = txtCustomerName.Text;
            string customerPhoneNumber = txtContectNo.Text;
            string customerID = "";
            string ticketID = txtTicketID.Text;
            string paymentPrice = txtPrice.Text;
            string paymentMethod = ddlPaymentMethod.Text;
            string availableSeat = "unavailable";
            string seatID = txtSeatID.Text;


            //Update Database //customer
            con.Open();

            SqlCommand cmd7 = con.CreateCommand();
            cmd7.CommandType = System.Data.CommandType.Text;
            cmd7.CommandText = "insert into customer values(@CustomerName,@CustomerPhoneNumber)";
            cmd7.Parameters.AddWithValue("@CustomerName", customerName);
            cmd7.Parameters.AddWithValue("@CustomerPhoneNumber", customerPhoneNumber);
            cmd7.ExecuteNonQuery();


            DataTable dataTable8 = new DataTable();
            SqlCommand cmd8 = con.CreateCommand();
            cmd8.CommandType = System.Data.CommandType.Text;

            cmd8.CommandText = "SELECT CustomerID FROM customer WHERE customerName = @CustomerName AND customerPhoneNumber = @CustomerPhoneNumber";
            cmd8.Parameters.AddWithValue("@CustomerName", customerName);
            cmd8.Parameters.AddWithValue("@CustomerPhoneNumber", customerPhoneNumber);

            SqlDataAdapter da8 = new SqlDataAdapter(cmd8);
            da8.Fill(dataTable8);

            foreach (DataRow customer in dataTable8.Rows)
            {
                //lblCustomerID.Text = customer["CustomerID"].ToString();
                customerID = customer["CustomerID"].ToString();
            }


            //Update Database //payment

            SqlCommand cmd9 = con.CreateCommand();
            cmd9.CommandType = System.Data.CommandType.Text;
            cmd9.CommandText = "insert into payment (CustomerID,TicketID,PaymentPrice,PaymentMethod) values(@CustomerID,@TicketID,@PaymentPrice,@PaymentMethod)";
            cmd9.Parameters.AddWithValue("@CustomerID", customerID);
            cmd9.Parameters.AddWithValue("@TicketID", ticketID);
            cmd9.Parameters.AddWithValue("@PaymentPrice", paymentPrice);
            cmd9.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
            cmd9.ExecuteNonQuery();

            //Update Database //add cusID into ticket 

            SqlCommand cmd10 = con.CreateCommand();
            cmd10.CommandType = System.Data.CommandType.Text;
            cmd10.CommandText = "UPDATE ticket SET customerID = @CustomerID WHERE ticketID = @TicketID";
            cmd10.Parameters.AddWithValue("@CustomerID", customerID);
            cmd10.Parameters.AddWithValue("@TicketID", ticketID);
            cmd10.ExecuteNonQuery();

            //Update Database //seat available -> unavailable

            SqlCommand cmd11 = con.CreateCommand();
            cmd11.CommandType = System.Data.CommandType.Text;
            cmd11.CommandText = "UPDATE seat SET availableSeat = @AvailableSeat WHERE seatID = @SeatID";
            cmd11.Parameters.AddWithValue("@SeatID", seatID);
            cmd11.Parameters.AddWithValue("@AvailableSeat", availableSeat);
            cmd11.ExecuteNonQuery();

            con.Close();

            //Store in session

            customerName = txtCustomerName.Text.Trim();
            customerPhoneNumber = txtContectNo.Text.Trim();
            //string customerName = txtCustomerName.Text.Trim();
            //string customerPhoneNumber = txtContectNo.Text.Trim();
            string date = txtDate.Text.Trim();
            string time = txtTime.Text.Trim();
            string start = txtOrigin.Text.Trim();
            string destination = txtDestination.Text.Trim();
            ticketID = txtTicketID.Text.Trim();
            string busID = txtBusID.Text.Trim();
            string seatNumber = txtSeatNumber.Text.Trim();
            string price = txtPrice.Text.Trim();

            Session["CustomerName"] = customerName;
            Session["CustomerPhoneNumber"] = customerPhoneNumber;
            Session["Date"] = date;
            Session["Time"] = time;
            Session["Start"] = start;
            Session["Destination"] = destination;
            Session["TicketID"] = ticketID;
            Session["BusID"] = busID;
            Session["SeatNumber"] = seatNumber;
            Session["Price"] = price;


            BtnPay.Enabled = false;
            Response.Redirect("PaymentSuccessful.aspx");

        }

        protected void DropDownPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = ddlPaymentMethod.SelectedValue;

            pnlOnlineBanking.Style["display"] = (selectedValue == "Online Banking") ? "block" : "none";
            pnlCreditCard.Style["display"] = (selectedValue == "Credit/Debit Card") ? "block" : "none";
        }



        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            //// Manually validate the customer name
            //string customerName = txtCustomerName.Text;

            //if (!System.Text.RegularExpressions.Regex.IsMatch(customerName, "^[a-zA-Z]+$"))
            //{
            //    rfvCustomerName.Visible = true; // Show the validator error message
            //}
            //else
            //{
            //    rfvCustomerName.Visible = false; // Hide the validator error message
            //}
        }

        protected void txtContectNo_TextChanged(object sender, EventArgs e)
        {
            //// Manually validate the contact number format
            //string contactNumber = txtContectNo.Text;
            //string pattern = @"^\d{3}-\d{7}|\d{3}-\d{8}$";

            //if (!System.Text.RegularExpressions.Regex.IsMatch(contactNumber, pattern))
            //{
            //    revContectNo.Visible = true; // Show the validator error message
            //}
            //else
            //{
            //    revContectNo.Visible = false; // Hide the validator error message
            //}
        }
    }
}






