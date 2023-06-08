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
     public partial class AccCreation : System.Web.UI.Page
     {
          protected void Page_Load(object sender, EventArgs e)
          {
               if (Session["username"] != null)
               {
                    Response.Redirect("UserDashBoard.aspx", false);
               }
          }

          protected void btnCrAcc_Click(object sender, EventArgs e)
          {
               if (Page.IsValid)
               {
                    string Username = txtUsername.Text;
                    string Email = txtEmail.Text;
                    string FirstName = txtFirstName.Text;
                    string LastName = txtLastName.Text;
                    string PhoneNum = txtPhoneNum.Text;
                    string StreetAddress = txtStreetAddress.Text;
                    string City = txtCity.Text;
                    string State = ddlState.SelectedValue;
                    string ZipCode = txtZipCode.Text;
                    string Password = txtPassword.Text;


                    string query1 = "SELECT * FROM Users WHERE Username = @Username OR Email = @Email";
                    string query2 = "INSERT INTO Users (Username, FirstName, LastName, PhoneNum, Email, StreetAddress, City, State, ZipCode, Password) " + 
                                    "VALUES (@Username, @FirstName, @LastName, @PhoneNum, @Email, @StreetAddress, @City, @State, @ZipCode, @Password)";

                    using (MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ConnectionString))
                    {
                         MySqlCommand command1 = new MySqlCommand(query1, connection);
                         command1.Parameters.AddWithValue("@Username", Username);
                         command1.Parameters.AddWithValue("@Email", Email);
                        
                         connection.Open();

                         MySqlDataReader reader1 = command1.ExecuteReader();

                         //check if username or email already taken
                         if (reader1.HasRows)
                         {
                              (HomeDemo.FindControlRecursive(this, "accountExistsError") as Label).Visible = true;
                              reader1.Close();
                              connection.Close();

                         }
                         else
                         {
                              reader1.Close();
                              MySqlCommand command2 = new MySqlCommand(query2, connection);
                              command2.Parameters.AddWithValue("@Username", Username);
                              command2.Parameters.AddWithValue("@FirstName", FirstName);
                              command2.Parameters.AddWithValue("@LastName", LastName);
                              command2.Parameters.AddWithValue("@PhoneNum", PhoneNum);
                              command2.Parameters.AddWithValue("@Email", Email);
                              command2.Parameters.AddWithValue("@StreetAddress", StreetAddress);
                              command2.Parameters.AddWithValue("@City", City);
                              command2.Parameters.AddWithValue("@State", State);
                              command2.Parameters.AddWithValue("@ZipCode", ZipCode);
                              command2.Parameters.AddWithValue("@Password", Password);
                              command2.ExecuteNonQuery();
                              connection.Close();
                              Session["username"] = Username;
                              Response.Redirect("UserDashboard.aspx");
                         }
                    }
               }
          }
     }
}