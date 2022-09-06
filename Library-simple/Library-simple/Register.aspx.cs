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
    public partial class Register : System.Web.UI.Page
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


        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegConnectionString"].ConnectionString);
            conn.Open();

            String checkuser = "select count(*) from users Where username='" + textboxusername.Text + "'";
            SqlCommand com = new SqlCommand(checkuser, conn);
            int temp=Convert.ToInt32(com.ExecuteScalar().ToString());
            if(temp == 1)
            {
                Response.Write("username already taken");
            }

            try
            {
    
                String insert = "Insert into users (username,name,password)values(@uname,@name,@password)";

                SqlCommand insert_com = new SqlCommand(insert, conn);

                insert_com.Parameters.AddWithValue("@uname",textboxusername.Text);
                insert_com.Parameters.AddWithValue("@name", textboxname.Text);
                insert_com.Parameters.AddWithValue("@password", textboxpassword.Text);
                insert_com.ExecuteNonQuery();
                Response.Redirect("Manager.aspx");
                
            }
            catch(Exception ex)
            {
                Response.Write("cannot save to database ");
            }

            conn.Close();

        }
    }
}