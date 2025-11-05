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
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\UserDB.mdf;Integrated Security=True"); 
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [Obsolete]

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            string password = txtPassword.Text;
            string hashedPassword = HashPassword(password);

            if (chkUser_Password(txtEmail.Text, hashedPassword))
            {
                FormsAuthentication.RedirectFromLoginPage(txtEmail.Text, false);



                Response.Redirect("Homepage.aspx");
            }

            else
            {
                lblMessage.Text = "Invalid Email or Password";
            }
        }

        protected bool chkUser_Password(string mbemail, string passwd)
        {


            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from member where Email='" + mbemail + "' and Password= '" + passwd + "'";

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

        protected void btnBack_Click1(object sender, EventArgs e)
        {
            Response.Redirect("WhoRU.aspx");
        }

        protected void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtEmail_TextChanged1(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            Session["Email"] = email;
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