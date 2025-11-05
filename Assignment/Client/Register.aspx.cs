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


namespace Assignment.Registration
{
    public partial class register : System.Web.UI.Page
    {
        //string securityQuestion = "";

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\UserDB.mdf;Integrated Security=True"); 
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text.Trim();
            string hashedPassword = HashPassword(password);

            string securityAns = txtSecurityAns.Text.Trim();
            string hashedSecurityAns = HashPassword(securityAns);


            if (radioBtnPetName.Checked)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert into member values('"
                    + txtName.Text + "','"
                    + txtEmail.Text + "','"
                    + hashedPassword + "','"
                    + "Pet Name" + "','"
                    + hashedSecurityAns + "')";
                int a = cmd.ExecuteNonQuery();
                if (a == 0)
                    lblMessage.Text = "Registeration Fail!";
                else
                    Response.Redirect("Login.aspx");

                con.Close();
            }
            else if (radioBtnPrimarySchool.Checked)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert into member values('"
                    + txtName.Text + "','"
                    + txtEmail.Text + "','"
                    + hashedPassword + "','"
                    + "Primary School" + "','"
                    + hashedSecurityAns + "')";
                int a = cmd.ExecuteNonQuery();
                if (a == 0)
                    lblMessage.Text = "Registeration Fail!";
                else
                    Response.Redirect("Login.aspx");

                con.Close();
            }
            else if (radioBtnFavoriteMovie.Checked)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert into member values('"
                    + txtName.Text + "','"
                    + txtEmail.Text + "','"
                    + hashedPassword + "','"
                    + "Fevorite Movie" + "','"
                    + hashedSecurityAns + "')";
                int a = cmd.ExecuteNonQuery();
                if (a == 0)
                    lblMessage.Text = "Registeration Fail!";
                else
                    Response.Redirect("Login.aspx");

                con.Close();
            }
            else
            {
                lblMessage.Text = "Registeration Fail! Please select Security Questions";
            }


        }

        protected void radioBtnPetName_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radioBtnPetName.Checked)
            {
                //securityQuestion = "Pet Name";
                txtSecurityAns.Enabled = true;
            }
            
            
        }

        protected void radioBtnPrimarySchool_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnPrimarySchool.Checked)
            {
                //securityQuestion = "Primary School";
                txtSecurityAns.Enabled = true;
            }
        }

        protected void radioBtnFavoriteMovie_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnFavoriteMovie.Checked)
            {
                //securityQuestion = "Fevorite Movie";
                txtSecurityAns.Enabled = true;
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