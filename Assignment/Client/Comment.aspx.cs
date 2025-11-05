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
    public partial class Comment : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BusDB.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Clear any previous client scripts to avoid duplication
                ScriptManager.RegisterStartupScript(this, GetType(), "resetAlert", "ClearAlert();", true);
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            

            string comment = txtComment.Text;

            if(txtComment.Text != null)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert into comment values(@Comment)";
                cmd.Parameters.AddWithValue("@Comment", comment);
                cmd.ExecuteNonQuery();

                con.Close();

                Response.Redirect("Comment.aspx");
            }

            

            
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Homepage.aspx");
        }
    }

    
    
}