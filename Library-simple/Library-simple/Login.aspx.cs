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
    public partial class WebForm1 : System.Web.UI.Page
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
     
            if (textboxusername.Text == "Admin"  & textboxpassword.Text=="123")
            {
                Response.Redirect("Manage.aspx");
            }


            try
            {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegConnectionString"].ConnectionString);
            conn.Open();
               
            String checkuser = "select count(*) from users Where username='" + textboxusername.Text +"'";
            SqlCommand com = new SqlCommand(checkuser, conn);
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            conn.Close();

            if (temp == 1){
                conn.Open();    
                String checkpass= "select password from users Where password='" + textboxpassword.Text +"'";
                SqlCommand pass_conn=new SqlCommand(checkpass, conn);
                String password= pass_conn.ExecuteScalar().ToString().Trim();  
                    if (password ==textboxpassword.Text)
                    {
                        Session["new"] = textboxusername.Text;
                        Response.Redirect("Homepage.aspx");
                    }
                    else { Response.Write("wrong password"); }


                }
                else { Response.Write("wrong username"); }


            }
            

            
            
            catch(Exception ex)
            {
                Response.Write("error while login");
            }
          
        }
    }
}