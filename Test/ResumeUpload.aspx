<%@ Page Title="" Language="C#" MasterPageFile="~/HomeDemo.Master" AutoEventWireup="true" CodeBehind="ResumeUpload.aspx.cs" Inherits="Test.WebForm5"  %>
<%@ Import Namespace="System.IO" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div class ="container">
        <div class ="row">
            <div class="col-md-6 mx-auto">
                <div class="card">
                    <div class ="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img class="card-img-top" src="img/logo.png" style="width: 128px;height: 128px;" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3 class="card-title">Resume Grader</h3>
                                    <p class="card-text">Welcome to the resume grader, where you can upload your own resume as a PDF file and receive a grade for it based on spelling errors, the inclusion of appropriate sections, the number of buzzwords, and the number of pages. Try it out below!</p>
                                    <asp:FileUpload ID="fileUpload1" runat="server" accept=".pdf" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <hr />
                                </center>
                            </div>
                        </div>
                        <div class="d-grid gap-2">
                            <asp:Button class="btn btn-primary" id="btnCalculateGrade" style="background-color:#a29bfe;border-color:#a29bfe;" runat="server" Text="Calculate Grade" OnClick="btnCalculateGrade_Click"/>
                            <asp:Label ID="UploadStatusLabel" runat="server" Text=""/>
                            <% if (fileUpload1.HasFile && Path.GetExtension(fileUpload1.FileName).Equals(".pdf", StringComparison.OrdinalIgnoreCase)) { %>
                                <div class="d-grid gap-2">
                                <asp:Label ID="lblNumPages" runat="server" Text="Number of Pages:"/>
                                <asp:Label ID="lblSearchPhraseCount" runat="server" Text="Spelling Errors:"/>
                                <asp:Label ID="lblBuzzwords" runat="server" Text="Number of Buzzwords:"/>
                                <asp:Label ID="lblErrorCount" runat="server" Text="Number of errors:" />
                                <asp:Label ID="lblError" runat="server" Text="Error:" />
                                <asp:Label ID="lblGrade" runat="server" Text="Grade:" />
                                <asp:Label ID="lblKeyword" runat="server" Text="Search Phrases:" />
                                <asp:Label ID="lblKeywordCount" runat="server" Text="Number of Search Phrases:"/>
                                </div>
                            <% } %>
                        </div>
                    </div>
                </div>
                <a style="color: #a29bfe;" href="Home.aspx" ><< Back to Home Page</a><br><br />
            </div>
        </div>
    </div>
</asp:Content>
