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
    public partial class WebForm3 : System.Web.UI.Page
    {
          private string username;
          private string query;
          private string userselection;
        protected void Page_Load(object sender, EventArgs e)
        {
               if (Session["username"] == null)
               {
                    Response.Redirect("UserLogin.aspx", false);
               }
               username = Session["username"].ToString();

               query = "SELECT * FROM Users WHERE username = @username";
               using (MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ConnectionString))
               {
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);


                    connection.Open();

                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                         txtUD_FullName.Text = reader["FirstName"].ToString() + " " + reader["LastName"].ToString();
                         txtUD_ContactNum.Text = reader["PhoneNum"].ToString();
                         txtUD_Email.Text = reader["Email"].ToString();
                         ddlUD_State.SelectedValue = reader["State"].ToString();
                         txtUD_Street.Text = reader["StreetAddress"].ToString();
                         txtUD_City.Text = reader["City"].ToString();
                         txtUD_ZipCode.Text = reader["ZipCode"].ToString();
                         txtUD_UserID.Text = reader["Username"].ToString();
                    }
                    reader.Close();
                    connection.Close();
               }
               query = "SELECT TemplateSelection FROM Users WHERE username = @username";

               using (MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ConnectionString))
               {
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    connection.Open();

                    MySqlDataReader reader = command.ExecuteReader();

                    // if username exists in the table (condition already checked)
                    if (reader.Read())
                    {
                         // if user hasn't selected a template, set to 1
                         if (reader.IsDBNull(0))
                         {
                              userselection = "1";
                         }
                         else
                         {
                              userselection = reader.GetString(0);
                         }
                    }
                    reader.Close();
                    connection.Close();
                    if (userselection=="1")
                    {
                         templateimage.Attributes["src"] = "/img/chron1.png";
                    }
                    else if (userselection == "2")
                    {
                         templateimage.Attributes["src"] = "/img/chron2.png";
                    }
                    else if (userselection == "3")
                    {
                         templateimage.Attributes["src"] = "/img/skills1.png";
                    }
                    else if (userselection == "4")
                    {
                         templateimage.Attributes["src"] = "/img/skills2.png";
                    }
                    else
                    {
                         templateimage.Attributes["src"] = "/img/chron1.png";
                    }
               }
          
        }


          protected void btnDiffTemplate_Click(object sender, EventArgs e)
        {
            Response.Redirect("TemplateSelection.aspx", false);
        }

        protected void btnContinueEdit_Click(object sender, EventArgs e)
        {
            Response.Redirect("TemplateEditor.aspx", false);
        }

        protected void btnFileUpload_Click(object sender, EventArgs e)
        {
            if (DB_FileUpLoad.HasFile)
            {

                DB_FileUpLoad.SaveAs(@"C:\temp\" + DB_FileUpLoad.FileName);
                FU_Message.Text = "File Uploaded: " + DB_FileUpLoad.FileName;
            }
            else
            {
                FU_Message.Text = "No File Uploaded.";
            }
        }

    }
}