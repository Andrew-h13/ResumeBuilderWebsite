using SendGrid.Helpers.Mail;
using SendGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace Test
{

    public partial class WebForm4 : System.Web.UI.Page
    {
        protected async void Page_Load(object sender, EventArgs e)
        {
                   await btnResetPassword_Click(sender, e); 
        }

          protected async Task btnResetPassword_Click(object sender, EventArgs e)
          {
               string useraddress = txtEmailPassword.Text;
               await Execute(useraddress);
          }

          static async Task Execute(string recipientEmail)
          {
               const string pattern = @"[\w!@#$%^&*()_+{}[\]|\-:;<>,.?/]{8}";
               var random = new Random();
               var randomString = Regex.Match(Guid.NewGuid().ToString(), pattern).Value;
               string apiKey = ConfigurationManager.AppSettings["SENDGRID_API_KEY"];
               var client = new SendGridClient(apiKey);
               var from = new EmailAddress("los.senores.help@gmail.com", "TakoResume Team");
               var subject = "Password reset";
               var to = new EmailAddress(recipientEmail, "User");
               var plainTextContent = String.Format("You temporary password is: {0} You may login with this password, then update it within the user dashboard. Thanks for using TakoResume!", randomString);
               var htmlContent = String.Format("You temporary password is: {0} You may login with this password, then update it within the user dashboard. Thanks for using TakoResume!", randomString);
               var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
               var response = await client.SendEmailAsync(msg);
          }
     }
}