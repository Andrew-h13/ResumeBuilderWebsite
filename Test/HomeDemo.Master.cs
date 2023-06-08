using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Diagnostics;

namespace Test
{
     public partial class HomeDemo : System.Web.UI.MasterPage
     {
          protected void Page_Load(object sender, EventArgs e)
          {
               if (Session["username"] == null)
               {
                    (FindControlRecursive(this, "createAccountFeature") as HtmlControl).Visible = true;
                    (FindControlRecursive(this, "loginFeature") as HtmlControl).Visible = true;
                    (FindControlRecursive(this, "logoutFeature") as HtmlControl).Visible = false;
                    (FindControlRecursive(this, "userDashboardFeature") as HtmlControl).Visible = false;
               }
               else
               {
                    (FindControlRecursive(this, "createAccountFeature") as HtmlControl).Visible = false;
                    (FindControlRecursive(this, "loginFeature") as HtmlControl).Visible = false;
                    (FindControlRecursive(this, "logoutFeature") as HtmlControl).Visible = true;
                    (FindControlRecursive(this, "userDashboardFeature") as HtmlControl).Visible = true;
               }
          }

          public static Control FindControlRecursive(Control root, string controlId)
          {
               if (root.ID == controlId)
               {
                    return root;
               }

               foreach (Control control in root.Controls)
               {
                    Control foundControl = FindControlRecursive(control, controlId);
                    if (foundControl != null)
                    {
                         return foundControl;
                    }
                    else
                    {
                         Debug.WriteLine($"Could not find control: {control.ID}");
                    }
               }

               return null;
          }

          protected void btnAccountCreation_Click(object sender, EventArgs e)
          {
            Response.Redirect("CreateAccount.aspx", false);
          }

          protected void btnLogin_Click(object sender, EventArgs e)
          {
            Response.Redirect("UserLogin.aspx", false);
          }

          protected void btnLogOut_Click(object sender, EventArgs e)
          {
             Session["username"] = null;
               Response.Redirect("Home.aspx", false);
          }

          protected void btnUserDashboard_Click(object sender, EventArgs e)
          {
            Server.Transfer("UserDashBoard.aspx", false);
          }
    }
}