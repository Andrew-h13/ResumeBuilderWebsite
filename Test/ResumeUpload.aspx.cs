using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UglyToad.PdfPig;
using System.Text.RegularExpressions;



namespace Test
{
     public partial class WebForm5 : System.Web.UI.Page
     {
          protected void Page_Load(object sender, EventArgs e)
          {
               if (Session["username"] == null)
               {
                    Response.Redirect("UserLogin.aspx", false);
               }
          }

          protected void btnCalculateGrade_Click(object sender, EventArgs e)
          {
               string savePath = Path.GetTempPath();

               string fileName = Path.GetFileName(fileUpload1.FileName);

               if (fileUpload1.HasFile && Path.GetExtension(fileName).ToLower() == ".pdf")
               {
                    string filePath = Path.Combine(savePath, fileName);
                    fileUpload1.SaveAs(filePath);
                    using (PdfDocument document = PdfDocument.Open(filePath))
                    {
                         int pageCount = document.NumberOfPages;
                         lblNumPages.Text = "Number of pages: " + pageCount.ToString();

                         // Hardcode the search phrases
                         string[] searchPhrases = { "work history", "experience", "academic history", "academic experience", "Education", "educational history", "Skills", "objective" };

                         // Use the spelling object to check the PDF document
                         int errorCount = 0;
                         int keywordCount = 0;
                         int searchPhraseCount = 0;
                         for (int i = 1; i <= document.NumberOfPages; i++)
                         {
                              UglyToad.PdfPig.Content.Page page = document.GetPage(i);

                              string pageText = page.Text;
                              int pageErrorCount = 0;
                              int pageKeywordCount = 0;
                              int pageSearchPhraseCount = 0;
                              foreach (string word in Regex.Split(pageText, @"\s+"))
                              {

                                   // Check for keywords
                                   if (word.ToLower() == "keywords")
                                   {
                                        keywordCount++;
                                        pageKeywordCount++;
                                   }

                                   // Check for search phrases
                                   foreach (string searchPhrase in searchPhrases)
                                   {
                                        if (Regex.IsMatch(pageText.ToLower(), searchPhrase.ToLower()))
                                        {
                                             searchPhraseCount++;
                                             pageSearchPhraseCount++;
                                             break;
                                        }
                                   }
                              }

                              Console.WriteLine("Page {0} has {1} errors, {2} keywords, and {3} search phrases", i, pageErrorCount, pageKeywordCount, pageSearchPhraseCount);

                              // Update error count
                              if (pageErrorCount > 0)
                              {
                                   errorCount++;
                              }

                              // Update search phrase count
                              searchPhraseCount += pageSearchPhraseCount;
                         }

                         // Display keyword count, search phrase count, and error count
                         lblKeywordCount.Text = "Keyword count: " + keywordCount.ToString();
                         lblSearchPhraseCount.Text = "Search phrase count: " + searchPhraseCount.ToString();
                         lblErrorCount.Text = "Error count: " + errorCount.ToString();

                         // Calculate and display grade
                         double grade = CalculateGrade(document, pageCount, errorCount, keywordCount);
                         lblGrade.Text = "Grade: " + grade.ToString("P");

                         File.Delete(filePath);
                    }
               }
               else
               {
                    lblError.Text = "Please select a PDF file to upload.";
               }
          }



          private double CalculateGrade(PdfDocument document, int pageCount, int keywordCount, int phraseCount)
          {
               // Define the search phrases
               string[] searchPhrases = new string[] {
                "work history",
                "experience",
                "academic history",
                "academic experience",
                "education",
                "educational history",
                "skills",
                "objective"
    };

               // Calculate the keyword percentage
               double maxKeywordCount = 10;
               double keywordPercentage = (double)keywordCount / maxKeywordCount;
               keywordPercentage = keywordPercentage > 1 ? 1 : keywordPercentage;

               // Calculate the search phrase percentage
               string pageText = string.Empty;
               for (int i = 1; i <= pageCount; i++)
               {
                    UglyToad.PdfPig.Content.Page page = document.GetPage(i);
                    pageText += page.Text;
               }
               double searchPhrasePercentage = 0;
               double maxSearchPhraseCount = searchPhrases.Length;
               int searchPhraseCount = 0;
               foreach (string searchPhrase in searchPhrases)
               {
                    foreach (Match match in Regex.Matches(pageText.ToLower(), string.Format(@"\b{0}\b", Regex.Escape(searchPhrase.ToLower()))))
                    {
                         searchPhraseCount++;
                    }
               }
               if (searchPhraseCount >= 5)
               {
                    searchPhrasePercentage = 1;
               }
               else
               {
                    searchPhrasePercentage = (double)searchPhraseCount / 5;
               }

               // Calculate the page count percentage
               double maxPages = 2;
               double pageCountPercentage = Math.Max(0, 1 - Math.Abs(maxPages - pageCount) / maxPages);
               if (pageCount > maxPages)
               {
                    pageCountPercentage *= 0.5;
               }

               // Calculate the overall grade
               double keywordWeight = 0.4;
               double phraseWeight = 0.4;
               double pageCountWeight = 0.2;
               double grade = (keywordPercentage * keywordWeight) + (searchPhrasePercentage * phraseWeight) + (pageCountPercentage * pageCountWeight);
               grade = Math.Max(0, grade);
               grade = Math.Min(100, grade);
               return grade;
          }
     }
}
