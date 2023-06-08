<%@ Page Title="" Language="C#" MasterPageFile="~/HomeDemo.Master" AutoEventWireup="true" CodeBehind="UserDashBoard.aspx.cs" Inherits="Test.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div class="container" id="Dashboard" runat="server">
        <div class="row" runat="server">
              <div class="col-4" runat="server">
                <div id="UserDashboard" class="list-group" runat="server">
                  <a class="list-group-item list-group-item-action" href="#AccUpdate" style="background-color:#b2bec3;border-color:#dfe6e9">Update Account</a>
                  <a class="list-group-item list-group-item-action" href="#CheckResume" style="background-color:#b2bec3;border-color:#dfe6e9">Check Resumes</a>
                  <a class="list-group-item list-group-item-action" href="#UploadResume" style="background-color:#b2bec3;border-color:#dfe6e9">Upload Resume</a>
                </div>
              </div>

            <div class="col-8" runat="server">
                <div data-bs-spy="scroll" data-bs-target="#UserDashboard" data-bs-smooth-scroll="true" class="scrollspy-example" tabindex="0" runat="server">
                 <!--Account Update-->  
                    <div class="card"  id="AccUpdate" runat="server">                 
                        <div class ="card-body" runat="server">
                            <h4 class="card-text" runat="server">Update Account</h4>
                            <!--Full Name and Date of Birth-->
                            <div class="row" runat="server">
                                <div class="col-md-6" runat="server">
                                   
                                        <label>Full Name</label>
                                        <asp:TextBox CssClass="form-control" ID="txtUD_FullName" runat="server" placeholder="Full Name" ReadOnly="True"></asp:TextBox>
                                   
                               </div>
                                                                                        
                                <div class="col-md-6" runat="server">
                                   
                                        <label>Date of Birth</label>
                                        <asp:TextBox CssClass="form-control" ID="txtUD_DateOfBirth" runat="server" placeholder="Date of Birth" TextMode="Date" ReadOnly="True"></asp:TextBox>

                               </div>
     
                            </div>

                            <!--Contact Number and Email-->
                            <div class="row" runat="server">
                                <div class="col-md-6" runat="server">
                                   
                                        <label>Contact Number</label>
                                        <asp:TextBox CssClass="form-control" ID="txtUD_ContactNum" runat="server" placeholder="Contact Number" TextMode="Phone" ReadOnly="True"></asp:TextBox>
                                   
                               </div>
                                                                                        
                                <div class="col-md-6" runat="server">
                                   
                                        <label>Email</label>
                                        <asp:TextBox CssClass="form-control" ID="txtUD_Email" runat="server" placeholder="Email" TextMode="Email" ReadOnly="True"></asp:TextBox>

                                </div>
     
                                                      
                            </div>

                            <div class="row" runat="server">
                                <div class="col" runat="server">
                                    <hr />
                                </div>
                            </div>

                            <!--State City ZipCode-->
                            <div class="row" runat="server">
                                <div class="col-md-4" runat="server">
                                   
                                        <label>State</label>
                                         <asp:DropDownList class="form-control" ID="ddlUD_State" runat="server">
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
                                   
                                </div>
                                                                                        
                                <div class="col-md-4" runat="server">
                                   
                                        <label>City</label>
                                        <asp:TextBox class="form-control" ID="txtUD_City" runat="server" placeholder="City" TextMode="SingleLine" ReadOnly="True"></asp:TextBox>

                                </div>
                                <div class="col-md-4" runat="server">
                                   
                                        <label>Zip Code</label>
                                        <asp:TextBox class="form-control" ID="txtUD_ZipCode" runat="server" placeholder="Zip Code" TextMode="Number" ReadOnly="True"></asp:TextBox>

                                </div>
     
                            </div>

                            <!--Address-->
                            <div class="row" runat="server">
                                <div class="col" runat="server">
                                    <label>Street</label>
                                    <asp:TextBox CssClass="form-control" ID="txtUD_Street" runat="server" placeholder="Street" TextMode="MultiLine" Rows="2" ReadOnly="True"></asp:TextBox>
                                </div>
                            </div>

                            <div class="row" runat="server">
                                <div class="col" runat="server">
                                    <hr />
                                    <center>
                                        <span class ="badge text-bg-light">Update Password</span>
                                    </center>
                                </div>
                            </div>

                            <!-- Update Login Credentials-->
                            <div class="row" runat="server">

                                <div class="col-md-4" runat="server">
                                    <label">User ID</label>
                                    <asp:TextBox class="form-control" ID="txtUD_UserID" runat="server" placeholder="User ID" ReadOnly="True"></asp:TextBox>
                                </div>
                                <div class="col-md-4" runat="server">
                                    <label >Old Password</label>
                                    <asp:TextBox class="form-control" ID="txtUD_OldPassword" runat="server" placeholder="Password" TextMode="Password" ReadOnly="True"></asp:TextBox>
                                    
                                </div>
                                <div class="col-md-4" runat="server">
                                    <label >New Password</label>
                                    <asp:TextBox class="form-control" ID="txtUD_NewPassword" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                                    <asp:RegularExpressionValidator class ="badge text-bg-danger" ID="revNewPassword" runat="server" ErrorMessage="Minimum of 8 characters, has at least one digit, one uppercase letter, and one lowercase letter!" ControlToValidate="txtUD_NewPassword" Display="Dynamic" ValidationExpression="^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}$" ValidationGroup="Password_Update"></asp:RegularExpressionValidator>
                                </div>

                             </div>

                             <div class="row" runat="server">
                                <div class="col" runat="server">
                                    <hr />
                                </div>
                            </div>

                            <!--Update Account Button-->
                            <div class="d-grid gap-2" runat="server">
                                    <asp:Button class="btn btn-primary" runat="server" id="btnUpAcc" style="background-color:#a29bfe;border-color:#a29bfe;" type="button" text="Update Password" ValidationGroup="Password_Update" />                      
                            </div>
                      
                        </div><!--class card-body-->
                    </div> <!--class card-->

               <!--Saved Resume Template-->
                     <br />
                    <div class="card" id="CheckResume" runat="server">
                        <div class="card-body" runat="server">

                            <div class="row" runat="server">
                                <div class="col-md" runat="server">
                                    <h4 class="card-text" runat="server">Check Resumes</h4>
                                    <p class="card-text" runat="server">Here user can see all the saved resumes they worked on the website so far</p>
                                    
                                    <!--Template Placeholder-->
                                    <div class="d-grid gap-2" runat="server">
                                        <div class="carousel carousel-dark slide" runat="server">
                                        </div> <!--carousel-->
                                        <div class="carousel-inner" runat="server">
                                            <div class="carousel-item active" id="SavedTemplate" runat="server">
                                                <img id="templateimage" src="img/chron1.png"  class="d-block w-100" alt="..." runat="server">
                                                <div class="carousel-caption d-none d-md-block" runat="server">
                                                    <asp:Button runat="server" OnClick="btnContinueEdit_Click" type="button" class="btn btn-primary"  id="btnContinueEdit" style="background-color:#a29bfe;border-color:#a29bfe" text="Continue"/>
                                                </div> <!--carousel-caption-->

                                            </div><!--carousel-item-active-->

                                        </div><!--carousel inner-->

                                    </div><!--grid-->




                                     <!-- Button trigger modal -->
                                    <button type="button" runat="server" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#TS_Warning" style="background-color:#a29bfe;border-color:#a29bfe">
                                      Choose Different Template
                                    </button>

                                    <!-- Modal -->
                                    <div class="modal fade" id="TS_Warning" runat="server" data-bs-backdrop="static" data-bs-keyboard="false" tabindex="-1" aria-labelledby="staticBackdropLabel" aria-hidden="true">
                                      <div class="modal-dialog modal-dialog-centered" runat="server">
                                        <div class="modal-content" runat="server">
                                          <div class="modal-header" runat="server">
                                            <h1 class="modal-title fs-5" id="DB_ChooseTemplate" runat="server">Choosing a template</h1>
                                            <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close" runat="server"></button>
                                          </div><!--modal-header-->
                                          <div class="modal-body" runat="server">
                                            <p>Warning! If you choose new template, the saved one will be overwritten.
                                                Are you sure you want to choose a new template?
                                            </p>
                                          </div><!--modal-body-->
                                          <div class="modal-footer" runat="server">
                                            <button type="button" class="btn btn-secondary" data-bs-dismiss="modal" runat="server">Close</button>
                                            <asp:Button runat="server" OnClick="btnDiffTemplate_Click" type="button" class="btn btn-primary"  id="btnDiffTemplate" style="background-color:#a29bfe;border-color:#a29bfe" text="Go to Template Selection"/>
                                          </div><!--modal-footer-->
                                        </div><!--modal-content-->
                                      </div><!--modal-dialog-->
                                    </div><!--modal-->
                                </div><!--row-->
                            </div><!--col-->
                        </div><!--card-body-->
                    </div><!--card-->


               <!--Uploaded Preexisting Resume-->
                     <br />
                    <div class="card" id="UploadResume" runat="server">
                        <div class="card-body" runat="server">

                            <div class="row" runat="server">
                                <div class="col-md" runat="server">
                                    <h4 class="card-text" runat="server">Upload Resume</h4>
                                    <p class="card-text" runat="server">Here user can upload their preexisting resume to their account</p>



                                 <!-- Upload Button -->
                                    <a href="ResumeUpload.aspx" type="button" class="btn btn-primary"  style="background-color:#a29bfe;border-color:#a29bfe" runat="server">
                                      Upload Preexisting Resume
                                    </a>  

                                <!-- Modal -->
                                    <div class="modal fade" id="FU_DashBoard" runat="server" data-bs-backdrop="static" data-bs-keyboard="false" tabindex="-1" aria-labelledby="staticBackdropLabel" aria-hidden="true">
                                      <div class="modal-dialog modal-dialog-centered" runat="server">
                                        <div class="modal-content" runat="server">
                                          <div class="modal-header" runat="server">
                                            <h1 class="modal-title fs-5" id="staticBackdropLabel" runat="server">Choose a File to upload</h1>
                                            <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close" runat="server"></button>
                                          </div><!--modal-header-->
                                          <div class="modal-body" runat="server">
                                              
                                            <asp:FileUpload id="DB_FileUpLoad" runat="server" /> 
                                            <asp:Label ID="FU_Message" runat="server" Text="Label"></asp:Label>


                                          </div><!--modal-body-->
                                          <div class="modal-footer" runat="server">
                                            <button type="button" class="btn btn-secondary" data-bs-dismiss="modal" runat="server">Close</button>
                                            <asp:Button runat="server" OnClick="btnFileUpload_Click" type="button" class="btn btn-primary"  id="Button1" style="background-color:#a29bfe;border-color:#a29bfe" text="Upload"/>
                                          </div><!--modal-footer-->
                                        </div><!--modal-content-->
                                      </div><!--modal-dialog-->
                                    
                                    </div><!--modal-->

                                </div><!--row-->
                            </div><!--col-->
                        </div><!--card-body-->
                    </div><!--card-->
                     <br />
                </div><!--scroll-->
            </div><!--col-8-->
        </div><!--row-->
    </div>
</asp:Content>
