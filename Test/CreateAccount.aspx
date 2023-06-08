<%@ Page Title="" Language="C#" MasterPageFile="~/HomeDemo.Master" AutoEventWireup="true" CodeBehind="CreateAccount.aspx.cs" Inherits="Test.AccCreation" %>
<%@ MasterType VirtualPath="~/HomeDemo.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div class ="container" runat="server">
    
            <div class ="row" runat="server">
                <div class="col-md-8 mx-auto" runat="server">
                    <div class="card" runat="server">
                 
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
                                    <h3 class="card-title">Create Account</h3>
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
                            <!--Full Name and Date of Birth-->
                            <div class="row">
                                <div class="col-md-6">
                                   
                                        <label">Full Name</label>
                                        <asp:TextBox CssClass="form-control" ID="txtFirstName" runat="server" placeholder="First Name"></asp:TextBox>
                                        <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfv_FirstName" runat="server" ErrorMessage="Required field!" ControlToValidate="txtFirstName" Display="Dynamic" ValidationGroup="Account_Creation"></asp:RequiredFieldValidator> 
                                        <asp:RegularExpressionValidator class ="badge text-bg-danger" ID="revFirstName" runat="server" ErrorMessage="Wrong Format!" ControlToValidate="txtFirstName" Display="Dynamic" ValidationExpression="^[a-zA-Z\u00C0-\u024F'-]{1,255}$" ValidationGroup="Account_Creation"></asp:RegularExpressionValidator>
                                    </div>
                                                                                        
                                <div class="col-md-6">
                                   
                                        <label">Last Name</label>
                                        <asp:TextBox CssClass="form-control" ID="txtLastName" runat="server" placeholder="Last Name"></asp:TextBox>
                                        <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfv_LastName" runat="server" ErrorMessage="Required field!" ControlToValidate="txtLastName" Display="Dynamic" ValidationGroup="Account_Creation"></asp:RequiredFieldValidator> 
                                        <asp:RegularExpressionValidator class ="badge text-bg-danger" ID="revLastName" runat="server" ErrorMessage="Wrong Format!" ControlToValidate="txtLastName" Display="Dynamic" ValidationExpression="^[a-zA-Z\u00C0-\u024F'-]{1,255}$" ValidationGroup="Account_Creation"></asp:RegularExpressionValidator>
                               </div>
     
                            </div>

                            <!--Contact Number and Email-->
                            <div class="row">
                                <div class="col-md-6">
                                   
                                        <label">Phone Number</label>
                                        <asp:TextBox CssClass="form-control" ID="txtPhoneNum" runat="server" placeholder="xxx-xxx-xxxx" TextMode="Phone"></asp:TextBox>
                                        <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvPhoneNum" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtPhoneNum" ValidationGroup="Account_Creation"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator class ="badge text-bg-danger" ID="revPhoneNum" runat="server" ErrorMessage="Wrong Format!" ControlToValidate="txtPhoneNum" Display="Dynamic" ValidationExpression="^\d{3}-\d{3}-\d{4}$" ValidationGroup="Account_Creation"></asp:RegularExpressionValidator>
                                </div>
                                                                                        
                                <div class="col-md-6">
                                   
                                        <label">Email</label>
                                        <asp:TextBox CssClass="form-control" ID="txtEmail" runat="server" placeholder="address@mail.com" TextMode="Email"></asp:TextBox>
                                        <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rvfEmail" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtEmail" ValidationGroup="Account_Creation"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator class ="badge text-bg-danger" ID="revEmail" runat="server" ErrorMessage="Wrong Format!" ControlToValidate="txtEmail" Display="Dynamic" ValidationExpression="^(?=.{5,255}$)\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$" ValidationGroup="Account_Creation"></asp:RegularExpressionValidator>
                                </div>
     
                                                      
                            </div>

                            <div class="row">
                                <div class="col">
                                    <hr />
                                </div>
                            </div>

                            <!--State City ZipCode-->
                                                             <!--Address-->
                            <div class="row">
                                <div class="col">
                                    <label>Street Address</label>
                                    <asp:TextBox CssClass="form-control" ID="txtStreetAddress" runat="server" placeholder="123 Main Street"></asp:TextBox>
                                    <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rvfStreet" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtStreetAddress" ValidationGroup="Account_Creation"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator class ="badge text-bg-danger" ID="revStreet" runat="server" ErrorMessage="Wrong format!" ControlToValidate="txtStreetAddress" Display="Dynamic" ValidationExpression="^(?=.*[a-zA-Z0-9])[a-zA-Z0-9\s.,#-]{1,255}$" ValidationGroup="Account_Creation"></asp:RegularExpressionValidator>
                                </div>
                            </div>
                             <div class="row">
                                <div class="col-md-4">
                                   
                                        <label">State</label>
                                         <asp:DropDownList class="form-control" ID="ddlState" runat="server">
                                            <asp:ListItem Value="">Select</asp:ListItem>
	                                        <asp:ListItem Value="AL">Alabama</asp:ListItem>
	                                        <asp:ListItem Value="AK">Alaska</asp:ListItem>
	                                        <asp:ListItem Value="AZ">Arizona</asp:ListItem>
	                                        <asp:ListItem Value="AR">Arkansas</asp:ListItem>
	                                        <asp:ListItem Value="CA">California</asp:ListItem>
	                                        <asp:ListItem Value="CO">Colorado</asp:ListItem>
	                                        <asp:ListItem Value="CT">Connecticut</asp:ListItem>
	                                        <asp:ListItem Value="DC">District of Columbia</asp:ListItem>
	                                        <asp:ListItem Value="DE">Delaware</asp:ListItem>
	                                        <asp:ListItem Value="FL">Florida</asp:ListItem>
	                                        <asp:ListItem Value="GA">Georgia</asp:ListItem>
	                                        <asp:ListItem Value="HI">Hawaii</asp:ListItem>
	                                        <asp:ListItem Value="ID">Idaho</asp:ListItem>
	                                        <asp:ListItem Value="IL">Illinois</asp:ListItem>
	                                        <asp:ListItem Value="IN">Indiana</asp:ListItem>
	                                        <asp:ListItem Value="IA">Iowa</asp:ListItem>
	                                        <asp:ListItem Value="KS">Kansas</asp:ListItem>
	                                        <asp:ListItem Value="KY">Kentucky</asp:ListItem>
	                                        <asp:ListItem Value="LA">Louisiana</asp:ListItem>
	                                        <asp:ListItem Value="ME">Maine</asp:ListItem>
	                                        <asp:ListItem Value="MD">Maryland</asp:ListItem>
	                                        <asp:ListItem Value="MA">Massachusetts</asp:ListItem>
	                                        <asp:ListItem Value="MI">Michogan</asp:ListItem>
	                                        <asp:ListItem Value="MN">Minnesota</asp:ListItem>
	                                        <asp:ListItem Value="MS">Mississippi</asp:ListItem>
	                                        <asp:ListItem Value="MO">Missouri</asp:ListItem>
	                                        <asp:ListItem Value="MT">Montana</asp:ListItem>
	                                        <asp:ListItem Value="NE">Nebraska</asp:ListItem>
	                                        <asp:ListItem Value="NV">Nevada</asp:ListItem>
	                                        <asp:ListItem Value="NH">New Hampshire</asp:ListItem>
	                                        <asp:ListItem Value="NJ">New Jersey</asp:ListItem>
	                                        <asp:ListItem Value="NM">New Mexico</asp:ListItem>
	                                        <asp:ListItem Value="NY">New York</asp:ListItem>
	                                        <asp:ListItem Value="NC">North Carolina</asp:ListItem>
	                                        <asp:ListItem Value="ND">North Dakota</asp:ListItem>
                                            <asp:ListItem Value="OH">Ohio</asp:ListItem>
	                                        <asp:ListItem Value="OK">Oklahoma</asp:ListItem>
	                                        <asp:ListItem Value="OR">Oregon</asp:ListItem>
	                                        <asp:ListItem Value="PA">Pennsylvania</asp:ListItem>
	                                        <asp:ListItem Value="RI">Rhode Island</asp:ListItem>
	                                        <asp:ListItem Value="SC">South Carolina</asp:ListItem>
	                                        <asp:ListItem Value="SD">South Dakota</asp:ListItem>
	                                        <asp:ListItem Value="TN">Tennessee</asp:ListItem>
	                                        <asp:ListItem Value="TX">Texas</asp:ListItem>
	                                        <asp:ListItem Value="UT">Utah</asp:ListItem>
	                                        <asp:ListItem Value="VT">Vermont</asp:ListItem>
	                                        <asp:ListItem Value="VA">Virginia</asp:ListItem>
	                                        <asp:ListItem Value="WA">Washington</asp:ListItem>
	                                        <asp:ListItem Value="WV">West Virginia</asp:ListItem>
	                                        <asp:ListItem Value="WI">Wisconsin</asp:ListItem>
	                                        <asp:ListItem Value="WY">Wyoming</asp:ListItem>
                                         </asp:DropDownList>

                                    <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvState" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="ddlState" ValidationGroup="Account_Creation"></asp:RequiredFieldValidator>
                                   
                                </div>
                                                                                        
                                <div class="col-md-4">
                                   
                                        <label">City</label>
                                        <asp:TextBox class="form-control" ID="txtCity" runat="server" placeholder="City" TextMode="SingleLine"></asp:TextBox>
                                        <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvCity" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtCity" ValidationGroup="Account_Creation"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-4">
                                   
                                        <label">Zip Code</label>
                                        <asp:TextBox class="form-control" ID="txtZipCode" runat="server" placeholder="xxxxx"></asp:TextBox>
                                        <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvZipCode" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtZipCode" ValidationGroup="Account_Creation"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator class ="badge text-bg-danger" ID="revZipCode" runat="server" ErrorMessage="Wrong Format!" ControlToValidate="txtZipCode" Display="Dynamic" ValidationExpression="^\d{5}$" ValidationGroup="Account_Creation"></asp:RegularExpressionValidator>
                                </div>
     
                            </div>


                            <div class="row">
                                <div class="col">
                                    <hr />
                                    <center>
                                        <span class ="badge text-bg-light">Login Credentials</span>
                                    </center>
                                </div>
                            </div>

                            <!-- Login Credentials-->
                            <div class="row">

                                <div class="col-md-6">
                                    <label">Username</label>
                                    <asp:TextBox class="form-control" ID="txtUsername" runat="server" placeholder="Username"></asp:TextBox>
                                    <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvUserID" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtUsername" ValidationGroup="Account_Creation"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator class ="badge text-bg-danger" ID="revUsername" runat="server" ErrorMessage="Username must be 1-255 characters" ControlToValidate="txtUsername" Display="Dynamic" ValidationExpression="^.{1,255}$" ValidationGroup="Account_Creation"></asp:RegularExpressionValidator>
                                </div>
                                <div class="col-md-6">
                                    <label >Password</label>
                                    <asp:TextBox class="form-control" ID="txtPassword" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                                    <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvPassword" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtPassword" ValidationGroup="Account_Creation"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator class ="badge text-bg-danger" ID="revPassword" runat="server" ErrorMessage="Password must be 8-255 characters and have at least one digit, one uppercase letter, one lowercase letter, and one special digit!" ControlToValidate="txtPassword" Display="Dynamic" ValidationExpression="^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,255}$" ValidationGroup="Account_Creation"></asp:RegularExpressionValidator>
                                </div>

                             </div>

                             <div class="row">
                                <div class="col">
                                    <hr />
                                </div>
                            </div>

                            <!--Create Account Button-->
                            <div class="d-grid gap-2" runat="server">
                                 <asp:Label class ="badge text-bg-danger" ID="accountExistsError" runat="server" Visible="false">An account already exists with that username/email!</asp:Label>
                                    <asp:Button class="btn btn-primary" runat="server" id="btnCrAcc" onClick="btnCrAcc_Click" style="background-color:#a29bfe;border-color:#a29bfe;" type="button" text="Create Account" ValidationGroup="Account_Creation"/>
                             </div>
                          </div>
                        </div><!--class card-body-->
                     <a style="color: #a29bfe;" href="UserLogin.aspx" ><< Back to Login Page</a><br><br />
                    </div> <!--class card-->
               
                    <!--Back to Login Page-->
                
                
                </div>
            </div>

</asp:Content>
