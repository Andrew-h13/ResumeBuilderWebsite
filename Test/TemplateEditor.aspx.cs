using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Text;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using IronPdf;
using System.Net;
using System.Net.Mail;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.IO;
using System.Diagnostics;

namespace Test
{
     public partial class TemplateEditor : System.Web.UI.Page
     {
          private string userselection;
          private string username;
          private string query;
          private string html = "";
          protected void Page_Load(object sender, EventArgs e)
          {
               if (Session["username"] == null)
               {
                    Response.Redirect("UserLogin.aspx", false);
               }
               Page.MaintainScrollPositionOnPostBack = true;

               username = Session["username"].ToString();
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
                         // if user hasn't selected a template, redirect to selection page
                         if (reader.IsDBNull(0))
                         {
                              reader.Close();
                              connection.Close();
                              Response.Redirect("TemplateSelection.aspx", false);
                         }
                         userselection = reader.GetString(0);
                         reader.Close();
                         connection.Close();
                    }
               }

               // My chronological template (old)
               if (userselection == "1")
               {
                    (HomeDemo.FindControlRecursive(this, "summarystatementrow") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "summarystatementblock") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "skill7") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "skill8") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "skill9") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "job1location") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "job2location") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "job3location") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "school1location") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "extracurricular1details") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "extracurricular2details") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "additionalskillstitlerow") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "additionalskillsblock") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "awardsandcertstitlerow") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "awardsandcertsblock") as HtmlGenericControl).Visible = false;
               }

               // My plain chronological resume (new)
               else if (userselection=="2")
               {
                    (HomeDemo.FindControlRecursive(this, "summarystatementrow") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "summarystatementblock") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "skill4") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "skill5") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "skill6") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "skill7") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "skill8") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "skill9") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "job1location") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "job2location") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "job3location") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "school1location") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "extracurricular1details") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "extracurricular2details") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "additionalskillstitlerow") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "additionalskillsblock") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "awardsandcertstitlerow") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "awardsandcertsblock") as HtmlGenericControl).Visible = false;
               }

               // Serafima's skills template
               else if (userselection == "3")
               {
                    (HomeDemo.FindControlRecursive(this, "workExperienceTitleRow") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "job1block") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "job2block") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "job3block") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "awardsandcertstitlerow") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "awardsandcertsblock") as HtmlGenericControl).Visible = false;
               }
                    
               // Katie's "skills" template
               else if (userselection == "4")
               {
                    (HomeDemo.FindControlRecursive(this, "objectiveTitleRow") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "objective") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "skill6") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "skill7") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "skill8") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "skill9") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "job1location") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "job2location") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "job3block") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "GPAblock") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "extracurricularsblock") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "additionalskillstitlerow") as HtmlGenericControl).Visible = false;
                    (HomeDemo.FindControlRecursive(this, "additionalskillsblock") as HtmlGenericControl).Visible = false;
               }
          }

          protected void btnDownload_Click(object sender, EventArgs e)
          {
               var renderer = new ChromePdfRenderer();
               renderer.RenderingOptions.PaperSize = IronPdf.Rendering.PdfPaperSize.Custom;
               renderer.RenderingOptions.SetCustomPaperSizeInInches(8.5f, 11f);
               
               if (userselection=="1") // My chronological resume (old)
               {
                    renderer.RenderingOptions.MarginTop = 12.7;
                    renderer.RenderingOptions.MarginBottom = 12.7;
                    renderer.RenderingOptions.MarginLeft = 12.7;
                    renderer.RenderingOptions.MarginRight = 12.7;

                    html = $@"<html>

<head>
<meta http-equiv=Content-Type content='text/html; charset=windows-1252'>
<meta name=Generator content='Microsoft Word 15 (filtered)'>
<style>
<!--
 /* Font Definitions */
 @font-face
	{{font-family:Wingdings;
	panose-1:5 0 0 0 0 0 0 0 0 0;}}
@font-face
	{{font-family:'Cambria Math';
	panose-1:2 4 5 3 5 4 6 3 2 4;}}
@font-face
	{{font-family:Calibri;
	panose-1:2 15 5 2 2 2 4 3 2 4;}}
@font-face
	{{font-family:'Segoe UI';
	panose-1:2 11 5 2 4 2 4 2 2 3;}}
@font-face
	{{font-family:Consolas;
	panose-1:2 11 6 9 2 2 4 3 2 4;}}
@font-face
	{{font-family:Georgia;
	panose-1:2 4 5 2 5 4 5 2 3 3;}}
 /* Style Definitions */
 p.MsoNormal, li.MsoNormal, div.MsoNormal
	{{margin:0in;
	font-size:11.0pt;
	font-family:'Calibri',sans-serif;
	color:#595959;}}
h1
	{{mso-style-link:'Heading 1 Char';
	margin-top:20.0pt;
	margin-right:0in;
	margin-bottom:10.0pt;
	margin-left:0in;
	page-break-after:avoid;
	font-size:14.0pt;
	font-family:'Georgia',serif;
	color:#262626;
	text-transform:uppercase;
	font-weight:bold;}}
h1.CxSpFirst
	{{mso-style-link:'Heading 1 Char';
	margin-top:20.0pt;
	margin-right:0in;
	margin-bottom:0in;
	margin-left:0in;
	margin-bottom:.0001pt;
	page-break-after:avoid;
	font-size:14.0pt;
	font-family:'Georgia',serif;
	color:#262626;
	text-transform:uppercase;
	font-weight:bold;}}
h1.CxSpMiddle
	{{mso-style-link:'Heading 1 Char';
	margin:0in;
	margin-bottom:.0001pt;
	page-break-after:avoid;
	font-size:14.0pt;
	font-family:'Georgia',serif;
	color:#262626;
	text-transform:uppercase;
	font-weight:bold;}}
h1.CxSpLast
	{{mso-style-link:'Heading 1 Char';
	margin-top:0in;
	margin-right:0in;
	margin-bottom:10.0pt;
	margin-left:0in;
	page-break-after:avoid;
	font-size:14.0pt;
	font-family:'Georgia',serif;
	color:#262626;
	text-transform:uppercase;
	font-weight:bold;}}
h2
	{{mso-style-link:'Heading 2 Char';
	margin-top:0in;
	margin-right:0in;
	margin-bottom:2.0pt;
	margin-left:0in;
	font-size:13.0pt;
	font-family:'Calibri',sans-serif;
	color:#1D824C;
	text-transform:uppercase;
	font-weight:bold;}}
h3
	{{mso-style-link:'Heading 3 Char';
	margin:0in;
	font-size:11.0pt;
	font-family:'Calibri',sans-serif;
	color:#595959;
	text-transform:uppercase;
	font-weight:bold;}}
p.MsoHeader, li.MsoHeader, div.MsoHeader
	{{mso-style-link:'Header Char';
	margin:0in;
	font-size:11.0pt;
	font-family:'Calibri',sans-serif;
	color:#595959;}}
p.MsoFooter, li.MsoFooter, div.MsoFooter
	{{mso-style-link:'Footer Char';
	margin:0in;
	text-align:center;
	font-size:11.0pt;
	font-family:'Calibri',sans-serif;
	color:#595959;}}
p.MsoListBullet, li.MsoListBullet, div.MsoListBullet
	{{margin-top:0in;
	margin-right:0in;
	margin-bottom:0in;
	margin-left:.25in;
	text-indent:-.25in;
	font-size:11.0pt;
	font-family:'Calibri',sans-serif;
	color:#595959;}}
p.MsoTitle, li.MsoTitle, div.MsoTitle
	{{mso-style-link:'Title Char';
	margin:0in;
	text-align:center;
	font-size:35.0pt;
	font-family:'Georgia',serif;
	color:#595959;
	text-transform:uppercase;}}
p.MsoTitleCxSpFirst, li.MsoTitleCxSpFirst, div.MsoTitleCxSpFirst
	{{mso-style-link:'Title Char';
	margin:0in;
	text-align:center;
	font-size:35.0pt;
	font-family:'Georgia',serif;
	color:#595959;
	text-transform:uppercase;}}
p.MsoTitleCxSpMiddle, li.MsoTitleCxSpMiddle, div.MsoTitleCxSpMiddle
	{{mso-style-link:'Title Char';
	margin:0in;
	text-align:center;
	font-size:35.0pt;
	font-family:'Georgia',serif;
	color:#595959;
	text-transform:uppercase;}}
p.MsoTitleCxSpLast, li.MsoTitleCxSpLast, div.MsoTitleCxSpLast
	{{mso-style-link:'Title Char';
	margin:0in;
	text-align:center;
	font-size:35.0pt;
	font-family:'Georgia',serif;
	color:#595959;
	text-transform:uppercase;}}
span.MsoIntenseEmphasis
	{{color:#262626;
	font-weight:bold;}}
span.MsoSubtleReference
	{{font-variant:small-caps;
	color:#595959;
	text-transform:none;
	font-weight:bold;}}
span.TitleChar
	{{mso-style-name:'Title Char';
	mso-style-link:Title;
	font-family:'Georgia',serif;
	text-transform:uppercase;}}
span.HeaderChar
	{{mso-style-name:'Header Char';
	mso-style-link:Header;}}
span.FooterChar
	{{mso-style-name:'Footer Char';
	mso-style-link:Footer;}}
p.ContactInfo, li.ContactInfo, div.ContactInfo
	{{mso-style-name:'Contact Info';
	margin:0in;
	text-align:center;
	font-size:11.0pt;
	font-family:'Calibri',sans-serif;
	color:#595959;}}
span.Heading1Char
	{{mso-style-name:'Heading 1 Char';
	mso-style-link:'Heading 1';
	font-family:'Georgia',serif;
	color:#262626;
	text-transform:uppercase;
	font-weight:bold;}}
span.Heading2Char
	{{mso-style-name:'Heading 2 Char';
	mso-style-link:'Heading 2';
	font-family:'Times New Roman',serif;
	color:#1D824C;
	text-transform:uppercase;
	font-weight:bold;}}
span.Heading3Char
	{{mso-style-name:'Heading 3 Char';
	mso-style-link:'Heading 3';
	font-family:'Times New Roman',serif;
	text-transform:uppercase;
	font-weight:bold;}}
p.ContactInfoEmphasis, li.ContactInfoEmphasis, div.ContactInfoEmphasis
	{{mso-style-name:'Contact Info Emphasis';
	margin:0in;
	text-align:center;
	font-size:11.0pt;
	font-family:'Calibri',sans-serif;
	color:#1D824C;
	font-weight:bold;}}
.MsoChpDefault
	{{font-family:'Calibri',sans-serif;
	color:#595959;}}
 /* Page Definitions */
 @page WordSection1
	{{size:8.5in 11.0in;
	margin:47.5pt 1.0in .75in 1.0in;}}
div.WordSection1
	{{page:WordSection1;}}
 /* List Definitions */
 ol
	{{margin-bottom:0in;}}
ul
	{{margin-bottom:0in;}}
-->
</style>

</head>

<body lang=EN-US link='#2C5C85' vlink='#BF4A27' style='word-wrap:break-word'>

<div class=WordSection1>

<table class=MsoTableGrid border=0 cellspacing=0 cellpadding=0
 summary='Layout table for name, contact info, and objective' width='100%'
 style='width:100.0%;border-collapse:collapse'>
 <tr style='height:1.25in'>
  <td width=624 valign=top style='width:6.5in;padding:0in 0in 0in 0in;
  height:1.25in'>
  <p class=MsoTitle>{txtTE_FirstName.Text} <span class=MsoIntenseEmphasis>{txtTE_LastName.Text}</span></p>
  <p class=ContactInfo>{txtTE_Address.Text} <b><span style='color:#595959'>&#8226</span></b> {txtTE_PhoneNum.Text}</p>
  <p class=ContactInfoEmphasis>{txtTE_Email.Text} </p>
  </td>
 </tr>
 <tr>
  <td width=624 valign=top style='width:6.5in;padding:.3in 0in 5.75pt 0in'>
  <p class=MsoNormal>{txtTE_Objective.Text}</p>
  </td>
 </tr>
</table>

<h1>Education</h1>

<table class=MsoTableGrid border=1 cellspacing=0 cellpadding=0
 summary='Education layout table' width='99%' style='width:99.5%;margin-left:
 .05in;border-collapse:collapse;border:none'>
 <tr>
  <td width=619 valign=top style='width:464.5pt;border:none;border-left:dotted #BFBFBF 2.25pt;
  padding:0in 0in 0in .4in'>
  <h3>{txtTE_GradDate.Text}</h3>
  <h2>{txtTE_Degree.Text}, <span class=MsoSubtleReference><span style='color:windowtext;
  text-transform:uppercase;font-weight:normal'>{txtTE_School.Text}</span></span></h2>
  <h2><span style='font-size:11.0pt;color:#595959;font-weight:normal'><span
  style='color:windowtext'>&#8226&nbsp&nbsp;GPA: </span></span><span style='font-size:11.0pt;
  color:#595959;text-transform:none;font-weight:normal'><span style='color:
  windowtext'>{txtTE_GPA.Text}</span></span></h2>
  <h2><span style='font-size:11.0pt;color:#595959;font-weight:normal'><span
  style='color:windowtext'>&#8226&nbsp&nbsp</span></span><span style='font-size:11.0pt;
  color:#595959;text-transform:none;font-weight:normal'><span style='color:
  windowtext'>Extracurriculars: {txtTE_Extracaricular1.Text}, {txtTE_Extracaricular2.Text}</span></span></h2>
  </td>
 </tr>
</table>

<h1>Experience</h1>

<table class=MsoTableGrid border=1 cellspacing=0 cellpadding=0
 summary='Experience layout table' width='99%' style='width:99.5%;margin-left:
 .05in;border-collapse:collapse;border:none'>
 <tr>
  <td width=624 valign=top style='width:467.75pt;border:none;border-left:dotted #BFBFBF 2.25pt;
  padding:0in 0in 0in .4in'>
  <h3>{txtTE_TimeWorked.Text}</h3>
  <h2>{txtTE_JobTitle1.Text}, <span class=MsoSubtleReference><span style='color:windowtext;
  text-transform:uppercase;font-weight:normal'>{txtTE_Company1.Text}</span></span></h2>
  <h2><span style='font-size:11.0pt;color:#595959;font-weight:normal'><span
  style='color:windowtext'>&#8226&nbsp&nbsp</span></span><span style='color:#595959;
  font-weight:normal'><span style='color:windowtext'>  </span></span><span
  style='font-size:11.0pt;color:#595959;font-weight:normal'><span
  style='color:windowtext'></span></span><span style='font-size:11.0pt;
  color:#595959;text-transform:none;font-weight:normal'><span style='color:
  windowtext'>{txtTE_Job1Responsibilities1.Text}</span></span></h2>
  <h2><span style='font-size:11.0pt;color:#595959;font-weight:normal'><span
  style='color:windowtext'>&#8226&nbsp&nbsp</span></span><span style='color:#595959;
  font-weight:normal'><span style='color:windowtext'>  </span></span><span
  style='font-size:11.0pt;color:#595959;font-weight:normal'><span
  style='color:windowtext'></span></span><span style='font-size:11.0pt;
  color:#595959;text-transform:none;font-weight:normal'><span style='color:
  windowtext'>{txtTE_Job1Responsibilities2.Text}</span></span></h2>
  <h2><span style='font-size:11.0pt;color:#595959;font-weight:normal'><span
  style='color:windowtext'>&#8226&nbsp&nbsp</span></span><span style='color:#595959;
  font-weight:normal'><span style='color:windowtext'>  </span></span><span
  style='font-size:11.0pt;color:#595959;font-weight:normal'><span
  style='color:windowtext'></span></span><span style='font-size:11.0pt;
  color:#595959;text-transform:none;font-weight:normal'><span style='color:
  windowtext'>{txtTE_Job1Responsibilities3.Text}</span></span></h2>
  </td>
 </tr>
 <tr>
  <td width=624 valign=top style='width:467.75pt;border:none;border-left:dotted #BFBFBF 2.25pt;
  padding:.15in 0in 0in .4in'>
  <h3>{txtTE_TimeWorked2.Text}</h3>
  <h2>{txtTE_JobTitle2.Text}, <span class=MsoSubtleReference><span style='color:windowtext;
  text-transform:uppercase;font-weight:normal'>{txtTE_Company2.Text}</span></span></h2>
  <h2><span style='font-size:11.0pt;color:#595959;font-weight:normal'><span
  style='color:windowtext'>&#8226&nbsp&nbsp</span></span><span style='color:#595959;
  font-weight:normal'><span style='color:windowtext'>  </span></span><span
  style='font-size:11.0pt;color:#595959;font-weight:normal'><span
  style='color:windowtext'></span></span><span style='font-size:11.0pt;
  color:#595959;text-transform:none;font-weight:normal'><span style='color:
  windowtext'>{txtTE_Job2Responsibilities1.Text}</span></span></h2>
  <h2><span style='font-size:11.0pt;color:#595959;font-weight:normal'><span
  style='color:windowtext'>&#8226&nbsp&nbsp</span></span><span style='color:#595959;
  font-weight:normal'><span style='color:windowtext'>  </span></span><span
  style='font-size:11.0pt;color:#595959;font-weight:normal'><span
  style='color:windowtext'></span></span><span style='font-size:11.0pt;
  color:#595959;text-transform:none;font-weight:normal'><span style='color:
  windowtext'>{txtTE_Job2Responsibilities2.Text}</span></span></h2>
  <h2><span style='font-size:11.0pt;color:#595959;font-weight:normal'><span
  style='color:windowtext'>&#8226&nbsp&nbsp</span></span><span style='color:#595959;
  font-weight:normal'><span style='color:windowtext'>  </span></span><span
  style='font-size:11.0pt;color:#595959;font-weight:normal'><span
  style='color:windowtext'></span></span><span style='font-size:11.0pt;
  color:#595959;text-transform:none;font-weight:normal'><span style='color:
  windowtext'>{txtTE_Job2Responsibilities3.Text}</span></span></h2>
  </td>
 </tr>
 <tr>
  <td width=624 valign=top style='width:467.75pt;border:none;border-left:dotted #BFBFBF 2.25pt;
  padding:.15in 0in 0in .4in'>
  <h3>{txtTE_Timeworked3.Text}</h3>
  <h2>{txtTE_JobTitle3.Text}, <span class=MsoSubtleReference><span style='color:windowtext;
  text-transform:uppercase;font-weight:normal'>{txtTE_Company3.Text}</span></span></h2>
  <h2><span style='font-size:11.0pt;color:#595959;font-weight:normal'><span
  style='color:windowtext'>&#8226&nbsp&nbsp</span></span><span style='color:#595959;
  font-weight:normal'><span style='color:windowtext'>  </span></span><span
  style='font-size:11.0pt;color:#595959;font-weight:normal'><span
  style='color:windowtext'></span></span><span style='font-size:11.0pt;
  color:#595959;text-transform:none;font-weight:normal'><span style='color:
  windowtext'>{txtTE_Job3Responsibilities1.Text}</span></span></h2>
  <h2><span style='font-size:11.0pt;color:#595959;font-weight:normal'><span
  style='color:windowtext'>&#8226&nbsp&nbsp</span></span><span style='color:#595959;
  font-weight:normal'><span style='color:windowtext'>  </span></span><span
  style='font-size:11.0pt;color:#595959;font-weight:normal'><span
  style='color:windowtext'></span></span><span style='font-size:11.0pt;
  color:#595959;text-transform:none;font-weight:normal'><span style='color:
  windowtext'>{txtTE_Job3Responsibilities2.Text}</span></span></h2>
  <h2><span style='font-size:11.0pt;color:#595959;font-weight:normal'><span
  style='color:windowtext'>&#8226&nbsp&nbsp</span></span><span style='color:#595959;
  font-weight:normal'><span style='color:windowtext'>  </span></span><span
  style='font-size:11.0pt;color:#595959;font-weight:normal'><span
  style='color:windowtext'></span></span><span style='font-size:11.0pt;
  color:#595959;text-transform:none;font-weight:normal'><span style='color:
  windowtext'>{txtTE_Job3Responsibilities3.Text}</span></span></h2>
  </td>
 </tr>
</table>

<h1>Skills</h1>

<table class=MsoTableGrid border=0 cellspacing=0 cellpadding=0
 summary='Skills layout table' width='100%' style='width:100.0%;border-collapse:
 collapse'>
 <tr>
  <td width=312 valign=top style='width:233.75pt;padding:0in 0in 0in 0in'>
  <h2><span style='font-size:11.0pt;font-weight:normal'>&#8226&nbsp&nbsp</span><span
  style='font-size:11.0pt;color:#595959;font-weight:normal'><span
  style='color:windowtext'></span></span><span style='font-size:11.0pt;
  color:#595959;text-transform:none;font-weight:normal'><span style='color:
  windowtext'>{txtTE_Skill1.Text}</span></span></h2>
  <h2><span style='font-size:11.0pt;font-weight:normal'>&#8226&nbsp&nbsp</span><span
  style='font-size:11.0pt;color:#595959;font-weight:normal'><span
  style='color:windowtext'></span></span><span style='font-size:11.0pt;
  color:#595959;text-transform:none;font-weight:normal'><span style='color:
  windowtext'>{txtTE_Skill2.Text}</span></span></h2>
  <h2><span style='font-size:11.0pt;font-weight:normal'>&#8226&nbsp&nbsp</span><span
  style='font-size:11.0pt;color:#595959;font-weight:normal'><span
  style='color:windowtext'></span></span><span style='font-size:11.0pt;
  color:#595959;text-transform:none;font-weight:normal'><span style='color:
  windowtext'>{txtTE_Skill3.Text}</span></span></h2>
  <h2><span style='font-size:11.0pt;color:#595959;text-transform:none;
  font-weight:normal'>&nbsp;</span></h2>
  <p class=MsoListBullet style='text-indent:0in'>&nbsp;</p>
  </td>
  <td width=312 valign=top style='width:233.75pt;padding:0in 0in 0in .25in'>
  <h2><span style='font-size:11.0pt;font-weight:normal'>&#8226&nbsp&nbsp</span><span
  style='font-size:11.0pt;color:#595959;font-weight:normal'><span
  style='color:windowtext'></span></span><span style='font-size:11.0pt;
  color:#595959;text-transform:none;font-weight:normal'><span style='color:
  windowtext'>{txtTE_Skill4.Text}</span></span></h2>
  <h2><span style='font-size:11.0pt;font-weight:normal'>&#8226&nbsp&nbsp</span><span
  style='font-size:11.0pt;color:#595959;font-weight:normal'><span
  style='color:windowtext'></span></span><span style='font-size:11.0pt;
  color:#595959;text-transform:none;font-weight:normal'><span style='color:
  windowtext'>{txtTE_Skill5.Text}</span></span></h2>
  <h2><span style='font-size:11.0pt;font-weight:normal'>&#8226&nbsp&nbsp</span><span
  style='font-size:11.0pt;color:#595959;font-weight:normal'><span
  style='color:windowtext'></span></span><span style='font-size:11.0pt;
  color:#595959;text-transform:none;font-weight:normal'><span style='color:
  windowtext'>{txtTE_Skill6.Text}</span></span></h2>
  </td>
 </tr>
</table>

<p class=MsoNormal>&nbsp;</p>

</div>

</body>

</html>
";}
               else if (userselection == "2") // My plain chronological template (new)
               {
                    renderer.RenderingOptions.MarginTop = 25.4;
                    renderer.RenderingOptions.MarginBottom = 25.4;
                    renderer.RenderingOptions.MarginLeft = 25.4;
                    renderer.RenderingOptions.MarginRight = 25.4;
                    html = $@"<html>

<head>
<meta http-equiv=Content-Type content='text/html; charset=windows-1252'>
<meta name=Generator content='Microsoft Word 15 (filtered)'>
<style>
<!--
 /* Font Definitions */
 @font-face
	{{font-family:Wingdings;
	panose-1:5 0 0 0 0 0 0 0 0 0;}}
@font-face
	{{font-family:'Cambria Math';
	panose-1:2 4 5 3 5 4 6 3 2 4;}}
@font-face
	{{font-family:Cambria;
	panose-1:2 4 5 3 5 4 6 3 2 4;}}
@font-face
	{{font-family:HGMinchoB;
	panose-1:0 0 0 0 0 0 0 0 0 0;}}
@font-face
	{{font-family:'Segoe UI';
	panose-1:2 11 5 2 4 2 4 2 2 3;}}
@font-face
	{{font-family:Consolas;
	panose-1:2 11 6 9 2 2 4 3 2 4;}}
@font-face
	{{font-family:'\@HGMinchoB';}}
 /* Style Definitions */
 p.MsoNormal, li.MsoNormal, div.MsoNormal
	{{margin-top:0in;
	margin-right:0in;
	margin-bottom:12.0pt;
	margin-left:0in;
	font-size:11.0pt;
	font-family:'Cambria',serif;
	color:#404040;}}
h1
	{{mso-style-link:'Heading 1 Char';
	margin-top:16.0pt;
	margin-right:0in;
	margin-bottom:5.0pt;
	margin-left:0in;
	page-break-after:avoid;
	font-size:14.0pt;
	font-family:'Cambria',serif;
	color:#2A7B88;}}
h1.CxSpFirst
	{{mso-style-link:'Heading 1 Char';
	margin-top:16.0pt;
	margin-right:0in;
	margin-bottom:0in;
	margin-left:0in;
	page-break-after:avoid;
	font-size:14.0pt;
	font-family:'Cambria',serif;
	color:#2A7B88;}}
h1.CxSpMiddle
	{{mso-style-link:'Heading 1 Char';
	margin:0in;
	page-break-after:avoid;
	font-size:14.0pt;
	font-family:'Cambria',serif;
	color:#2A7B88;}}
h1.CxSpLast
	{{mso-style-link:'Heading 1 Char';
	margin-top:0in;
	margin-right:0in;
	margin-bottom:5.0pt;
	margin-left:0in;
	page-break-after:avoid;
	font-size:14.0pt;
	font-family:'Cambria',serif;
	color:#2A7B88;}}
h2
	{{mso-style-link:'Heading 2 Char';
	margin-top:3.0pt;
	margin-right:0in;
	margin-bottom:2.0pt;
	margin-left:0in;
	page-break-after:avoid;
	font-size:12.0pt;
	font-family:'Cambria',serif;
	color:#262626;
	text-transform:uppercase;}}
h2.CxSpFirst
	{{mso-style-link:'Heading 2 Char';
	margin-top:3.0pt;
	margin-right:0in;
	margin-bottom:0in;
	margin-left:0in;
	page-break-after:avoid;
	font-size:12.0pt;
	font-family:'Cambria',serif;
	color:#262626;
	text-transform:uppercase;}}
h2.CxSpMiddle
	{{mso-style-link:'Heading 2 Char';
	margin:0in;
	page-break-after:avoid;
	font-size:12.0pt;
	font-family:'Cambria',serif;
	color:#262626;
	text-transform:uppercase;}}
h2.CxSpLast
	{{mso-style-link:'Heading 2 Char';
	margin-top:0in;
	margin-right:0in;
	margin-bottom:2.0pt;
	margin-left:0in;
	page-break-after:avoid;
	font-size:12.0pt;
	font-family:'Cambria',serif;
	color:#262626;
	text-transform:uppercase;}}
p.MsoListBullet, li.MsoListBullet, div.MsoListBullet
	{{margin-top:0in;
	margin-right:0in;
	margin-bottom:12.0pt;
	margin-left:.15in;
	text-indent:-.15in;
	line-height:120%;
	font-size:11.0pt;
	font-family:'Cambria',serif;
	color:#404040;}}
p.MsoListBulletCxSpFirst, li.MsoListBulletCxSpFirst, div.MsoListBulletCxSpFirst
	{{margin-top:0in;
	margin-right:0in;
	margin-bottom:0in;
	margin-left:.15in;
	text-indent:-.15in;
	line-height:120%;
	font-size:11.0pt;
	font-family:'Cambria',serif;
	color:#404040;}}
p.MsoListBulletCxSpMiddle, li.MsoListBulletCxSpMiddle, div.MsoListBulletCxSpMiddle
	{{margin-top:0in;
	margin-right:0in;
	margin-bottom:0in;
	margin-left:.15in;
	text-indent:-.15in;
	line-height:120%;
	font-size:11.0pt;
	font-family:'Cambria',serif;
	color:#404040;}}
p.MsoListBulletCxSpLast, li.MsoListBulletCxSpLast, div.MsoListBulletCxSpLast
	{{margin-top:0in;
	margin-right:0in;
	margin-bottom:12.0pt;
	margin-left:.15in;
	text-indent:-.15in;
	line-height:120%;
	font-size:11.0pt;
	font-family:'Cambria',serif;
	color:#404040;}}
p.MsoTitle, li.MsoTitle, div.MsoTitle
	{{mso-style-link:'Title Char';
	margin-top:0in;
	margin-right:0in;
	margin-bottom:6.0pt;
	margin-left:0in;
	border:none;
	padding:0in;
	font-size:28.0pt;
	font-family:'Cambria',serif;
	color:#2A7B88;}}
p.MsoTitleCxSpFirst, li.MsoTitleCxSpFirst, div.MsoTitleCxSpFirst
	{{mso-style-link:'Title Char';
	margin:0in;
	border:none;
	padding:0in;
	font-size:28.0pt;
	font-family:'Cambria',serif;
	color:#2A7B88;}}
p.MsoTitleCxSpMiddle, li.MsoTitleCxSpMiddle, div.MsoTitleCxSpMiddle
	{{mso-style-link:'Title Char';
	margin:0in;
	border:none;
	padding:0in;
	font-size:28.0pt;
	font-family:'Cambria',serif;
	color:#2A7B88;}}
p.MsoTitleCxSpLast, li.MsoTitleCxSpLast, div.MsoTitleCxSpLast
	{{mso-style-link:'Title Char';
	margin-top:0in;
	margin-right:0in;
	margin-bottom:6.0pt;
	margin-left:0in;
	border:none;
	padding:0in;
	font-size:28.0pt;
	font-family:'Cambria',serif;
	color:#2A7B88;}}
span.TitleChar
	{{mso-style-name:'Title Char';
	mso-style-link:Title;
	font-family:'Cambria',serif;
	color:#2A7B88;}}
span.Heading1Char
	{{mso-style-name:'Heading 1 Char';
	mso-style-link:'Heading 1';
	font-family:'Cambria',serif;
	color:#2A7B88;
	font-weight:bold;}}
span.Heading2Char
	{{mso-style-name:'Heading 2 Char';
	mso-style-link:'Heading 2';
	font-family:'Cambria',serif;
	color:#262626;
	text-transform:uppercase;
	font-weight:bold;}}
.MsoChpDefault
	{{font-family:'Cambria',serif;
	color:#404040;}}
.MsoPapDefault
	{{margin-bottom:12.0pt;}}
 /* Page Definitions */
 @page WordSection1
	{{size:8.5in 11.0in;
	margin:.7in .8in .8in .8in;}}
div.WordSection1
	{{page:WordSection1;}}
 /* List Definitions */
 ol
	{{margin-bottom:0in;}}
ul
	{{margin-bottom:0in;}}
-->
</style>

</head>

<body lang=EN-US link='#2A7B88' vlink='#7B4968' style='word-wrap:break-word'>

<div class=WordSection1>

<div style='border:none;border-bottom:solid #39A5B7 1.5pt;padding:0in 0in 4.0pt 0in'>

<p class=MsoTitle>{txtTE_FirstName.Text} {txtTE_LastName.Text}</p>

</div>

<p class=MsoNormal>{txtTE_Address.Text}, {txtTE_City.Text}, {txtTE_State.Text} {txtTE_Zip.Text}&nbsp;|&nbsp;{txtTE_PhoneNum.Text}&nbsp;|&nbsp;{txtTE_Email.Text}</p>

<h1>Objective</h1>

<p class=MsoNormal>{txtTE_Objective.Text}</p>

<h1>Education</h1>

<h2>{txtTE_Degree.Text}&nbsp;|&nbsp;{txtTE_GradDate.Text}&nbsp;|&nbsp;{txtTE_School.Text}</h2>

<p class=MsoListBulletCxSpFirst style='margin-left:0in;text-indent:0in'>&#8226&nbsp&nbsp&nbspGPA: {txtTE_GPA.Text}</p>

<p class=MsoListBulletCxSpLast style='margin-left:0in;text-indent:0in'>&#8226&nbsp&nbsp&nbspExtracurriculars: {txtTE_Extracaricular1.Text}, {txtTE_Extracaricular2.Text}</p>

<h1>Experience</h1>

<h2>{txtTE_JobTitle1.Text}&nbsp;|&nbsp;{txtTE_Company1.Text}&nbsp;|&nbsp;{txtTE_TimeWorked.Text}</h2>

<p class=MsoListBulletCxSpFirst style='margin-left:0in;text-indent:0in'>&#8226&nbsp&nbsp&nbsp{txtTE_Job1Responsibilities1.Text}</p>

<p class=MsoListBulletCxSpMiddle style='margin-left:0in;text-indent:0in'>&#8226&nbsp&nbsp&nbsp{txtTE_Job1Responsibilities2.Text}</p>

<p class=MsoListBulletCxSpLast style='margin-left:0in;text-indent:0in'>&#8226&nbsp&nbsp&nbsp{txtTE_Job1Responsibilities3.Text}</p>

<h2>{txtTE_JobTitle2.Text}&nbsp;|&nbsp;{txtTE_Company2.Text}&nbsp;|&nbsp;{txtTE_TimeWorked2.Text}</h2>

<p class=MsoListBulletCxSpFirst style='margin-left:0in;text-indent:0in'>&#8226&nbsp&nbsp&nbsp{txtTE_Job2Responsibilities1.Text}</p>

<p class=MsoListBulletCxSpMiddle style='margin-left:0in;text-indent:0in'>&#8226&nbsp&nbsp&nbsp{txtTE_Job2Responsibilities2.Text}</p>

<p class=MsoListBulletCxSpLast style='margin-left:0in;text-indent:0in'>&#8226&nbsp&nbsp&nbsp{txtTE_Job2Responsibilities3.Text}</p>

<h2>{txtTE_JobTitle3.Text}&nbsp;|&nbsp;{txtTE_Company3.Text}&nbsp;|&nbsp;{txtTE_Timeworked3.Text}</h2>

<p class=MsoListBulletCxSpFirst style='margin-left:0in;text-indent:0in'>&#8226&nbsp&nbsp&nbsp{txtTE_Job3Responsibilities1.Text}</p>

<p class=MsoListBulletCxSpMiddle style='margin-left:0in;text-indent:0in'>&#8226&nbsp&nbsp&nbsp{txtTE_Job3Responsibilities2.Text}</p>

<p class=MsoListBulletCxSpLast style='margin-left:0in;text-indent:0in'>&#8226&nbsp&nbsp&nbsp{txtTE_Job3Responsibilities3.Text}</p>

<h1>Skills &amp; Abilities</h1>

<p class=MsoListBulletCxSpFirst style='margin-left:0in;text-indent:0in'>&#8226&nbsp&nbsp&nbsp{txtTE_Skill1.Text}</p>

<p class=MsoListBulletCxSpMiddle style='margin-left:0in;text-indent:0in'>&#8226&nbsp&nbsp&nbsp{txtTE_Skill2.Text}</p>

<p class=MsoListBulletCxSpLast style='margin-left:0in;text-indent:0in'>&#8226&nbsp&nbsp&nbsp{txtTE_Skill3.Text}</p>

</div>

</body>

</html>
";}

               else if (userselection == "3") // Serafima's skills template
               {
                    renderer.RenderingOptions.MarginTop = 9.906;
                    renderer.RenderingOptions.MarginBottom = 9.906;
                    renderer.RenderingOptions.MarginLeft = 9.906;
                    renderer.RenderingOptions.MarginRight = 9.906;
                    html = $@"

<!DOCTYPE html>

<html xmlns='http://www.w3.org/1999/xhtml'>
<head runat='server'>
    <title></title>
    <style type='text/css'>

table.MsoTableGrid {{
     border:solid windowtext 1.0pt;
	font-size:11.0pt;
	font-family:'Calibri',sans-serif;
	}}
 p.MsoNormal {{
	margin-top:0in;
	margin-right:0in;
	margin-bottom:8.0pt;
	margin-left:0in;
	line-height:107%;
	font-size:11.0pt;
	font-family:'Calibri',sans-serif;
	}}
p {{
	margin-right:0in;
	margin-left:0in;
	font-size:12.0pt;
	font-family:'Times New Roman',serif;
	}}
ul {{
	margin-bottom:0in;}}
 li.MsoNormal {{
	margin-top:0in;
	margin-right:0in;
	margin-bottom:8.0pt;
	margin-left:0in;
	line-height:107%;
	font-size:11.0pt;
	font-family:'Calibri',sans-serif;
	}}
    </style>
</head>
<body>
    <form id='form1' runat='server'>
        <div>
            <table border='0' cellpadding='0' cellspacing='0' class='MsoTableGrid' style='width:559.7pt;border-collapse:collapse;border:none;mso-yfti-tbllook:
 1184;mso-padding-alt:0in 5.4pt 0in 5.4pt;mso-border-insideh:none;mso-border-insidev:
 none' width='746'>
                <tr style='mso-yfti-irow:0;mso-yfti-firstrow:yes;height:21.8pt'>
                    <td colspan='2' style='width: 559.7pt; background: white; mso-background-themecolor: background1; padding: 0in 5.4pt 0in 5.4pt; height: 21.8pt' width='746'>
                        <p align='center' class='MsoNormal' style='margin-bottom:0in;text-align:center;
  line-height:normal'>
                            <b><span lang='EN-IN' style='font-size:28.0pt;font-family:
  &quot;PT Serif&quot;,serif;mso-bidi-font-family:Arimo;color:#AE624F;letter-spacing:
  1.0pt'>{txtTE_FirstName.Text} {txtTE_LastName.Text}</span><span lang='EN-IN' style='font-size:
  28.0pt;font-family:&quot;PT Serif&quot;,serif;color:#AE624F'><o:p></o:p></span></b></p>
                    </td>
                </tr>
                <tr style='mso-yfti-irow:1;height:20.9pt'>
                    <td colspan='2' style='width:559.7pt;border:none;border-bottom:solid black 1.5pt;
  padding:0in 5.4pt 0in 5.4pt;height:20.9pt' width='746'>
                        <p align='center' class='MsoNormal' style='margin-bottom:0in;text-align:center;
  line-height:normal'>
                            <span lang='EN-IN' style='font-size:10.0pt;font-family:
  &quot;PT Serif&quot;,serif;color:black'>{txtTE_Address.Text}, {txtTE_City.Text}, </span><span lang='EN-IN' style='font-size:10.0pt;font-family:&quot;PT Serif&quot;,serif;
  color:black'>{txtTE_State.Text} {txtTE_Zip.Text}</span><span lang='EN-IN' style='font-size:10.0pt;
  font-family:&quot;PT Serif&quot;,serif;mso-bidi-font-family:&quot;Times New Roman \(Body CS\)&quot;;
  color:black;mso-themecolor:text1;letter-spacing:.2pt'> •</span><span lang='EN-IN' style='font-size:10.0pt;font-family:&quot;PT Serif&quot;,serif;color:black'><span style='mso-spacerun:yes'>&nbsp; </span>{txtTE_Email.Text}</span><span lang='EN-IN' style='font-size:10.0pt;font-family:&quot;PT Serif&quot;,serif;mso-bidi-font-family:
  &quot;Times New Roman \(Body CS\)&quot;;color:black;mso-themecolor:text1;letter-spacing:
  .2pt'> •</span><span lang='EN-IN' style='font-size:10.0pt;font-family:&quot;PT Serif&quot;,serif;
  color:black'><span style='mso-spacerun:yes'>&nbsp; </span>{txtTE_PhoneNum.Text}</span><span lang='EN-IN' style='font-size:10.0pt;font-family:&quot;PT Serif&quot;,serif'><o:p></o:p></span></p>
                    </td>
                </tr>
                <tr style='mso-yfti-irow:2;height:3.4pt'>
                    <td colspan='2' style='width:559.7pt;border:none;mso-border-top-alt:
  solid black 1.5pt;padding:0in 5.4pt 0in 5.4pt;height:3.4pt' width='746'>
                        <p class='MsoNormal' style='margin-bottom:0in;line-height:normal'>
                            <span lang='EN-IN' style='font-size:10.0pt;font-family:&quot;PT Serif&quot;,serif'><o:p>&nbsp;</o:p></span></p>
                    </td>
                </tr>
                <tr style='mso-yfti-irow:3'>
                    <td colspan='2' style='width:559.7pt;padding:0in 5.4pt 0in 5.4pt' width='746'>
                        <p class='MsoNormal' style='margin-bottom:0in;line-height:normal'>
                            <b><span lang='EN-IN' style='font-size:12.0pt;font-family:&quot;PT Serif&quot;,serif;mso-bidi-font-family:
  Arimo'>{txtTE_Summary.Text}<o:p></o:p></span></b></p>
                    </td>
                </tr>
                <tr style='mso-yfti-irow:4'>
                    <td colspan='2' style='width:559.7pt;padding:0in 5.4pt 0in 5.4pt' width='746'>
                        <p class='MsoNormal' style='margin-bottom:0in;line-height:normal'>
                            <span lang='EN-IN' style='font-size:8.0pt;font-family:&quot;PT Serif&quot;,serif'><o:p>&nbsp;</o:p></span></p>
                    </td>
                </tr>
                <tr style='mso-yfti-irow:5'>
                    <td colspan='2' style='width:559.7pt;padding:0in 5.4pt 0in 5.4pt' valign='top' width='746'>
                        <p class='MsoNormal' style='margin-bottom:0in;line-height:normal'>
                            <span style='font-family:&quot;PT Serif&quot;,serif;mso-bidi-font-family:Arimo;mso-ansi-language:
  EN-US'>{txtTE_Objective.Text}<o:p></o:p></span></p>
                    </td>
                </tr>
                <tr style='mso-yfti-irow:6'>
                    <td colspan='2' style='width:559.7pt;padding:0in 5.4pt 0in 5.4pt' valign='top' width='746'>
                        <p class='MsoNormal' style='margin-bottom:0in;line-height:normal'>
                            <span lang='EN-IN' style='font-size:10.0pt;font-family:&quot;PT Serif&quot;,serif;mso-bidi-font-family:
  Arimo'><o:p>&nbsp;</o:p></span></p>
                    </td>
                </tr>
                <tr style='mso-yfti-irow:7'>
                    <td colspan='2' style='width:559.7pt;padding:0in 5.4pt 0in 5.4pt' valign='top' width='746'>
                        <p class='MsoNormal' style='margin-bottom:0in;line-height:normal'>
                            <b><span lang='EN-IN' style='font-size:12.0pt;font-family:&quot;PT Serif&quot;,serif;color:#AE624F;
  letter-spacing:1.0pt'>Professional Skills</span><span lang='EN-IN' style='font-size:12.0pt;font-family:&quot;PT Serif&quot;,serif;mso-bidi-font-family:
  Arimo;color:#16355D;letter-spacing:1.0pt'><o:p></o:p></span></b></p>
                    </td>
                </tr>
                <tr style='mso-yfti-irow:8;height:3.95pt'>
                    <td colspan='2' style='width:559.7pt;padding:0in 5.4pt 0in 5.4pt;
  height:3.95pt' valign='top' width='746'>
                        <p class='MsoNormal' style='margin-bottom:0in;line-height:normal'>
                            <span lang='EN-IN' style='font-size:8.0pt;font-family:&quot;PT Serif&quot;,serif;mso-bidi-font-family:
  Arimo'><o:p>&nbsp;</o:p></span></p>
                    </td>
                </tr>
                <tr style='mso-yfti-irow:9;height:28.45pt'>
                    <td colspan='2' style='width:559.7pt;padding:0in 5.4pt 0in 5.4pt;
  height:28.45pt' valign='top' width='746'>
                        <p style='margin:0in'>
                            <b><span lang='EN-IN' style='font-size:11.0pt;font-family:
  &quot;PT Serif&quot;,serif;color:#AE624F'>Technical Expertise<o:p></o:p></span></b></p>
                        <p style='margin:0in'>
                            <b><span lang='EN-IN' style='font-size:10.0pt;font-family:
  &quot;PT Serif&quot;,serif;color:#AE624F'><o:p>&nbsp;</o:p></span></b></p>
                        <ul style='margin-top:0in' type='disc'>
                            <li class='MsoNormal' style='color:black;margin-right:56.7pt;margin-bottom:
       5.0pt;line-height:normal;mso-list:l1 level1 lfo2;vertical-align:baseline'><span lang='EN-IN' style='font-family:&quot;PT Serif&quot;,serif;mso-fareast-font-family:
       &quot;Times New Roman&quot;;mso-bidi-font-family:&quot;Times New Roman&quot;;mso-fareast-language:
       EN-IN'>{txtTE_Skill1.Text}<o:p></o:p></span></li>
                            <li class='MsoNormal' style='color:black;margin-right:56.7pt;margin-bottom:
       5.0pt;line-height:normal;mso-list:l1 level1 lfo2;vertical-align:baseline'><span lang='EN-IN' style='font-family:&quot;PT Serif&quot;,serif;mso-fareast-font-family:
       &quot;Times New Roman&quot;;mso-bidi-font-family:&quot;Times New Roman&quot;;mso-fareast-language:
       EN-IN'>{txtTE_Skill2.Text}<o:p></o:p></span></li>
                            <li class='MsoNormal' style='color:black;margin-right:56.7pt;margin-bottom:
       5.0pt;line-height:normal;mso-list:l1 level1 lfo2;vertical-align:baseline'><span lang='EN-IN' style='font-family:&quot;PT Serif&quot;,serif;mso-fareast-font-family:
       &quot;Times New Roman&quot;;mso-bidi-font-family:&quot;Times New Roman&quot;;mso-fareast-language:
       EN-IN'>{txtTE_Skill3.Text}<o:p></o:p></span></li>
                        </ul>
                        <p align='right' style='margin:0in;text-align:right;line-height:150%'>
                            <b><i><span lang='EN-IN' style='font-size:10.0pt;line-height:150%;font-family:&quot;PT Serif&quot;,serif;
  color:black'><span style='mso-spacerun:yes'>&nbsp;</span><o:p></o:p></span></i></b></p>
                    </td>
                </tr>
                <tr style='mso-yfti-irow:10;height:107.3pt'>
                    <td colspan='2' style='width:559.7pt;padding:0in 5.4pt 0in 5.4pt;
  height:107.3pt' valign='top' width='746'>
                        <p class='MsoNormal' style='margin-bottom:0in;line-height:normal'>
                            <b><span lang='EN-IN' style='font-family:&quot;PT Serif&quot;,serif;mso-fareast-font-family:&quot;Times New Roman&quot;;
  mso-bidi-font-family:&quot;Times New Roman&quot;;color:#AE624F;mso-fareast-language:
  EN-IN'>Problem Solving<o:p></o:p></span></b></p>
                        <p align='right' class='MsoNormal' style='margin-bottom:0in;text-align:right;
  line-height:150%'>
                            <i><span lang='EN-IN' style='font-size:10.0pt;line-height:
  150%;font-family:&quot;PT Serif&quot;,serif;mso-fareast-font-family:&quot;Times New Roman&quot;;
  mso-bidi-font-family:&quot;Times New Roman&quot;;mso-fareast-language:EN-IN'><o:p>&nbsp;</o:p></span></i></p>
                        <ul style='margin-top:0in' type='disc'>
                            <li class='MsoNormal' style='color:black;margin-right:56.7pt;margin-bottom:
       5.0pt;line-height:normal;mso-list:l1 level1 lfo2;vertical-align:baseline'><span lang='EN-IN' style='font-family:&quot;PT Serif&quot;,serif;mso-fareast-font-family:
       &quot;Times New Roman&quot;;mso-bidi-font-family:&quot;Times New Roman&quot;;mso-fareast-language:
       EN-IN'>{txtTE_Skill4.Text}<o:p></o:p></span></li>
                            <li class='MsoNormal' style='color:black;margin-right:56.7pt;margin-bottom:
       5.0pt;line-height:normal;mso-list:l1 level1 lfo2;vertical-align:baseline'><span lang='EN-IN' style='font-family:&quot;PT Serif&quot;,serif;mso-fareast-font-family:
       &quot;Times New Roman&quot;;mso-bidi-font-family:&quot;Times New Roman&quot;;mso-fareast-language:
       EN-IN'>{txtTE_Skill5.Text}<o:p></o:p></span></li>
                            <li class='MsoNormal' style='color:black;margin-right:56.7pt;margin-bottom:
       5.0pt;line-height:normal;mso-list:l1 level1 lfo2;vertical-align:baseline'><span lang='EN-IN' style='font-family:&quot;PT Serif&quot;,serif;mso-fareast-font-family:
       &quot;Times New Roman&quot;;mso-bidi-font-family:&quot;Times New Roman&quot;;mso-fareast-language:
       EN-IN'>{txtTE_Skill6.Text}<o:p></o:p></span></li>
                        </ul>
                    </td>
                </tr>
                <tr style='mso-yfti-irow:11;height:87.15pt'>
                    <td colspan='2' style='width:559.7pt;padding:0in 5.4pt 0in 5.4pt;
  height:87.15pt' valign='top' width='746'>
                        <p class='MsoNormal' style='margin-bottom:0in;line-height:normal'>
                            <b><span lang='EN-IN' style='font-family:&quot;PT Serif&quot;,serif;mso-fareast-font-family:&quot;Times New Roman&quot;;
  mso-bidi-font-family:&quot;Times New Roman&quot;;color:#AE624F;mso-fareast-language:
  EN-IN'>Customer Service<o:p></o:p></span></b></p>
                        <p class='MsoNormal' style='margin-bottom:0in;line-height:normal'>
                            <b><span lang='EN-IN' style='font-family:&quot;PT Serif&quot;,serif;mso-fareast-font-family:&quot;Times New Roman&quot;;
  mso-bidi-font-family:&quot;Times New Roman&quot;;color:#AE624F;mso-fareast-language:
  EN-IN'><o:p>&nbsp;</o:p></span></b></p>
                        <ul style='margin-top:0in' type='disc'>
                            <li class='MsoNormal' style='color:black;margin-right:56.7pt;margin-bottom:
       5.0pt;line-height:normal;mso-list:l1 level1 lfo2;vertical-align:baseline'><span lang='EN-IN' style='font-family:&quot;PT Serif&quot;,serif;mso-fareast-font-family:
       &quot;Times New Roman&quot;;mso-bidi-font-family:&quot;Times New Roman&quot;;mso-fareast-language:
       EN-IN'>{txtTE_Skill7.Text}<o:p></o:p></span></li>
                            <li class='MsoNormal' style='color:black;margin-right:56.7pt;margin-bottom:
       5.0pt;line-height:normal;mso-list:l1 level1 lfo2;vertical-align:baseline'><span lang='EN-IN' style='font-family:&quot;PT Serif&quot;,serif;mso-fareast-font-family:
       &quot;Times New Roman&quot;;mso-bidi-font-family:&quot;Times New Roman&quot;;mso-fareast-language:
       EN-IN'>{txtTE_Skill8.Text}<o:p></o:p></span></li>
                            <li class='MsoNormal' style='color:black;margin-right:56.7pt;margin-bottom:
       5.0pt;line-height:normal;mso-list:l1 level1 lfo2;vertical-align:baseline'><span lang='EN-IN' style='font-family:&quot;PT Serif&quot;,serif;mso-fareast-font-family:
       &quot;Times New Roman&quot;;mso-bidi-font-family:&quot;Times New Roman&quot;;mso-fareast-language:
       EN-IN'>{txtTE_Skill9.Text}<o:p></o:p></span></li>
                        </ul>
                    </td>
                </tr>
                <tr style='mso-yfti-irow:12;height:3.4pt'>
                    <td colspan='2' style='width:559.7pt;padding:0in 5.4pt 0in 5.4pt;
  height:3.4pt' valign='top' width='746'>
                        <p class='MsoNormal' style='margin-bottom:0in;line-height:normal'>
                            <span lang='EN-IN' style='font-size:10.0pt;font-family:&quot;PT Serif&quot;,serif;mso-bidi-font-family:
  Arimo'><o:p>&nbsp;</o:p></span></p>
                    </td>
                </tr>
                <tr style='mso-yfti-irow:13'>
                    <td colspan='2' style='width:559.7pt;padding:0in 5.4pt 0in 5.4pt' valign='top' width='746'>
                        <p class='MsoNormal' style='margin-bottom:0in;line-height:normal'>
                            <b><span lang='EN-IN' style='font-size:12.0pt;font-family:&quot;PT Serif&quot;,serif;color:#AE624F;
  letter-spacing:1.0pt'>Education</span><span lang='EN-IN' style='font-size:12.0pt;font-family:&quot;PT Serif&quot;,serif;mso-bidi-font-family:
  Arimo'><o:p></o:p></span></b></p>
                    </td>
                </tr>
                <tr style='mso-yfti-irow:14'>
                    <td colspan='2' style='width:559.7pt;padding:0in 5.4pt 0in 5.4pt' valign='top' width='746'>
                        <p class='MsoNormal' style='margin-bottom:0in;line-height:normal'>
                            <b><span lang='EN-IN' style='font-size:9.0pt;font-family:&quot;PT Serif&quot;,serif;color:black;
  letter-spacing:1.0pt'><o:p>&nbsp;</o:p></span></b></p>
                    </td>
                </tr>
                <tr style='mso-yfti-irow:15'>
                    <td style='width:410.85pt;padding:0in 5.4pt 0in 5.4pt' valign='top' width='548'>
                        <p style='margin:0in'>
                            <b><span lang='EN-IN' style='font-size:11.0pt;font-family:
  &quot;PT Serif&quot;,serif;color:black'>{txtTE_Degree}</span></b><span lang='EN-IN' style='font-size:11.0pt;font-family:&quot;PT Serif&quot;,serif;color:black'>,<b> </b>{txtTE_GradDate.Text}</span><b><span lang='EN-IN' style='font-size:11.0pt;font-family:
  &quot;PT Serif&quot;,serif'><o:p></o:p></span></b></p>
                        <p style='margin:0in'>
                            <i><span lang='EN-IN' style='font-size:11.0pt;font-family:
  &quot;PT Serif&quot;,serif;color:black'>{txtTE_GPA.Text}<o:p></o:p></span></i></p>
                        <p style='margin:0in'>
                            <span lang='EN-IN' style='font-size:11.0pt;font-family:
  &quot;PT Serif&quot;,serif;color:black'>{txtTE_School.Text}, {txtTE_SchoolCity.Text}<o:p></o:p></span></p>
                        <p style='margin:0in'>
                            <span lang='EN-IN' style='font-size:11.0pt;font-family:
  &quot;PT Serif&quot;,serif'><o:p>&nbsp;</o:p></span></p>
                        <p style='margin:0in'>
                            <b><span lang='EN-IN' style='font-size:11.0pt;font-family:
  &quot;PT Serif&quot;,serif'>Extracurricular Activities<o:p></o:p></span></b></p>
                        <p style='margin:0in'>
                            <span lang='EN-IN' style='font-size:11.0pt;font-family:
  &quot;PT Serif&quot;,serif'><o:p>&nbsp;</o:p></span></p>
                        <p style='margin-top:0in;margin-right:0in;margin-bottom:0in;margin-left:.5in;
  text-indent:-.25in;mso-list:l2 level1 lfo3'>
                            <![if !supportLists]><span lang='EN-IN' style='font-size:11.0pt;font-family:Symbol;mso-fareast-font-family:
  Symbol;mso-bidi-font-family:Symbol'><span style='mso-list:Ignore'>·<span style='font:7.0pt &quot;Times New Roman&quot;'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span></span><![endif]><i><span lang='EN-IN' style='font-size:11.0pt;
  font-family:&quot;PT Serif&quot;,serif'>{txtTE_Extracaricular1.Text}</span></i><span lang='EN-IN' style='font-size:11.0pt;font-family:&quot;PT Serif&quot;,serif'>: {txtTE_Extracaricular1Detail.Text}<o:p></o:p></span></p>
                        <p style='margin-top:0in;margin-right:0in;margin-bottom:0in;margin-left:.5in;
  text-indent:-.25in;mso-list:l2 level1 lfo3'>
                            <![if !supportLists]><span lang='EN-IN' style='font-size:11.0pt;font-family:Symbol;mso-fareast-font-family:
  Symbol;mso-bidi-font-family:Symbol'><span style='mso-list:Ignore'>·<span style='font:7.0pt &quot;Times New Roman&quot;'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span></span><![endif]><i><span lang='EN-IN' style='font-size:11.0pt;
  font-family:&quot;PT Serif&quot;,serif'>{txtTE_Extracaricular2.Text}</span></i><span lang='EN-IN' style='font-size:11.0pt;font-family:&quot;PT Serif&quot;,serif'>: {txtTE_Extracaricular2Detail.Text}<o:p></o:p></span></p>
                    </td>
                    <td style='width:148.85pt;padding:0in 5.4pt 0in 5.4pt' valign='top' width='198'>
                        <p align='right' style='margin:0in;text-align:right;line-height:150%'>
                            <i><span lang='EN-IN' style='font-size:11.0pt;line-height:150%;font-family:&quot;PT Serif&quot;,serif;
  color:black'><o:p>&nbsp;</o:p></span></i></p>
                    </td>
                </tr>
                <tr style='mso-yfti-irow:16;height:20.05pt'>
                    <td colspan='2' style='width:559.7pt;padding:0in 5.4pt 0in 5.4pt;
  height:20.05pt' valign='top' width='746'>
                        <p class='MsoNormal' style='margin-bottom:0in;line-height:normal'>
                            <b><span lang='EN-IN' style='font-size:10.0pt;font-family:&quot;PT Serif&quot;,serif;color:black;
  letter-spacing:1.0pt'><o:p>&nbsp;</o:p></span></b></p>
                    </td>
                </tr>
                <tr style='mso-yfti-irow:17'>
                    <td colspan='2' style='width:559.7pt;padding:0in 5.4pt 0in 5.4pt' valign='top' width='746'>
                        <p class='MsoNormal' style='margin-bottom:0in;line-height:normal'>
                            <b><span lang='EN-IN' style='font-size:12.0pt;font-family:&quot;PT Serif&quot;,serif;color:#AE624F;
  letter-spacing:1.0pt'>Additional Skills</span><span lang='EN-IN' style='font-size:12.0pt;font-family:&quot;PT Serif&quot;,serif;color:#A50000;
  letter-spacing:1.0pt'><o:p></o:p></span></b></p>
                    </td>
                </tr>
                <tr style='mso-yfti-irow:18'>
                    <td colspan='2' style='width:559.7pt;padding:0in 5.4pt 0in 5.4pt' valign='top' width='746'>
                        <p class='MsoNormal' style='margin-bottom:0in;line-height:normal'>
                            <b><span lang='EN-IN' style='font-size:8.0pt;font-family:&quot;PT Serif&quot;,serif;color:#A50000;
  letter-spacing:1.0pt'><o:p>&nbsp;</o:p></span></b></p>
                    </td>
                </tr>
                <tr style='mso-yfti-irow:19;mso-yfti-lastrow:yes'>
                    <td colspan='2' style='width:559.7pt;padding:0in 5.4pt 0in 5.4pt' valign='top' width='746'>
                        <p style='margin-top:0in;margin-right:56.7pt;margin-bottom:5.0pt;margin-left:
  35.7pt;text-indent:-17.85pt;mso-list:l0 level1 lfo1'>
                            <![if !supportLists]><span lang='EN-IN' style='font-size:11.0pt;font-family:Symbol;mso-fareast-font-family:
  Symbol;mso-bidi-font-family:Symbol'><span style='mso-list:Ignore'>·<span style='font:7.0pt &quot;Times New Roman&quot;'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span></span><![endif]><span lang='EN-IN' style='font-size:11.0pt;
  font-family:&quot;PT Serif&quot;,serif;color:black'>{txtTE_AddSkill1.Text}</span><span lang='EN-IN' style='font-size:11.0pt;
  font-family:&quot;PT Serif&quot;,serif'><o:p></o:p></span></p>
                        <p style='margin-top:0in;margin-right:56.7pt;margin-bottom:5.0pt;margin-left:
  35.7pt;text-indent:-17.85pt;mso-list:l0 level1 lfo1'>
                            <![if !supportLists]><span lang='EN-IN' style='font-size:11.0pt;font-family:Symbol;mso-fareast-font-family:
  Symbol;mso-bidi-font-family:Symbol'><span style='mso-list:Ignore'>·<span style='font:7.0pt &quot;Times New Roman&quot;'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span></span><![endif]><span lang='EN-IN' style='font-size:11.0pt;
  font-family:&quot;PT Serif&quot;,serif;color:black'>{txtTE_AddSkill2.Text}</span><span lang='EN-IN' style='font-size:11.0pt;font-family:&quot;PT Serif&quot;,serif'><o:p></o:p></span></p>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
            ";
               }
               // Katie's "skills" template
               else if (userselection == "4")
               {
                    renderer.RenderingOptions.MarginTop = 12.7;
                    renderer.RenderingOptions.MarginBottom = 12.7;
                    renderer.RenderingOptions.MarginLeft = 12.7;
                    renderer.RenderingOptions.MarginRight = 12.7;
                    html = $@"
<html>

<head>
    <meta http-equiv=Content-Type content='text/html; charset=windows-1252'>
    <meta name=Generator content='Microsoft Word 15 (filtered)'>
    <style>
        <!--
        /* Font Definitions */
        @font-face {{
            font-family: Wingdings;
            panose-1: 5 0 0 0 0 0 0 0 0 0;
        }}

        @font-face {{
            font-family: 'Cambria Math';
            panose-1: 2 4 5 3 5 4 6 3 2 4;
        }}
        @font-face {{
            font-family: Calibri;
            panose-1: 2 15 5 2 2 2 4 3 2 4;
        }}

        @font-face {{
            font-family: Georgia;
            panose-1: 2 4 5 2 5 4 5 2 3 3;
        }}

        @font-face {{
            font-family: Consolas;
            panose-1: 2 11 6 9 2 2 4 3 2 4;
        }}

        @font-face {{
            font-family: 'Segoe UI';
            panose-1: 2 11 5 2 4 2 4 2 2 3;
        }}
        /* Style Definitions */
        p.MsoNormal, li.MsoNormal, div.MsoNormal {{
            margin: 0in;
            font-size: 11.0pt;
            font-family: 'Calibri',sans-serif;
            color: #595959;
        }}

        h1 {{
            mso-style-link: 'Heading 1 Char';
            margin-top: 20.0pt;
            margin-right: 0in;
            margin-bottom: 10.0pt;
            margin-left: 0in;
            page-break-after: avoid;
            font-size: 14.0pt;
            font-family: 'Georgia',serif;
            color: #262626;
            text-transform: uppercase;
            font-weight: bold;
        }}

            h1.CxSpFirst {{
                mso-style-link: 'Heading 1 Char';
                margin-top: 20.0pt;
                margin-right: 0in;
                margin-bottom: 0in;
                margin-left: 0in;
                margin-bottom: .0001pt;
                page-break-after: avoid;
                font-size: 14.0pt;
                font-family: 'Georgia',serif;
                color: #262626;
                text-transform: uppercase;
                font-weight: bold;
            }}

            h1.CxSpMiddle {{
                mso-style-link: 'Heading 1 Char';
                margin: 0in;
                margin-bottom: .0001pt;
                page-break-after: avoid;
                font-size: 14.0pt;
                font-family: 'Georgia',serif;
                color: #262626;
                text-transform: uppercase;
                font-weight: bold;
            }}

            h1.CxSpLast {{
                mso-style-link: 'Heading 1 Char';
                margin-top: 0in;
                margin-right: 0in;
                margin-bottom: 10.0pt;
                margin-left: 0in;
                page-break-after: avoid;
                font-size: 14.0pt;
                font-family: 'Georgia',serif;
                color: #262626;
                text-transform: uppercase;
                font-weight: bold;
            }}

        h2 {{
            mso-style-link: 'Heading 2 Char';
            margin-top: 0in;
            margin-right: 0in;
            margin-bottom: 2.0pt;
            margin-left: 0in;
            font-size: 13.0pt;
            font-family: 'Calibri',sans-serif;
            color: #1D824C;
            text-transform: uppercase;
            font-weight: bold;
        }}

        h3 {{
            mso-style-link: 'Heading 3 Char';
            margin: 0in;
            font-size: 11.0pt;
            font-family: 'Calibri',sans-serif;
            color: #595959;
            text-transform: uppercase;
            font-weight: bold;
        }}

        p.MsoHeader, li.MsoHeader, div.MsoHeader {{
            mso-style-link: 'Header Char';
            margin: 0in;
            font-size: 11.0pt;
            font-family: 'Calibri',sans-serif;
            color: #595959;
        }}

        p.MsoFooter, li.MsoFooter, div.MsoFooter {{
            mso-style-link: 'Footer Char';
            margin: 0in;
            text-align: center;
            font-size: 11.0pt;
            font-family: 'Calibri',sans-serif;
            color: #595959;
        }}

        p.MsoListBullet, li.MsoListBullet, div.MsoListBullet {{
            margin-top: 0in;
            margin-right: 0in;
            margin-bottom: 0in;
            margin-left: .25in;
            text-indent: -.25in;
            font-size: 11.0pt;
            font-family: 'Calibri',sans-serif;
            color: #595959;
        }}

        p.MsoTitle, li.MsoTitle, div.MsoTitle {{
            mso-style-link: 'Title Char';
            margin: 0in;
            text-align: center;
            font-size: 35.0pt;
            font-family: 'Georgia',serif;
            color: #595959;
            text-transform: uppercase;
        }}

        p.MsoTitleCxSpFirst, li.MsoTitleCxSpFirst, div.MsoTitleCxSpFirst {{
            mso-style-link: 'Title Char';
            margin: 0in;
            text-align: center;
            font-size: 35.0pt;
            font-family: 'Georgia',serif;
            color: #595959;
            text-transform: uppercase;
        }}

        p.MsoTitleCxSpMiddle, li.MsoTitleCxSpMiddle, div.MsoTitleCxSpMiddle {{
            mso-style-link: 'Title Char';
            margin: 0in;
            text-align: center;
            font-size: 35.0pt;
            font-family: 'Georgia',serif;
            color: #595959;
            text-transform: uppercase;
        }}

        p.MsoTitleCxSpLast, li.MsoTitleCxSpLast, div.MsoTitleCxSpLast {{
            mso-style-link: 'Title Char';
            margin: 0in;
            text-align: center;
            font-size: 35.0pt;
            font-family: 'Georgia',serif;
            color: #595959;
            text-transform: uppercase;
        }}

        span.MsoIntenseEmphasis {{
            color: #262626;
            font-weight: bold;
        }}

        span.MsoSubtleReference {{
            font-variant: small-caps;
            color: #595959;
            text-transform: none;
            font-weight: bold;
        }}

        span.TitleChar {{
            mso-style-name: 'Title Char';
            mso-style-link: Title;
            font-family: 'Georgia',serif;
            text-transform: uppercase;
        }}

        span.HeaderChar {{
            mso-style-name: 'Header Char';
            mso-style-link: Header;
        }}

        span.FooterChar {{
            mso-style-name: 'Footer Char';
            mso-style-link: Footer;
        }}

        p.ContactInfo, li.ContactInfo, div.ContactInfo {{
            mso-style-name: 'Contact Info';
            margin: 0in;
            text-align: center;
            font-size: 11.0pt;
            font-family: 'Calibri',sans-serif;
            color: #595959;
        }}

        span.Heading1Char {{
            mso-style-name: 'Heading 1 Char';
            mso-style-link: 'Heading 1';
            font-family: 'Georgia',serif;
            color: #262626;
            text-transform: uppercase;
            font-weight: bold;
        }}

        span.Heading2Char {{
            mso-style-name: 'Heading 2 Char';
            mso-style-link: 'Heading 2';
            font-family: 'Times New Roman',serif;
            color: #1D824C;
            text-transform: uppercase;
            font-weight: bold;
        }}

        span.Heading3Char {{
            mso-style-name: 'Heading 3 Char';
            mso-style-link: 'Heading 3';
            font-family: 'Times New Roman',serif;
            text-transform: uppercase;
            font-weight: bold;
        }}

        p.ContactInfoEmphasis, li.ContactInfoEmphasis, div.ContactInfoEmphasis {{
            mso-style-name: 'Contact Info Emphasis';
            margin: 0in;
            text-align: center;
            font-size: 11.0pt;
            font-family: 'Calibri',sans-serif;
            color: #1D824C;
            font-weight: bold;
        }}

        .MsoChpDefault {{
            font-family: 'Calibri',sans-serif;
            color: #595959;
        }}
        /* Page Definitions */
        @page WordSection1 {{
            size: 8.5in 11.0in;
            margin: 47.5pt 1.0in .75in 1.0in;
        }}

        div.WordSection1 {{
            page: WordSection1;
        }}
        /* List Definitions */
        ol {{
            margin-bottom: 0in;
        }}

        ul {{
            margin-bottom: 0in;
        }}
        -->
    </style>

</head>

<body lang=EN-US link='#2C5C85' vlink='#BF4A27' style='word-wrap:break-word'>

    <div class=WordSection1>

        <table class=MsoTableGrid border=0 cellspacing=0 cellpadding=0
               summary='Layout table for name, contact info, and objective' width='100%'
               style='width:100.0%;border-collapse:collapse'>
            <tr style='height:1.25in'>
                <td width=624 valign=top style='width:6.5in;padding:0in 0in 0in 0in;
  height:1.25in'>
                    <p class=MsoTitle>{txtTE_FirstName.Text} <span class=MsoIntenseEmphasis>{txtTE_LastName.Text}</span></p>
                    <p class=ContactInfo>{txtTE_Address.Text}, {txtTE_City.Text}, {txtTE_State.Text} {txtTE_Zip.Text} - {txtTE_PhoneNum.Text}</p>
                    <p class=ContactInfoEmphasis>{txtTE_Email.Text}</p>
                </td>
            </tr>
	<tr>
		<td width=624 valign=top style='width:6.5in;padding:.3in 0in 5.75pt 0in'>
		<p class=MsoNormal>{txtTE_Summary.Text}</p>
		</td>
	</tr>
        </table>

        <h1>Skills</h1>

        <table  border=0 cellspacing=0 cellpadding=0
               summary='Skills layout table' width='100%' style='width:100.0%;border-collapse:
 collapse'>
            <tr>

                <td width=312 valign=top style='width:233.75pt;padding:0in 0in 0in 0in'>

                
                     <ul >
                            <li style='margin:0in;line-height:130%'>{txtTE_Skill1.Text}</li>
                            <li style='margin:0in;line-height:130%;'>{txtTE_Skill2.Text}</li>
                            <li style='margin:0in;line-height:130%;'>{txtTE_Skill3.Text}</li>
                     </ul>

                </td>

                <td width=312 valign=top style='width:233.75pt;padding:0in 0in 0in .25in'>

                     <ul >
                            <li style='margin:0in;line-height:130%'>{txtTE_Skill4.Text}</li>
                            <li style='margin:0in;line-height:130%;'>{txtTE_Skill5.Text}</li>
                     </ul>

                </td>
            </tr>
        </table>

        <h1>Experience</h1>

        <table class=MsoTableGrid border=1 cellspacing=0 cellpadding=0
               summary='Experience layout table' width='99%' style='width:99.5%;margin-left:
 .05in;border-collapse:collapse;border:none'>
            <tr>
                <td width=624 valign=top style='width:467.75pt;border:none;border-left:dotted #BFBFBF 2.25pt;
  padding:0in 0in 0in .4in'>
                    <h3>{txtTE_TimeWorked.Text}</h3>
                    <h2>
                        {txtTE_JobTitle1.Text}, <span class=MsoSubtleReference>
                            <span style='font-variant:normal !important;
  color:windowtext;text-transform:uppercase;font-weight:normal'>{txtTE_Company1.Text}</span>
                        </span>
                    </h2>
                    <p class=MsoNormal>

                     <ul>
                            <li style='margin:0in;line-height:130%'>{txtTE_Job1Responsibilities1.Text}</li>
                            <li style='margin:0in;line-height:130%;'>{txtTE_Job1Responsibilities2.Text}</li>
                            <li style='margin:0in;line-height:130%;'>{txtTE_Job1Responsibilities3.Text}</li>
                     </ul>


                    </p>
                </td>
            </tr>
            <tr>
                <td width=624 valign=top style='width:467.75pt;border:none;border-left:dotted #BFBFBF 2.25pt;
  padding:.15in 0in 0in .4in'>
                    <h3>{txtTE_TimeWorked2.Text}</h3>
                    <h2>
                        {txtTE_JobTitle2.Text}, <span class=MsoSubtleReference>
                            <span style='font-variant:normal !important;
  color:windowtext;text-transform:uppercase;font-weight:normal'>{txtTE_Company2.Text}</span>
                        </span>
                    </h2>
                    <p class=MsoNormalCxSpFirst>

                     <ul >
                            <li style='margin:0in;line-height:130%'>{txtTE_Job2Responsibilities1.Text}</li>
                            <li style='margin:0in;line-height:130%;'>{txtTE_Job2Responsibilities2.Text}</li>
                            <li style='margin:0in;line-height:130%;'>{txtTE_Job2Responsibilities3.Text}</li>
                     </ul>

                    </p>
                </td>
            </tr>
        </table>

        <h1>Education</h1>

        <table class=MsoTableGrid border=1 cellspacing=0 cellpadding=0
               summary='Education layout table' width='99%' style='width:99.5%;margin-left:
 .05in;border-collapse:collapse;border:none'>
            <tr>
                <td width=624 valign=top style='width:467.75pt;border:none;border-left:dotted #BFBFBF 2.25pt;
  padding:0in 0in 0in .4in'>
                    <h3>{txtTE_GradDate.Text}</h3>
                    <h2>
                        {txtTE_Degree.Text}
                    </h2>
                    <h2>
<span class=MsoSubtleReference>
                            <span style='font-variant:
  normal !important;color:windowtext;text-transform:uppercase;font-weight:normal'>{txtTE_School.Text} -  {txtTE_SchoolCity.Text}</span>
                        </span>
                    </h2>
                </td>
            </tr>
        </table>



        <h1>Awards & Certificates</h1>

        <table  border=0 cellspacing=0 cellpadding=0
               summary='Skills layout table' width='100%' style='width:100.0%;border-collapse:
 collapse'>
            <tr>

                <td width=312 valign=top style='width:233.75pt;padding:0in 0in 0in 0in'>

                
                     <ul >
                            <li style='margin:0in;line-height:130%'>{txtTE_AwCert1.Text}</li>
                            <li style='margin:0in;line-height:130%;'>{txtTE_AwCert2.Text}</li>
                            <li style='margin:0in;line-height:130%;'>{txtTE_AwCert3.Text}</li>
                     </ul>

                </td>

            </tr>
        </table>

    </div>

</body>

</html>
";
               }
               // Validate only the controls that are visible

               //string SchoolName = txtTE_School.Text;
               //string SchoolCity = txtTE_SchoolCity.Text;
               //string GraduationDate = txtTE_GradDate.Text;
               //string Degree = txtTE_Degree.Text;
               //string CompanyName = txtTE_Company1.Text;
               //string CompanyCity = txtTE_Company1City.Text;
               //string TimeWorked = txtTE_TimeWorked.Text;
               //string JobTitle = txtTE_JobTitle1.Text;
               //string Responsibilities = txtTE_Responsibilities1.Text;



               //string query1 = "INSERT INTO usereducation (SchoolName, SchoolCity, GraduationDate, Degree)" +
               //    "VALUES (@SchoolName, @SchoolCity, @GraduationDate, @Degree)";
               //string query2 = "INSERT INTO userexperience (CompanyName, CompanyCity, TimeWorked, JobTitle, Responsibilities)" +
               //    "VALUES (@CompanyName, @CompanyCity, @TimeWorked, @JobTitle, @Responisibilities)";

               //string query4 = "SELECT * FROM User WHERE FirstName = @FirstName AND LastName = @LastName AND Email = @Email";

               //using (MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ConnectionString))
               //{

               //     MySqlCommand command = new MySqlCommand(query4, connection);

               //     command.Parameters.AddWithValue("@FirstName", FirstName);
               //     command.Parameters.AddWithValue("@LastName", LastName);
               //     command.Parameters.AddWithValue("@Email", Email);


               //     connection.Open();

               //     MySqlDataReader reader = command.ExecuteReader();

               //     if (reader.HasRows)
               //     {
               //          reader.Close();
               //          MySqlCommand EDU = new MySqlCommand(query1, connection);
               //          MySqlCommand EXP = new MySqlCommand(query2, connection);

               //          EDU.Parameters.AddWithValue("@SchoolName", SchoolName);
               //          EDU.Parameters.AddWithValue("@SchoolCity", SchoolCity);
               //          EDU.Parameters.AddWithValue("@GraduationDate", GraduationDate);
               //          EDU.Parameters.AddWithValue("@Degree", Degree);
               //          EDU.ExecuteNonQuery();

               //          EXP.Parameters.AddWithValue("@CompanyName", CompanyName);
               //          EXP.Parameters.AddWithValue("@CompanyCity", CompanyCity);
               //          EXP.Parameters.AddWithValue("@TimeWorked", TimeWorked);
               //          EXP.Parameters.AddWithValue("@JobTitle", JobTitle);
               //          EXP.Parameters.AddWithValue("@Responsibilities", Responsibilities);
               //          EXP.ExecuteNonQuery();



               //          connection.Close();
               //     }
               //     else
               //     {

               //          reader.Close();
               //          connection.Close();
               //     }
               //}
               
               // have an if statement here using user's template selection (this is serafima's skills resume)
               
               var pdf = renderer.RenderHtmlAsPdf(html);
               Response.ContentType = "application/pdf";
               string filename = string.Format("Resume_{0:yyyyMMddHHmmss}.pdf", DateTime.Now);
               Response.AddHeader("content-disposition", "attachment; filename=" + filename);

               // Write the PDF to the response stream
               Response.BinaryWrite(pdf.BinaryData);
               Response.End();
              
          }

     }


     //protected void btnAddJob_Click(object sender, EventArgs e)
     //{


     //     //Company2.Visible = true;
     //     //JobTitle2.Visible = true;
     //     //Resposobilities2.Visible = true;
     //     //lblTE_Company2.Visible = true;
     //     //txtTE_Company2.Visible = true;
     //     //lblTE_Company2City.Visible = true;
     //     //txtTE_Company2City.Visible = true;
     //     //lblTE_TimeWorked2.Visible = true;
     //     //txtTE_TimeWorked2.Visible = true;
     //     //lblTE_JobTitle2.Visible = true;
     //     //txtTE_JobTitle2.Visible = true;
     //     //lblTE_Responsibilities2.Visible = true;
     //     //txtTE_Responsibilities2.Visible = true;

     //     string CompanyNameD2 = txtTE_Company2.Text;
     //     string CompanyCityD2 = txtTE_Company2City.Text;
     //     string TimeWorkedD2 = txtTE_TimeWorked2.Text;
     //     string JobTitleD2 = txtTE_JobTitle2.Text;
     //     string ResponsibilitiesD2 = txtTE_Responsibilities2.Text;

     //     string query5 = "INSERT INTO userexperience (CompanyName, CompanyCity, TimeWorked, JobTitle, Responsibilities)" +
     //             "VALUES (@CompanyName, @CompanyCity, @TimeWorked, @JobTitle, @Responisibilities)";

     //     using (MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ConnectionString))
     //     {
     //          MySqlCommand EXP2 = new MySqlCommand(query5, connection);
     //          connection.Open();
     //          EXP2.Parameters.AddWithValue("@CompanyName", CompanyNameD2);
     //          EXP2.Parameters.AddWithValue("@CompanyCity", CompanyCityD2);
     //          EXP2.Parameters.AddWithValue("@TimeWorked", TimeWorkedD2);
     //          EXP2.Parameters.AddWithValue("@JobTitle", JobTitleD2);
     //          EXP2.Parameters.AddWithValue("@Responsibilities", ResponsibilitiesD2);
     //          EXP2.ExecuteNonQuery();
     //          connection.Close();
     //     }

     //}

     //protected void btnAddSkillsOptions_Click(object sender, EventArgs e)
     //{
     //     AdditionalSkills.Visible = true;

     //     string query3 = "INSERT INTO skills (Skill) VALUES (@Skill)";
     //     string Skill = txtTE_Skills.Text;

     //     using (MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ConnectionString))
     //     {

     //          MySqlCommand SKI = new MySqlCommand(query3, connection);
     //          connection.Open();

     //          SKI.Parameters.AddWithValue("@Skill", Skill);
     //          SKI.ExecuteNonQuery();
     //          connection.Close();
     //     }
     //}

}