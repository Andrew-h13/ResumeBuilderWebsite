using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Web.UI.HtmlControls;
using System.Configuration;

namespace Test
{
     public partial class WebForm1 : System.Web.UI.Page
     {
          protected void Page_Load(object sender, EventArgs e)
          {


               using (MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ConnectionString))
               {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM User", connection))
                    {
                         using (MySqlDataReader reader = command.ExecuteReader())
                         {
                              while (reader.Read())
                              {
                                   if (reader.IsDBNull(0))
                                   {

                                   }
                                   //will return Elton John's ID
                                   int column1Value = reader.GetInt32(0);
                                   Debug.WriteLine(column1Value);
                                   //will return Elton John's name
                                   string column2Value = reader.GetString(1);
                                   Debug.WriteLine(column2Value);
                                   // ...
                              }
                         }
                    }
               }
          }
     }
}