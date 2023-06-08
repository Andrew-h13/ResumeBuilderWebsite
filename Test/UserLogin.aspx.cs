using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Web.UI.HtmlControls;
using System.Configuration;

namespace Test
{
    public partial class UserLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
               if (Session["username"] != null)
               {
                    Response.Redirect("UserDashBoard.aspx", false);
               }
          }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
               string Username = txtUsername.Text;
               string Password = txtPassword.Text;
               string query = "SELECT * FROM Users WHERE username = @username AND password = @password";

               using (MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ConnectionString))
               {
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", Username);
                    command.Parameters.AddWithValue("@password", Password);

                    connection.Open();

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                         reader.Close();
                         connection.Close();
                         Session["username"] = Username;
                         Response.Redirect("UserDashBoard.aspx", false);
                    }
                    (HomeDemo.FindControlRecursive(this, "loginError") as Label).Visible = true;
                    reader.Close();
                    connection.Close();
               }
        }
    }
}