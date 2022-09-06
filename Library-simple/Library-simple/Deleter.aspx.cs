using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Library_simple
{
    public partial class Deleter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegConnectionString"].ConnectionString);
            conn.Open();
            String updateuser = "DELETE From users WHERE username = @sessionname";
            SqlCommand com = new SqlCommand(updateuser, conn);

            com.Parameters.AddWithValue("@sessionname", Session["new"].ToString());
            Int32 rowsAffected = com.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                Response.Write("updated sucessfull !!");
                Response.Redirect("Login.aspx");

            }
        }
    }
}