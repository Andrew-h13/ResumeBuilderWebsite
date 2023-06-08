<%@ Page Title="" Language="C#" MasterPageFile="~/HomeDemo.Master" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="Test.UserLogin" %>
<%@ MasterType VirtualPath="~/HomeDemo.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <br />
    <div class ="container" runat="server">
    
            <div class ="row" runat="server">
                <div class="col-md-6 mx-auto" runat="server">
                    <div class="card" runat="server">
                       <!-- <center>
                            <img class="card-img-top" src="img/logo.png" style="width: 128px;height: 128px;" />
                            <h3 class="card-title">User Login</h3>
                        </center>    -->                    
                        <div class ="card-body" runat="server">

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
                                    <h3 class="card-title">User Login</h3>
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
                                    
                                    <label>Username</label>
                                    
                                    <asp:TextBox CssClass="form-control" ID="txtUsername" runat="server" placeholder="Username"></asp:TextBox>
                                    <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvUsername" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtUsername" ValidationGroup="User_Login"></asp:RequiredFieldValidator>

                                    <label >Password</label>
                                   
                                    <asp:TextBox CssClass="form-control" ID="txtPassword" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                                    <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvPassword" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtPassword" ValidationGroup="User_Login"></asp:RequiredFieldValidator>
                                    <a class ="badge text-bg-light" href="PasswordRecovery.aspx" runat="server">Forgot Password</a>
                                    <center>
                                        <hr />
                                    </center>


                             </div>
                             <div class="d-grid gap-2" runat="server">
                                    <asp:Label class ="badge text-bg-danger" ID="loginError" runat="server" Visible="false">Login failed - incorrect username/password!</asp:Label>
                                    <asp:Button class="btn btn-primary" id="btnLogIn" style="background-color:#a29bfe;border-color:#a29bfe;" runat="server" Text="Log In" OnClick="btnLogIn_Click" />

                                    <a class="btn btn-info" href="CreateAccount.aspx" id="btnCrAcc" style="background-color:#dfe6e9;border-color:#dfe6e9;" type="button">Create Account</a>
                             </div>
                      
                        </div>

                    </div>
                
                <a style="color: #a29bfe;" href="Home.aspx" ><< Back to Home Page</a><br><br />
                </div>
            </div>

    </div>

</asp:Content>
