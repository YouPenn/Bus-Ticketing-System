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

namespace Assignment.Client
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\UserDB.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {





        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string securityAns = txtSecurityAnswer.Text;
            string hashedSecurityAns = HashSecurityAnswer(securityAns);

            if (chkMember_Security(txtEmail.Text, txtSecurityQuestions.Text, hashedSecurityAns))
            {
                FormsAuthentication.RedirectFromLoginPage(txtEmail.Text, false);

                Session["Email"] = txtEmail.Text;

                Response.Redirect("RecoverPassword.aspx");
            }

            else
            {
                lblMessage.Text = "Invalid Security Answer";
            }
        }

        protected bool chkMember_Security(string mbemail, string mbSecurityQues, string mbSecurityAns)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from member where Email='" + mbemail + "' and SecurityQuestion= '" + mbSecurityQues + "' and SecurityAnswer= '" + mbSecurityAns + "'";

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

        protected void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string securityQuestion = "";

            //Security Questions
            DataTable dataTable1 = new DataTable();
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = System.Data.CommandType.Text;

            cmd1.CommandText = "SELECT SecurityQuestion FROM member WHERE Email = @Email";
            cmd1.Parameters.AddWithValue("@Email", email);

            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dataTable1);

            foreach (DataRow member in dataTable1.Rows)
            {
                securityQuestion = member["SecurityQuestion"].ToString();
            }

            con.Close();

            txtSecurityQuestions.Text = securityQuestion;

            
        }

        private string HashSecurityAnswer(string securityAns)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(securityAns));
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