using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Configuration;


namespace Test
{
     public partial class TemplateSelection : System.Web.UI.Page
     {
          private string Username;
          private string userselection;
          private string query;
          protected void Page_Load(object sender, EventArgs e)
          {
               if (Session["username"] == null)
               {
                    Response.Redirect("UserLogin.aspx", false);
               }
          }

          protected void btnCTemplate1_Click(object sender, EventArgs e)
          {
               Username = Session["username"].ToString();
               userselection = "1";
               query = "UPDATE Users SET TemplateSelection = @userselection WHERE (Username = @Username)";
               using (MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ConnectionString))
               {
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@userselection", userselection);
                    command.Parameters.AddWithValue("@Username", Username);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
               }
               Response.Redirect("TemplateEditor.aspx", false);
          }

          protected void btnCTemplate2_Click(object sender, EventArgs e)
          {
               Username = Session["username"].ToString();
               userselection = "2";
               query = "UPDATE Users SET TemplateSelection = @userselection WHERE (Username = @Username)";
               using (MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ConnectionString))
               {
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@userselection", userselection);
                    command.Parameters.AddWithValue("@Username", Username);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
               }
               Response.Redirect("TemplateEditor.aspx", false);
          }

          protected void btnSTemplate1_Click(object sender, EventArgs e)
          {
               Username = Session["username"].ToString();
               userselection = "3";
               query = "UPDATE Users SET TemplateSelection = @userselection WHERE (Username = @Username)";
               using (MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ConnectionString))
               {
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@userselection", userselection);
                    command.Parameters.AddWithValue("@Username", Username);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
               }
               Response.Redirect("TemplateEditor.aspx", false);
          }

          protected void btnSTemplate2_Click(object sender, EventArgs e)
          {
               string Username = Session["username"].ToString();
               string userselection = "4";
               string query = "UPDATE Users SET TemplateSelection = @userselection WHERE (Username = @Username)";
               using (MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ConnectionString))
               {
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@userselection", userselection);
                    command.Parameters.AddWithValue("@Username", Username);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
               }
               Response.Redirect("TemplateEditor.aspx", false);
          }
     }
}