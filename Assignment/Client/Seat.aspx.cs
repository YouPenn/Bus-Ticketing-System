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
    public partial class Seat : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BusDB.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                if (Session["ScheduleID"] != null)
                {
                    string user = Session["Email"].ToString();
                    Session["Email"] = user;

                    txtScheduleID.Text = Session["ScheduleID"].ToString(); // Set AdminID in textbox
                    string scheduleID = Session["ScheduleID"].ToString();

                    DataTable dataTable = new DataTable();
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "SELECT SeatNumber, AvailableSeat FROM seat WHERE scheduleID = @ScheduleID";
                    cmd.Parameters.AddWithValue("@ScheduleID", scheduleID);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dataTable);
                    foreach (DataRow seat in dataTable.Rows)
                    {
                        //for (int i = 1; i< 21; i++)
                        if (seat["SeatNumber"].ToString() == "1")
                        {
                            if (seat["AvailableSeat"].ToString() == "unavailable" || seat["AvailableSeat"].ToString() == "maintaining")
                            {
                                SeatNumber1.Enabled = false;
                                SeatNumber1.ImageUrl = "~/image/Bus seat (Red).png";
                            }
                        }
                        if (seat["SeatNumber"].ToString() == "2")
                        {
                            if (seat["AvailableSeat"].ToString() == "unavailable" || seat["AvailableSeat"].ToString() == "maintaining")
                            {
                                SeatNumber2.Enabled = false;
                                SeatNumber2.ImageUrl = "~/image/Bus seat (Red).png";
                            }
                        }
                        if (seat["SeatNumber"].ToString() == "3")
                        {
                            if (seat["AvailableSeat"].ToString() == "unavailable" || seat["AvailableSeat"].ToString() == "maintaining")
                            {
                                SeatNumber3.Enabled = false;
                                SeatNumber3.ImageUrl = "~/image/Bus seat (Red).png";
                            }
                        }
                        if (seat["SeatNumber"].ToString() == "4")
                        {
                            if (seat["AvailableSeat"].ToString() == "unavailable" || seat["AvailableSeat"].ToString() == "maintaining")
                            {
                                SeatNumber4.Enabled = false;
                                SeatNumber4.ImageUrl = "~/image/Bus seat (Red).png";
                            }
                        }
                        if (seat["SeatNumber"].ToString() == "5")
                        {
                            if (seat["AvailableSeat"].ToString() == "unavailable" || seat["AvailableSeat"].ToString() == "maintaining")
                            {
                                SeatNumber5.Enabled = false;
                                SeatNumber5.ImageUrl = "~/image/Bus seat (Red).png";
                            }
                        }
                        if (seat["SeatNumber"].ToString() == "6")
                        {
                            if (seat["AvailableSeat"].ToString() == "unavailable" || seat["AvailableSeat"].ToString() == "maintaining")
                            {
                                SeatNumber6.Enabled = false;
                                SeatNumber6.ImageUrl = "~/image/Bus seat (Red).png";
                            }
                        }
                        if (seat["SeatNumber"].ToString() == "7")
                        {
                            if (seat["AvailableSeat"].ToString() == "unavailable" || seat["AvailableSeat"].ToString() == "maintaining")
                            {
                                SeatNumber7.Enabled = false;
                                SeatNumber7.ImageUrl = "~/image/Bus seat (Red).png";
                            }
                        }
                        if (seat["SeatNumber"].ToString() == "8")
                        {
                            if (seat["AvailableSeat"].ToString() == "unavailable" || seat["AvailableSeat"].ToString() == "maintaining")
                            {
                                SeatNumber8.Enabled = false;
                                SeatNumber8.ImageUrl = "~/image/Bus seat (Red).png";
                            }
                        }
                        if (seat["SeatNumber"].ToString() == "9")
                        {
                            if (seat["AvailableSeat"].ToString() == "unavailable" || seat["AvailableSeat"].ToString() == "maintaining")
                            {
                                SeatNumber9.Enabled = false;
                                SeatNumber9.ImageUrl = "~/image/Bus seat (Red).png";
                            }
                        }
                        if (seat["SeatNumber"].ToString() == "10")
                        {
                            if (seat["AvailableSeat"].ToString() == "unavailable" || seat["AvailableSeat"].ToString() == "maintaining")
                            {
                                SeatNumber10.Enabled = false;
                                SeatNumber10.ImageUrl = "~/image/Bus seat (Red).png";
                            }
                        }
                        if (seat["SeatNumber"].ToString() == "11")
                        {
                            if (seat["AvailableSeat"].ToString() == "unavailable" || seat["AvailableSeat"].ToString() == "maintaining")
                            {
                                SeatNumber11.Enabled = false;
                                SeatNumber11.ImageUrl = "~/image/Bus seat (Red).png";
                            }
                        }
                        if (seat["SeatNumber"].ToString() == "12")
                        {
                            if (seat["AvailableSeat"].ToString() == "unavailable" || seat["AvailableSeat"].ToString() == "maintaining")
                            {
                                SeatNumber12.Enabled = false;
                                SeatNumber12.ImageUrl = "~/image/Bus seat (Red).png";
                            }
                        }
                        if (seat["SeatNumber"].ToString() == "13")
                        {
                            if (seat["AvailableSeat"].ToString() == "unavailable" || seat["AvailableSeat"].ToString() == "maintaining")
                            {
                                SeatNumber13.Enabled = false;
                                SeatNumber13.ImageUrl = "~/image/Bus seat (Red).png";
                            }
                        }
                        if (seat["SeatNumber"].ToString() == "14")
                        {
                            if (seat["AvailableSeat"].ToString() == "unavailable" || seat["AvailableSeat"].ToString() == "maintaining")
                            {
                                SeatNumber14.Enabled = false;
                                SeatNumber14.ImageUrl = "~/image/Bus seat (Red).png";
                            }
                        }
                        if (seat["SeatNumber"].ToString() == "15")
                        {
                            if (seat["AvailableSeat"].ToString() == "unavailable" || seat["AvailableSeat"].ToString() == "maintaining")
                            {
                                SeatNumber15.Enabled = false;
                                SeatNumber15.ImageUrl = "~/image/Bus seat (Red).png";
                            }
                        }
                        if (seat["SeatNumber"].ToString() == "16")
                        {
                            if (seat["AvailableSeat"].ToString() == "unavailable" || seat["AvailableSeat"].ToString() == "maintaining")
                            {
                                SeatNumber16.Enabled = false;
                                SeatNumber16.ImageUrl = "~/image/Bus seat (Red).png";
                            }
                        }
                        if (seat["SeatNumber"].ToString() == "17")
                        {
                            if (seat["AvailableSeat"].ToString() == "unavailable" || seat["AvailableSeat"].ToString() == "maintaining")
                            {
                                SeatNumber17.Enabled = false;
                                SeatNumber17.ImageUrl = "~/image/Bus seat (Red).png";
                            }
                        }
                        if (seat["SeatNumber"].ToString() == "18")
                        {
                            if (seat["AvailableSeat"].ToString() == "unavailable" || seat["AvailableSeat"].ToString() == "maintaining")
                            {
                                SeatNumber18.Enabled = false;
                                SeatNumber18.ImageUrl = "~/image/Bus seat (Red).png";
                            }
                        }
                        if (seat["SeatNumber"].ToString() == "19")
                        {
                            if (seat["AvailableSeat"].ToString() == "unavailable" || seat["AvailableSeat"].ToString() == "maintaining")
                            {
                                SeatNumber19.Enabled = false;
                                SeatNumber19.ImageUrl = "~/image/Bus seat (Red).png";
                            }
                        }
                        if (seat["SeatNumber"].ToString() == "20")
                        {
                            if (seat["AvailableSeat"].ToString() == "unavailable" || seat["AvailableSeat"].ToString() == "maintaining")
                            {
                                SeatNumber20.Enabled = false;
                                SeatNumber20.ImageUrl = "~/image/Bus seat (Red).png";
                            }
                        }
                    }

                }
                else
                {
                    Response.Redirect("Homepage.aspx");
                }
            }
        }




        protected void txtScheduleID_TextChanged(object sender, EventArgs e)
        {

        }

        protected void SeatNumber1_Click(object sender, ImageClickEventArgs e)
        {

            txtSeatNumber.Text = "1";

            SeatNumber1.ImageUrl = "~/image/Bus seat (Green).png";

            if (SeatNumber2.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber2.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber3.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber3.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber4.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber4.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber5.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber5.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber6.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber6.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber7.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber7.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber8.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber8.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber9.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber9.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber10.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber10.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber11.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber11.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber12.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber12.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber13.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber13.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber14.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber14.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber15.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber15.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber16.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber16.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber17.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber17.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber18.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber18.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber19.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber19.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber20.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber20.ImageUrl = "~/image/Bus seat (Black).png";
            }

            string scheduleID = txtScheduleID.Text;
            string seatNumber = txtSeatNumber.Text;
            string seatID = "";

            DataTable dataTable1 = new DataTable();
            con.Open();
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = System.Data.CommandType.Text;
            cmd1.CommandText = "SELECT SeatID FROM seat WHERE scheduleID = @ScheduleID AND seatNumber = @SeatNumber";
            cmd1.Parameters.AddWithValue("@ScheduleID", scheduleID);
            cmd1.Parameters.AddWithValue("@SeatNumber", seatNumber);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dataTable1);

            foreach (DataRow seat in dataTable1.Rows)
            {
                txtSeatID.Text = seat["SeatID"].ToString();
                seatID = seat["SeatID"].ToString();
            }

            DataTable dataTable2 = new DataTable();

            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = System.Data.CommandType.Text;
            cmd2.CommandText = "SELECT TicketID FROM ticket WHERE seatID = @SeatID";
            cmd2.Parameters.AddWithValue("@SeatID", seatID);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dataTable2);

            foreach (DataRow ticket in dataTable2.Rows)
            {
                txtTicketID.Text = ticket["TicketID"].ToString();
            }

            con.Close();

            

        }

        protected void SeatNumber2_Click(object sender, ImageClickEventArgs e)
        {
            txtSeatNumber.Text = "2";


            SeatNumber2.ImageUrl = "~/image/Bus seat (Green).png";

            if (SeatNumber1.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber1.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber3.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber3.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber4.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber4.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber5.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber5.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber6.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber6.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber7.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber7.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber8.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber8.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber9.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber9.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber10.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber10.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber11.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber11.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber12.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber12.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber13.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber13.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber14.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber14.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber15.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber15.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber16.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber16.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber17.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber17.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber18.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber18.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber19.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber19.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber20.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber20.ImageUrl = "~/image/Bus seat (Black).png";
            }

            SeatNumber2.ImageUrl = "~/image/Bus seat (Green).png";

            string scheduleID = txtScheduleID.Text;
            string seatNumber = txtSeatNumber.Text;
            string seatID = "";

            DataTable dataTable = new DataTable();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT SeatID FROM seat WHERE scheduleID = @ScheduleID AND seatNumber = @SeatNumber";
            cmd.Parameters.AddWithValue("@ScheduleID", scheduleID);
            cmd.Parameters.AddWithValue("@SeatNumber", seatNumber);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dataTable);

            foreach (DataRow seat in dataTable.Rows)
            {
                txtSeatID.Text = seat["SeatID"].ToString();
                seatID = seat["SeatID"].ToString();
            }

            DataTable dataTable2 = new DataTable();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = System.Data.CommandType.Text;
            cmd2.CommandText = "SELECT TicketID FROM ticket WHERE seatID = @SeatID";
            cmd2.Parameters.AddWithValue("@SeatID", seatID);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dataTable2);

            foreach (DataRow ticket in dataTable2.Rows)
            {
                txtTicketID.Text = ticket["TicketID"].ToString();
            }



            con.Close();
        }

        protected void SeatNumber3_Click(object sender, ImageClickEventArgs e)
        {
            txtSeatNumber.Text = "3";


            SeatNumber3.ImageUrl = "~/image/Bus seat (Green).png";

            if (SeatNumber2.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber2.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber1.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber1.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber4.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber4.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber5.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber5.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber6.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber6.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber7.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber7.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber8.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber8.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber9.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber9.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber10.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber10.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber11.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber11.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber12.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber12.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber13.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber13.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber14.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber14.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber15.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber15.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber16.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber16.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber17.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber17.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber18.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber18.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber19.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber19.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber20.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber20.ImageUrl = "~/image/Bus seat (Black).png";
            }

            string scheduleID = txtScheduleID.Text;
            string seatNumber = txtSeatNumber.Text;
            string seatID = "";

            DataTable dataTable = new DataTable();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT SeatID FROM seat WHERE scheduleID = @ScheduleID AND seatNumber = @SeatNumber";
            cmd.Parameters.AddWithValue("@ScheduleID", scheduleID);
            cmd.Parameters.AddWithValue("@SeatNumber", seatNumber);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dataTable);

            foreach (DataRow seat in dataTable.Rows)
            {
                txtSeatID.Text = seat["SeatID"].ToString();
                seatID = seat["SeatID"].ToString();
            }

            DataTable dataTable2 = new DataTable();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = System.Data.CommandType.Text;
            cmd2.CommandText = "SELECT TicketID FROM ticket WHERE seatID = @SeatID";
            cmd2.Parameters.AddWithValue("@SeatID", seatID);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dataTable2);

            foreach (DataRow ticket in dataTable2.Rows)
            {
                txtTicketID.Text = ticket["TicketID"].ToString();
            }

            con.Close();
        }

        protected void SeatNumber4_Click(object sender, ImageClickEventArgs e)
        {
            txtSeatNumber.Text = "4";


            SeatNumber4.ImageUrl = "~/image/Bus seat (Green).png";

            if (SeatNumber2.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber2.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber3.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber3.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber1.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber1.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber5.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber5.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber6.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber6.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber7.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber7.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber8.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber8.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber9.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber9.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber10.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber10.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber11.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber11.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber12.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber12.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber13.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber13.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber14.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber14.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber15.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber15.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber16.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber16.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber17.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber17.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber18.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber18.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber19.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber19.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber20.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber20.ImageUrl = "~/image/Bus seat (Black).png";
            }

            string scheduleID = txtScheduleID.Text;
            string seatNumber = txtSeatNumber.Text;
            string seatID = "";

            DataTable dataTable = new DataTable();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT SeatID FROM seat WHERE scheduleID = @ScheduleID AND seatNumber = @SeatNumber";
            cmd.Parameters.AddWithValue("@ScheduleID", scheduleID);
            cmd.Parameters.AddWithValue("@SeatNumber", seatNumber);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dataTable);

            foreach (DataRow seat in dataTable.Rows)
            {
                txtSeatID.Text = seat["SeatID"].ToString();
                seatID = seat["SeatID"].ToString();
            }

            DataTable dataTable2 = new DataTable();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = System.Data.CommandType.Text;
            cmd2.CommandText = "SELECT TicketID FROM ticket WHERE seatID = @SeatID";
            cmd2.Parameters.AddWithValue("@SeatID", seatID);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dataTable2);

            foreach (DataRow ticket in dataTable2.Rows)
            {
                txtTicketID.Text = ticket["TicketID"].ToString();
            }

            con.Close();
        }

        protected void SeatNumber5_Click(object sender, ImageClickEventArgs e)
        {
            txtSeatNumber.Text = "5";


            SeatNumber5.ImageUrl = "~/image/Bus seat (Green).png";

            if (SeatNumber2.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber2.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber3.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber3.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber4.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber4.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber1.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber1.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber6.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber6.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber7.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber7.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber8.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber8.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber9.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber9.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber10.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber10.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber11.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber11.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber12.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber12.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber13.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber13.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber14.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber14.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber15.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber15.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber16.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber16.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber17.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber17.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber18.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber18.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber19.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber19.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber20.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber20.ImageUrl = "~/image/Bus seat (Black).png";
            }

            string scheduleID = txtScheduleID.Text;
            string seatNumber = txtSeatNumber.Text;
            string seatID = "";

            DataTable dataTable = new DataTable();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT SeatID FROM seat WHERE scheduleID = @ScheduleID AND seatNumber = @SeatNumber";
            cmd.Parameters.AddWithValue("@ScheduleID", scheduleID);
            cmd.Parameters.AddWithValue("@SeatNumber", seatNumber);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dataTable);

            foreach (DataRow seat in dataTable.Rows)
            {
                txtSeatID.Text = seat["SeatID"].ToString();
                seatID = seat["SeatID"].ToString();
            }

            DataTable dataTable2 = new DataTable();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = System.Data.CommandType.Text;
            cmd2.CommandText = "SELECT TicketID FROM ticket WHERE seatID = @SeatID";
            cmd2.Parameters.AddWithValue("@SeatID", seatID);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dataTable2);

            foreach (DataRow ticket in dataTable2.Rows)
            {
                txtTicketID.Text = ticket["TicketID"].ToString();
            }

            con.Close();
        }

        protected void SeatNumber6_Click(object sender, ImageClickEventArgs e)
        {
            txtSeatNumber.Text = "6";


            SeatNumber6.ImageUrl = "~/image/Bus seat (Green).png";

            if (SeatNumber2.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber2.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber3.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber3.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber4.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber4.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber5.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber5.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber1.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber1.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber7.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber7.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber8.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber8.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber9.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber9.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber10.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber10.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber11.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber11.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber12.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber12.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber13.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber13.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber14.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber14.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber15.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber15.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber16.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber16.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber17.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber17.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber18.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber18.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber19.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber19.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber20.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber20.ImageUrl = "~/image/Bus seat (Black).png";
            }

            string scheduleID = txtScheduleID.Text;
            string seatNumber = txtSeatNumber.Text;
            string seatID = "";

            DataTable dataTable = new DataTable();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT SeatID FROM seat WHERE scheduleID = @ScheduleID AND seatNumber = @SeatNumber";
            cmd.Parameters.AddWithValue("@ScheduleID", scheduleID);
            cmd.Parameters.AddWithValue("@SeatNumber", seatNumber);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dataTable);

            foreach (DataRow seat in dataTable.Rows)
            {
                txtSeatID.Text = seat["SeatID"].ToString();
                seatID = seat["SeatID"].ToString();
            }

            DataTable dataTable2 = new DataTable();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = System.Data.CommandType.Text;
            cmd2.CommandText = "SELECT TicketID FROM ticket WHERE seatID = @SeatID";
            cmd2.Parameters.AddWithValue("@SeatID", seatID);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dataTable2);

            foreach (DataRow ticket in dataTable2.Rows)
            {
                txtTicketID.Text = ticket["TicketID"].ToString();
            }

            con.Close();
        }

        protected void SeatNumber7_Click(object sender, ImageClickEventArgs e)
        {
            txtSeatNumber.Text = "7";


            SeatNumber7.ImageUrl = "~/image/Bus seat (Green).png";

            if (SeatNumber2.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber2.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber3.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber3.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber4.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber4.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber5.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber5.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber6.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber6.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber1.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber1.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber8.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber8.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber9.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber9.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber10.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber10.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber11.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber11.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber12.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber12.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber13.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber13.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber14.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber14.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber15.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber15.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber16.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber16.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber17.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber17.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber18.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber18.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber19.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber19.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber20.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber20.ImageUrl = "~/image/Bus seat (Black).png";
            }

            string scheduleID = txtScheduleID.Text;
            string seatNumber = txtSeatNumber.Text;
            string seatID = "";

            DataTable dataTable = new DataTable();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT SeatID FROM seat WHERE scheduleID = @ScheduleID AND seatNumber = @SeatNumber";
            cmd.Parameters.AddWithValue("@ScheduleID", scheduleID);
            cmd.Parameters.AddWithValue("@SeatNumber", seatNumber);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dataTable);

            foreach (DataRow seat in dataTable.Rows)
            {
                txtSeatID.Text = seat["SeatID"].ToString();
                seatID = seat["SeatID"].ToString();
            }

            DataTable dataTable2 = new DataTable();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = System.Data.CommandType.Text;
            cmd2.CommandText = "SELECT TicketID FROM ticket WHERE seatID = @SeatID";
            cmd2.Parameters.AddWithValue("@SeatID", seatID);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dataTable2);

            foreach (DataRow ticket in dataTable2.Rows)
            {
                txtTicketID.Text = ticket["TicketID"].ToString();
            }

            con.Close();
        }

        protected void SeatNumber8_Click(object sender, ImageClickEventArgs e)
        {
            txtSeatNumber.Text = "8";


            SeatNumber8.ImageUrl = "~/image/Bus seat (Green).png";

            if (SeatNumber2.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber2.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber3.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber3.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber4.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber4.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber5.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber5.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber6.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber6.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber7.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber7.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber1.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber1.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber9.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber9.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber10.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber10.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber11.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber11.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber12.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber12.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber13.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber13.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber14.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber14.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber15.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber15.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber16.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber16.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber17.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber17.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber18.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber18.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber19.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber19.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber20.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber20.ImageUrl = "~/image/Bus seat (Black).png";
            }

            string scheduleID = txtScheduleID.Text;
            string seatNumber = txtSeatNumber.Text;
            string seatID = "";

            DataTable dataTable = new DataTable();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT SeatID FROM seat WHERE scheduleID = @ScheduleID AND seatNumber = @SeatNumber";
            cmd.Parameters.AddWithValue("@ScheduleID", scheduleID);
            cmd.Parameters.AddWithValue("@SeatNumber", seatNumber);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dataTable);

            foreach (DataRow seat in dataTable.Rows)
            {
                txtSeatID.Text = seat["SeatID"].ToString();
                seatID = seat["SeatID"].ToString();
            }

            DataTable dataTable2 = new DataTable();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = System.Data.CommandType.Text;
            cmd2.CommandText = "SELECT TicketID FROM ticket WHERE seatID = @SeatID";
            cmd2.Parameters.AddWithValue("@SeatID", seatID);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dataTable2);

            foreach (DataRow ticket in dataTable2.Rows)
            {
                txtTicketID.Text = ticket["TicketID"].ToString();
            }

            con.Close();
        }

        protected void SeatNumber9_Click(object sender, ImageClickEventArgs e)
        {
            txtSeatNumber.Text = "9";


            SeatNumber9.ImageUrl = "~/image/Bus seat (Green).png";

            if (SeatNumber2.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber2.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber3.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber3.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber4.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber4.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber5.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber5.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber6.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber6.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber7.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber7.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber8.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber8.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber1.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber1.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber10.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber10.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber11.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber11.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber12.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber12.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber13.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber13.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber14.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber14.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber15.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber15.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber16.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber16.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber17.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber17.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber18.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber18.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber19.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber19.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber20.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber20.ImageUrl = "~/image/Bus seat (Black).png";
            }

            string scheduleID = txtScheduleID.Text;
            string seatNumber = txtSeatNumber.Text;
            string seatID = "";

            DataTable dataTable = new DataTable();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT SeatID FROM seat WHERE scheduleID = @ScheduleID AND seatNumber = @SeatNumber";
            cmd.Parameters.AddWithValue("@ScheduleID", scheduleID);
            cmd.Parameters.AddWithValue("@SeatNumber", seatNumber);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dataTable);

            foreach (DataRow seat in dataTable.Rows)
            {
                txtSeatID.Text = seat["SeatID"].ToString();
                seatID = seat["SeatID"].ToString();
            }

            DataTable dataTable2 = new DataTable();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = System.Data.CommandType.Text;
            cmd2.CommandText = "SELECT TicketID FROM ticket WHERE seatID = @SeatID";
            cmd2.Parameters.AddWithValue("@SeatID", seatID);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dataTable2);

            foreach (DataRow ticket in dataTable2.Rows)
            {
                txtTicketID.Text = ticket["TicketID"].ToString();
            }

            con.Close();
        }

        protected void SeatNumber10_Click(object sender, ImageClickEventArgs e)
        {
            txtSeatNumber.Text = "10";


            SeatNumber10.ImageUrl = "~/image/Bus seat (Green).png";

            if (SeatNumber2.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber2.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber3.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber3.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber4.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber4.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber5.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber5.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber6.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber6.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber7.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber7.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber8.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber8.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber9.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber9.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber1.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber1.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber11.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber11.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber12.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber12.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber13.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber13.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber14.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber14.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber15.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber15.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber16.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber16.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber17.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber17.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber18.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber18.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber19.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber19.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber20.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber20.ImageUrl = "~/image/Bus seat (Black).png";
            }

            string scheduleID = txtScheduleID.Text;
            string seatNumber = txtSeatNumber.Text;
            string seatID = "";

            DataTable dataTable = new DataTable();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT SeatID FROM seat WHERE scheduleID = @ScheduleID AND seatNumber = @SeatNumber";
            cmd.Parameters.AddWithValue("@ScheduleID", scheduleID);
            cmd.Parameters.AddWithValue("@SeatNumber", seatNumber);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dataTable);

            foreach (DataRow seat in dataTable.Rows)
            {
                txtSeatID.Text = seat["SeatID"].ToString();
                seatID = seat["SeatID"].ToString();
            }

            DataTable dataTable2 = new DataTable();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = System.Data.CommandType.Text;
            cmd2.CommandText = "SELECT TicketID FROM ticket WHERE seatID = @SeatID";
            cmd2.Parameters.AddWithValue("@SeatID", seatID);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dataTable2);

            foreach (DataRow ticket in dataTable2.Rows)
            {
                txtTicketID.Text = ticket["TicketID"].ToString();
            }

            con.Close();
        }

        protected void SeatNumber11_Click(object sender, ImageClickEventArgs e)
        {
            txtSeatNumber.Text = "11";

            SeatNumber11.ImageUrl = "~/image/Bus seat (Green).png";

            if (SeatNumber2.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber2.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber3.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber3.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber4.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber4.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber5.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber5.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber6.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber6.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber7.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber7.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber8.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber8.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber9.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber9.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber1.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber1.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber10.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber10.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber12.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber12.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber13.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber13.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber14.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber14.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber15.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber15.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber16.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber16.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber17.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber17.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber18.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber18.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber19.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber19.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber20.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber20.ImageUrl = "~/image/Bus seat (Black).png";
            }

            string scheduleID = txtScheduleID.Text;
            string seatNumber = txtSeatNumber.Text;
            string seatID = "";

            DataTable dataTable = new DataTable();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT SeatID FROM seat WHERE scheduleID = @ScheduleID AND seatNumber = @SeatNumber";
            cmd.Parameters.AddWithValue("@ScheduleID", scheduleID);
            cmd.Parameters.AddWithValue("@SeatNumber", seatNumber);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dataTable);

            foreach (DataRow seat in dataTable.Rows)
            {
                txtSeatID.Text = seat["SeatID"].ToString();
                seatID = seat["SeatID"].ToString();
            }

            DataTable dataTable2 = new DataTable();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = System.Data.CommandType.Text;
            cmd2.CommandText = "SELECT TicketID FROM ticket WHERE seatID = @SeatID";
            cmd2.Parameters.AddWithValue("@SeatID", seatID);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dataTable2);

            foreach (DataRow ticket in dataTable2.Rows)
            {
                txtTicketID.Text = ticket["TicketID"].ToString();
            }

            con.Close();
        }

        protected void SeatNumber12_Click(object sender, ImageClickEventArgs e)
        {
            txtSeatNumber.Text = "12";

            SeatNumber12.ImageUrl = "~/image/Bus seat (Green).png";

            if (SeatNumber2.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber2.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber3.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber3.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber4.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber4.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber5.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber5.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber6.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber6.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber7.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber7.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber8.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber8.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber9.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber9.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber1.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber1.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber11.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber11.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber10.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber10.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber13.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber13.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber14.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber14.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber15.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber15.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber16.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber16.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber17.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber17.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber18.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber18.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber19.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber19.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber20.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber20.ImageUrl = "~/image/Bus seat (Black).png";
            }

            string scheduleID = txtScheduleID.Text;
            string seatNumber = txtSeatNumber.Text;
            string seatID = "";

            DataTable dataTable = new DataTable();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT SeatID FROM seat WHERE scheduleID = @ScheduleID AND seatNumber = @SeatNumber";
            cmd.Parameters.AddWithValue("@ScheduleID", scheduleID);
            cmd.Parameters.AddWithValue("@SeatNumber", seatNumber);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dataTable);

            foreach (DataRow seat in dataTable.Rows)
            {
                txtSeatID.Text = seat["SeatID"].ToString();
                seatID = seat["SeatID"].ToString();
            }

            DataTable dataTable2 = new DataTable();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = System.Data.CommandType.Text;
            cmd2.CommandText = "SELECT TicketID FROM ticket WHERE seatID = @SeatID";
            cmd2.Parameters.AddWithValue("@SeatID", seatID);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dataTable2);

            foreach (DataRow ticket in dataTable2.Rows)
            {
                txtTicketID.Text = ticket["TicketID"].ToString();
            }

            con.Close();
        }

        protected void SeatNumber13_Click(object sender, ImageClickEventArgs e)
        {
            txtSeatNumber.Text = "13";

            SeatNumber13.ImageUrl = "~/image/Bus seat (Green).png";

            if (SeatNumber2.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber2.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber3.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber3.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber4.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber4.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber5.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber5.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber6.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber6.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber7.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber7.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber8.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber8.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber9.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber9.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber1.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber1.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber11.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber11.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber12.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber12.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber10.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber10.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber14.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber14.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber15.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber15.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber16.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber16.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber17.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber17.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber18.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber18.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber19.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber19.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber20.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber20.ImageUrl = "~/image/Bus seat (Black).png";
            }

            string scheduleID = txtScheduleID.Text;
            string seatNumber = txtSeatNumber.Text;
            string seatID = "";

            DataTable dataTable = new DataTable();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT SeatID FROM seat WHERE scheduleID = @ScheduleID AND seatNumber = @SeatNumber";
            cmd.Parameters.AddWithValue("@ScheduleID", scheduleID);
            cmd.Parameters.AddWithValue("@SeatNumber", seatNumber);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dataTable);

            foreach (DataRow seat in dataTable.Rows)
            {
                txtSeatID.Text = seat["SeatID"].ToString();
                seatID = seat["SeatID"].ToString();
            }

            DataTable dataTable2 = new DataTable();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = System.Data.CommandType.Text;
            cmd2.CommandText = "SELECT TicketID FROM ticket WHERE seatID = @SeatID";
            cmd2.Parameters.AddWithValue("@SeatID", seatID);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dataTable2);

            foreach (DataRow ticket in dataTable2.Rows)
            {
                txtTicketID.Text = ticket["TicketID"].ToString();
            }

            con.Close();
        }

        protected void SeatNumber14_Click(object sender, ImageClickEventArgs e)
        {
            txtSeatNumber.Text = "14";

            SeatNumber14.ImageUrl = "~/image/Bus seat (Green).png";

            if (SeatNumber2.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber2.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber3.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber3.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber4.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber4.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber5.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber5.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber6.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber6.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber7.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber7.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber8.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber8.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber9.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber9.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber1.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber1.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber11.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber11.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber12.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber12.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber13.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber13.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber10.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber10.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber15.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber15.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber16.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber16.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber17.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber17.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber18.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber18.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber19.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber19.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber20.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber20.ImageUrl = "~/image/Bus seat (Black).png";
            }

            string scheduleID = txtScheduleID.Text;
            string seatNumber = txtSeatNumber.Text;
            string seatID = "";

            DataTable dataTable = new DataTable();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT SeatID FROM seat WHERE scheduleID = @ScheduleID AND seatNumber = @SeatNumber";
            cmd.Parameters.AddWithValue("@ScheduleID", scheduleID);
            cmd.Parameters.AddWithValue("@SeatNumber", seatNumber);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dataTable);

            foreach (DataRow seat in dataTable.Rows)
            {
                txtSeatID.Text = seat["SeatID"].ToString();
                seatID = seat["SeatID"].ToString();
            }

            DataTable dataTable2 = new DataTable();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = System.Data.CommandType.Text;
            cmd2.CommandText = "SELECT TicketID FROM ticket WHERE seatID = @SeatID";
            cmd2.Parameters.AddWithValue("@SeatID", seatID);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dataTable2);

            foreach (DataRow ticket in dataTable2.Rows)
            {
                txtTicketID.Text = ticket["TicketID"].ToString();
            }

            con.Close();
        }

        protected void SeatNumber15_Click(object sender, ImageClickEventArgs e)
        {
            txtSeatNumber.Text = "15";

            SeatNumber15.ImageUrl = "~/image/Bus seat (Green).png";

            if (SeatNumber2.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber2.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber3.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber3.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber4.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber4.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber5.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber5.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber6.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber6.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber7.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber7.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber8.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber8.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber9.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber9.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber1.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber1.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber11.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber11.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber12.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber12.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber13.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber13.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber14.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber14.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber10.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber10.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber16.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber16.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber17.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber17.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber18.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber18.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber19.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber19.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber20.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber20.ImageUrl = "~/image/Bus seat (Black).png";
            }

            string scheduleID = txtScheduleID.Text;
            string seatNumber = txtSeatNumber.Text;
            string seatID = "";

            DataTable dataTable = new DataTable();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT SeatID FROM seat WHERE scheduleID = @ScheduleID AND seatNumber = @SeatNumber";
            cmd.Parameters.AddWithValue("@ScheduleID", scheduleID);
            cmd.Parameters.AddWithValue("@SeatNumber", seatNumber);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dataTable);

            foreach (DataRow seat in dataTable.Rows)
            {
                txtSeatID.Text = seat["SeatID"].ToString();
                seatID = seat["SeatID"].ToString();
            }

            DataTable dataTable2 = new DataTable();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = System.Data.CommandType.Text;
            cmd2.CommandText = "SELECT TicketID FROM ticket WHERE seatID = @SeatID";
            cmd2.Parameters.AddWithValue("@SeatID", seatID);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dataTable2);

            foreach (DataRow ticket in dataTable2.Rows)
            {
                txtTicketID.Text = ticket["TicketID"].ToString();
            }

            con.Close();
        }

        protected void SeatNumber16_Click(object sender, ImageClickEventArgs e)
        {
            txtSeatNumber.Text = "16";

            SeatNumber16.ImageUrl = "~/image/Bus seat (Green).png";

            if (SeatNumber2.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber2.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber3.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber3.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber4.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber4.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber5.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber5.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber6.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber6.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber7.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber7.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber8.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber8.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber9.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber9.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber1.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber1.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber11.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber11.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber12.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber12.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber13.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber13.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber14.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber14.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber15.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber15.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber10.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber10.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber17.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber17.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber18.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber18.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber19.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber19.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber20.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber20.ImageUrl = "~/image/Bus seat (Black).png";
            }

            string scheduleID = txtScheduleID.Text;
            string seatNumber = txtSeatNumber.Text;
            string seatID = "";

            DataTable dataTable = new DataTable();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT SeatID FROM seat WHERE scheduleID = @ScheduleID AND seatNumber = @SeatNumber";
            cmd.Parameters.AddWithValue("@ScheduleID", scheduleID);
            cmd.Parameters.AddWithValue("@SeatNumber", seatNumber);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dataTable);

            foreach (DataRow seat in dataTable.Rows)
            {
                txtSeatID.Text = seat["SeatID"].ToString();
                seatID = seat["SeatID"].ToString();
            }

            DataTable dataTable2 = new DataTable();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = System.Data.CommandType.Text;
            cmd2.CommandText = "SELECT TicketID FROM ticket WHERE seatID = @SeatID";
            cmd2.Parameters.AddWithValue("@SeatID", seatID);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dataTable2);

            foreach (DataRow ticket in dataTable2.Rows)
            {
                txtTicketID.Text = ticket["TicketID"].ToString();
            }

            con.Close();
        }

        protected void SeatNumber17_Click(object sender, ImageClickEventArgs e)
        {
            txtSeatNumber.Text = "17";

            SeatNumber17.ImageUrl = "~/image/Bus seat (Green).png";

            if (SeatNumber2.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber2.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber3.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber3.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber4.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber4.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber5.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber5.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber6.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber6.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber7.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber7.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber8.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber8.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber9.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber9.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber1.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber1.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber11.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber11.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber12.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber12.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber13.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber13.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber14.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber14.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber15.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber15.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber16.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber16.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber10.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber10.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber18.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber18.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber19.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber19.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber20.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber20.ImageUrl = "~/image/Bus seat (Black).png";
            }

            string scheduleID = txtScheduleID.Text;
            string seatNumber = txtSeatNumber.Text;
            string seatID = "";

            DataTable dataTable = new DataTable();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT SeatID FROM seat WHERE scheduleID = @ScheduleID AND seatNumber = @SeatNumber";
            cmd.Parameters.AddWithValue("@ScheduleID", scheduleID);
            cmd.Parameters.AddWithValue("@SeatNumber", seatNumber);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dataTable);

            foreach (DataRow seat in dataTable.Rows)
            {
                txtSeatID.Text = seat["SeatID"].ToString();
                seatID = seat["SeatID"].ToString();
            }

            DataTable dataTable2 = new DataTable();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = System.Data.CommandType.Text;
            cmd2.CommandText = "SELECT TicketID FROM ticket WHERE seatID = @SeatID";
            cmd2.Parameters.AddWithValue("@SeatID", seatID);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dataTable2);

            foreach (DataRow ticket in dataTable2.Rows)
            {
                txtTicketID.Text = ticket["TicketID"].ToString();
            }

            con.Close();
        }

        protected void SeatNumber18_Click(object sender, ImageClickEventArgs e)
        {
            txtSeatNumber.Text = "18";

            SeatNumber18.ImageUrl = "~/image/Bus seat (Green).png";

            if (SeatNumber2.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber2.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber3.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber3.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber4.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber4.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber5.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber5.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber6.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber6.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber7.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber7.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber8.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber8.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber9.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber9.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber1.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber1.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber11.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber11.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber12.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber12.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber13.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber13.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber14.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber14.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber15.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber15.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber16.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber16.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber17.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber17.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber10.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber10.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber19.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber19.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber20.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber20.ImageUrl = "~/image/Bus seat (Black).png";
            }

            string scheduleID = txtScheduleID.Text;
            string seatNumber = txtSeatNumber.Text;
            string seatID = "";

            DataTable dataTable = new DataTable();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT SeatID FROM seat WHERE scheduleID = @ScheduleID AND seatNumber = @SeatNumber";
            cmd.Parameters.AddWithValue("@ScheduleID", scheduleID);
            cmd.Parameters.AddWithValue("@SeatNumber", seatNumber);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dataTable);

            foreach (DataRow seat in dataTable.Rows)
            {
                txtSeatID.Text = seat["SeatID"].ToString();
                seatID = seat["SeatID"].ToString();
            }

            DataTable dataTable2 = new DataTable();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = System.Data.CommandType.Text;
            cmd2.CommandText = "SELECT TicketID FROM ticket WHERE seatID = @SeatID";
            cmd2.Parameters.AddWithValue("@SeatID", seatID);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dataTable2);

            foreach (DataRow ticket in dataTable2.Rows)
            {
                txtTicketID.Text = ticket["TicketID"].ToString();
            }

            con.Close();
        }

        protected void SeatNumber19_Click(object sender, ImageClickEventArgs e)
        {
            txtSeatNumber.Text = "19";

            SeatNumber19.ImageUrl = "~/image/Bus seat (Green).png";

            if (SeatNumber2.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber2.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber3.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber3.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber4.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber4.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber5.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber5.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber6.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber6.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber7.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber7.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber8.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber8.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber9.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber9.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber1.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber1.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber11.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber11.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber12.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber12.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber13.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber13.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber14.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber14.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber15.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber15.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber16.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber16.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber17.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber17.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber18.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber18.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber10.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber10.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber20.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber20.ImageUrl = "~/image/Bus seat (Black).png";
            }

            string scheduleID = txtScheduleID.Text;
            string seatNumber = txtSeatNumber.Text;
            string seatID = "";

            DataTable dataTable = new DataTable();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT SeatID FROM seat WHERE scheduleID = @ScheduleID AND seatNumber = @SeatNumber";
            cmd.Parameters.AddWithValue("@ScheduleID", scheduleID);
            cmd.Parameters.AddWithValue("@SeatNumber", seatNumber);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dataTable);

            foreach (DataRow seat in dataTable.Rows)
            {
                txtSeatID.Text = seat["SeatID"].ToString();
                seatID = seat["SeatID"].ToString();
            }

            DataTable dataTable2 = new DataTable();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = System.Data.CommandType.Text;
            cmd2.CommandText = "SELECT TicketID FROM ticket WHERE seatID = @SeatID";
            cmd2.Parameters.AddWithValue("@SeatID", seatID);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dataTable2);

            foreach (DataRow ticket in dataTable2.Rows)
            {
                txtTicketID.Text = ticket["TicketID"].ToString();
            }

            con.Close();
        }

        protected void SeatNumber20_Click(object sender, ImageClickEventArgs e)
        {
            txtSeatNumber.Text = "20";

            SeatNumber20.ImageUrl = "~/image/Bus seat (Green).png";

            if (SeatNumber2.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber2.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber3.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber3.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber4.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber4.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber5.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber5.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber6.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber6.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber7.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber7.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber8.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber8.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber9.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber9.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber10.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber10.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber11.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber11.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber12.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber12.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber13.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber13.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber14.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber14.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber15.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber15.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber16.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber16.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber17.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber17.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber18.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber18.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber19.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber19.ImageUrl = "~/image/Bus seat (Black).png";
            }
            if (SeatNumber1.ImageUrl == "~/image/Bus seat (Green).png")
            {
                SeatNumber1.ImageUrl = "~/image/Bus seat (Black).png";
            }

            string scheduleID = txtScheduleID.Text;
            string seatNumber = txtSeatNumber.Text;
            string seatID = "";

            DataTable dataTable = new DataTable();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT SeatID FROM seat WHERE scheduleID = @ScheduleID AND seatNumber = @SeatNumber";
            cmd.Parameters.AddWithValue("@ScheduleID", scheduleID);
            cmd.Parameters.AddWithValue("@SeatNumber", seatNumber);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dataTable);

            foreach (DataRow seat in dataTable.Rows)
            {
                txtSeatID.Text = seat["SeatID"].ToString();
                seatID = seat["SeatID"].ToString();
            }

            DataTable dataTable2 = new DataTable();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = System.Data.CommandType.Text;
            cmd2.CommandText = "SELECT TicketID FROM ticket WHERE seatID = @SeatID";
            cmd2.Parameters.AddWithValue("@SeatID", seatID);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dataTable2);

            foreach (DataRow ticket in dataTable2.Rows)
            {
                txtTicketID.Text = ticket["TicketID"].ToString();
            }

            con.Close();
        }

        protected void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (txtSeatNumber.Text != null && txtSeatID.Text != null && txtTicketID.Text != null && txtScheduleID.Text != null)
            {
                string seatNumber = txtSeatNumber.Text.Trim();
                string seatID = txtSeatID.Text.Trim();
                string ticketID = txtTicketID.Text.Trim();
                string scheduleID = txtScheduleID.Text.Trim();

                Session["SeatNumber"] = seatNumber; // Store in session
                Session["SeatID"] = seatID; // Store in session
                Session["TicketID"] = ticketID; // Store in session
                Session["SectionID"] = scheduleID; // Store in session

                Response.Redirect("Payment.aspx");
            }
            else
            {

            }
        }

        protected void txtSeatNumber_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void txtSeatID_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Homepage.aspx");
        }
    }
}