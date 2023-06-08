<%@ Page Title="" Async="true" Language="C#" MasterPageFile="~/HomeDemo.Master" AutoEventWireup="true" CodeBehind="PasswordRecovery.aspx.cs" Inherits="Test.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div class="container">
        <div class="row">
            <div class="col-md-8 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3 class="card-title">Password Recovery</h3>
                                </center>

                                <p class="card-text">Input the email assossiated with your account. We will send a link to this email with further instuctions for recovering your account.</p>
                           
                            </div>
                       
                        <center>
                            <hr />

                        </center>    
                        <div class="d-grid gap-2">
                                <asp:TextBox ID="txtEmailPassword" runat="server" TextMode="Email" placeholder="Email assossiated with your account"></asp:TextBox>
                                <center>
                                    <hr />
                                </center>
                              
                        </div>        
                            <div class="d-grid gap-2" runat="server">
                               <asp:Button class="btn btn-primary" id="btnResetPassword" style="background-color:#a29bfe;border-color:#a29bfe;" runat="server" Text="Reset Password"/>
                            </div>

                        </div>



                    </div><!--card-body-->
                </div><!--card-->

                <!--Back to Login Page-->
                <a style="color: #a29bfe;" href="UserLogin.aspx" ><< Back to Login Page</a><br><br />
                
            </div><!--col-->
        </div><!--row-->
    </div><!--container-->


</asp:Content>
