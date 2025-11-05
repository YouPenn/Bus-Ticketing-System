using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Net.Mail;

namespace Assignment.Client
{
    public partial class PaymentSuccessful : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BusDB.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["CustomerName"] != null)
            {
                string user = Session["Email"].ToString();     
                Session["Email"] = user;

                string customerName = Session["CustomerName"].ToString();
                string customerPhoneNumber = Session["CustomerPhoneNumber"].ToString();
                string date = Session["Date"].ToString();
                string time = Session["Time"].ToString();
                string start = Session["Start"].ToString();
                string destination = Session["Destination"].ToString();
                string ticketID = Session["TicketID"].ToString();
                string busID = Session["BusID"].ToString();
                string seatNumber = Session["SeatNumber"].ToString();
                string price = Session["Price"].ToString();

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

                sendEmail();

            }
            else
            {
                Response.Redirect("Homepage.aspx");
            }

        }

        private void sendEmail()
        {
            //GET RECEIVER'S DETAILS
            string customerName = Session["CustomerName"].ToString();
            string customerPhoneNumber = Session["CustomerPhoneNumber"].ToString();

            string receiverEmail = Session["Email"].ToString();

            //GET EMAIL CONTENT
            string date = Session["Date"].ToString();
            string time = Session["Time"].ToString();
            string start = Session["Start"].ToString();
            string destination = Session["Destination"].ToString();
            string ticketID = Session["TicketID"].ToString();
            string busID = Session["BusID"].ToString();
            string seatNumber = Session["SeatNumber"].ToString();
            string price = Session["Price"].ToString();


            string emailContent = $@"
                                <h2>Your Ticket</h2>
                                <p><strong>Name:</strong> {customerName}</p>
                                <p><strong>Phone Number:</strong> {customerPhoneNumber}</p>
                                <p><strong>Date:</strong> {date}</p>
                                <p><strong>Time:</strong> {time}</p>
                                <p><strong>Origin:</strong> {start}</p>
                                <p><strong>Destination:</strong> {destination}</p>
                                <p><strong>Ticket ID:</strong> {ticketID}</p>
                                <p><strong>Bus ID:</strong> {busID}</p>
                                <p><strong>Seat Number:</strong> {seatNumber}</p>
                                <p><strong>Price:</strong> RM{price}</p>
                                ";

            try
            {
                // Create a MailMessage object
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("ourbus2003@gmail.com");
                mail.To.Add(receiverEmail);
                mail.Subject = "Booking Successfully";

                // HTML content of your email
                mail.Body = emailContent;
                mail.IsBodyHtml = true;

                // Create a SmtpClient to send the email
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential("ourbus2003@gmail.com", "nbcb anqx vzug lupd");
                smtpClient.EnableSsl = true;

                // Send the email
                smtpClient.Send(mail);
            }
            catch (Exception ex)
            {
                // Handle any exceptions, e.g., display an error message
                //Response.Write("Error: " + ex.Message);
                lblError.Text = "Payment success but send email fail :" +  ex.Message ;
            }

        }





        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("Complete.aspx");
        //}
    }
}