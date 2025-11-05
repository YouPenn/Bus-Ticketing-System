using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Text;


namespace Assignment
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\UserDB.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Client/WhoRU.aspx");
        }

        protected void AdLogin_Click(object sender, EventArgs e)
        {
            string adminPassword = InputPassword.Text.Trim();
            string hashedPassword = HashPassword(adminPassword);

            if (chkAd_Password(InputID.Text, hashedPassword))
            {
                FormsAuthentication.RedirectFromLoginPage(InputID.Text, false);
                

                string adminID = InputID.Text.Trim();
                
                string adminName = "";

                Session["AdminID"] = adminID; // Store AdminID in session

                con.Open();

               

                //AdminName
                DataTable dataTable1 = new DataTable();
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = System.Data.CommandType.Text;

                cmd1.CommandText = "SELECT AdminName FROM admin WHERE AdminID = @AdminID and AdminPassword = @AdminPassword";
                cmd1.Parameters.AddWithValue("@AdminID", adminID);
                cmd1.Parameters.AddWithValue("@AdminPassword", hashedPassword);

                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                da1.Fill(dataTable1);

                foreach (DataRow admin in dataTable1.Rows)
                {
                    adminName = admin["AdminName"].ToString();
                }

                Session["AdminName"] = adminName; // Store AdminName in session

                con.Close();

                Response.Redirect("AdminHome.aspx");
            }

            else
            {
                LoginStatus.Text = "Invalid Email or Password";
            }
        }

        protected bool chkAd_Password(string adID, string passwd)
        {
            con.Open();


            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from admin where AdminID='" + adID + "' and AdminPassword= '" + passwd + "'";

            int a = cmd.ExecuteNonQuery();

            con.Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            a = dt.Rows.Count;
            if (a > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    builder.Append(hashedBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

    }
}