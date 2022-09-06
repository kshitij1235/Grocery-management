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
    public partial class Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string JQueryVer = "1.7.1";
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
            {
                Path = "~/Scripts/jquery-" + JQueryVer + ".min.js",
                DebugPath = "~/Scripts/jquery-" + JQueryVer + ".js",
                CdnPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-" + JQueryVer + ".min.js",
                CdnDebugPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-" + JQueryVer + ".js",
                CdnSupportsSecureConnection = true,
                LoadSuccessExpression = "window.jQuery"
            });
            if (Session["new"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            try
            {
                textboxusernamename.Text = Session["new"].ToString();
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegConnectionString"].ConnectionString);
                conn.Open();
                String get_name = "select name from users Where username='" + Session["new"].ToString() + "'";

                String get_pass = "select password from users Where username='" + Session["new"].ToString() + "'";


                SqlCommand name_conn = new SqlCommand(get_name, conn);
                SqlCommand pass_conn = new SqlCommand(get_pass, conn);

                String name = name_conn.ExecuteScalar().ToString().Trim();

                String password = pass_conn.ExecuteScalar().ToString().Trim();


                textboxname.Text = name;
                textboxpassword.Text = password;
                conn.Close();

            }
            catch (Exception ex) { Response.Write("Error occur"); }

        }

        protected void Unnamed4_Click(object sender, EventArgs e)
        {
            String username, name, password;
            username = changeuser.Text;
            password = changepass.Text;
            name = changename.Text;
            Response.Write(username + name + password);
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegConnectionString"].ConnectionString);
            conn.Open();
            String updateuser = "UPDATE users SET username=@uname ,name=@name , password=@pass WHERE username = @sessionname";
            SqlCommand com = new SqlCommand(updateuser, conn);

            com.Parameters.AddWithValue("@uname", username);
            com.Parameters.AddWithValue("@name", name);
            com.Parameters.AddWithValue("@pass", password);
            com.Parameters.AddWithValue("@sessionname", Session["new"].ToString());
            Int32 rowsAffected = com.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                Response.Write("updated sucessfull !!");
                Session["new"] = username;

            }



            conn.Close();
        }
    }
}