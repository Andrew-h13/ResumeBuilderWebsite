<%@ Page Title="" Language="C#" MaintainScrollPositionOnPostback="true" MasterPageFile="~/HomeDemo.Master" AutoEventWireup="true" CodeBehind="TemplateEditor.aspx.cs" Inherits="Test.TemplateEditor" %>
<%@ MasterType VirtualPath="~/HomeDemo.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
     <div ID="container" class="container" runat="server">
         <div ID="row1" class ="row" runat="server">
                <div ID="col1" class="col-md-8 mx-auto" runat="server">
                    <div ID="card" class="card" runat="server">

                        <div ID="cardBody" class ="card-body" runat="server">
                        
                            
                    <!--Template Editor Header-->        
                            <div ID="titleRow" class="row" runat="server">
                                <div ID="titleColumn" class="col" runat="server">
                                    <center>
                                    <h3 ID="header1" class="card-title" runat="server">Template Editor</h3>
                                    </center>
                                </div>
                            </div>


                            <div ID="contactInfoTitleRow" class="row" runat="server">
                                <div ID="contactInfoTitleColumn" class="col" runat="server">
                                    <hr />
                                    <center>
                                        <span id="contactinfotitle" class ="badge text-bg-light" runat="server">Contact Information</span>
                                    </center>
                                </div>
                            </div>
                    <!--First Name and Last Name-->
                             <div ID="nameInfo" class="row" runat="server">
                                  <div ID="nameInfoColumn1" class="col-md-6" runat="server">
                                <asp:label ID="lblTE_FirstName" runat="server">First Name</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_FirstName" runat="server" placeholder="John"></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_FirstName" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_FirstName" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                                </div>
                                  <div ID="nameInfoColumn2" class="col-md-6" runat="server">
                                  <asp:label ID="lblTE_LastName" runat="server">Last Name</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_LastName" runat="server" placeholder="Doe"></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_LastName" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_LastName" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                                  </div>
                         </div>
                             <div ID="contactInfo" class="row" runat="server">
                            <div ID="phoneColumn" class="col-md-6" runat="server">

                                
                                <asp:label ID="lblTE_PhoneNum" runat="server"> Phone Number</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_PhoneNum" runat="server" placeholder="555-555-5555" TextMode="Phone"></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_PhoneNum" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_PhoneNum" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>

                            </div><!--grid-->


                    
                    <!--Email-->
                            <div ID="emailColumn" class="col-md-6" runat="server">
                                <asp:label ID="lblTE_Email" runat="server">Email</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_Email" runat="server" placeholder="address@mail.com" TextMode="Email"></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_Email" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_Email" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>


                            </div><!--grid-->
                             </div>
                            
                            <div ID="homeAddressTitleRow" class="row" runat="server">
                                <div ID="homeAddressTitleColumn" class="col" runat="server">
                                    <hr />
                                    <center>
                                        <span id="homeaddresstitle" class ="badge text-bg-light" runat="server">Home Address</span>
                                    </center>
                                </div>
                            </div>

                             <div ID="homeAddressRowTitle" class="row" runat="server">
                                <div ID="homeAddressColumn" class="col" runat="server">
                                    <asp:label ID="lblTE_Address" runat="server"> Street Address</asp:label>
                                    <asp:TextBox CssClass="form-control" ID="txtTE_Address" runat="server" placeholder="123 Main Street" ></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_Address" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_Address" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                            </div></div>
                             <div ID="homeAddressRow" class="row" runat="server">
                                <div id="homeCityColumn" class="col-md-4" runat="server">

                                <asp:label id="lblTE_City" runat="server">City</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_City" runat="server" placeholder="Chicago" ></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_City" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_City" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                                </div>

                                <div ID="homeStateColumn" class="col-md-4" runat="server">
                                <asp:label id="lblTE_State" runat="server">State</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_State" runat="server" placeholder="IL" ></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_State" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_State" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator> 
                                </div>
                                                                                        
                                <div id="homeZipColumn" class="col-md-4" runat="server">
                                   
                                <asp:label id="lblTE_Zip" runat="server">Zip Code</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_Zip" runat="server" placeholder="12345" ></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_Zip" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_Zip" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                                </div></div>

                            <div id="summarystatementrow" class="row" runat="server">
                                <div id="summarystatementcolumn" class="col" runat="server">
                                    <hr />
                                    <center>
                                        <span ID="summarystatementtitle" class ="badge text-bg-light" runat="server">Summary Statement</span>
                                    </center>
                                </div>
                            </div>

                            <div Id="summarystatementblock" class="d-grid gap-2" runat="server">
                                <asp:TextBox CssClass="form-control" ID="txtTE_Summary" runat="server" placeholder="Recent Graduate With a BSc in Information Technology and Volunteer Help Desk Experience" ></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_Summary" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_Summary" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                            </div>

                            <div id="objectiveTitleRow" class="row" runat="server">
                                <div id="objectiveTitleColumn" class="col" runat="server">
                                    <hr />
                                    <center>
                                        <span ID="objectiveTitle" class ="badge text-bg-light" runat="server">Objective Statement</span>
                                    </center>
                                </div>
                            </div>
                  <!--Objective-->
                            <div Id="objective" class="d-grid gap-2" runat="server">
                                <asp:TextBox CssClass="form-control" ID="txtTE_Objective" runat="server" TextMode="MultiLine" Rows="4" placeholder="Skilled IT specialist ready to put network security, SQL management, and proven customer service training to the test in the real world. Volunteer help desk problem-solver, eager to take the next step toward an IT management career in JJ Tech’s open IT Specialist position." ></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_Objective" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_Objective" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                            </div>
                            
                             <div id="professionalSkillsTitleRow" class="row" runat="server">
                                <div id="professionalSkillsTitleColumn" class="col" runat="server">
                                    <hr />
                                    <center>
                                        <span id="professionalskillstitle" class ="badge text-bg-light" runat="server">Professional Skills</span>
                                    </center>
                                </div>
                            </div>
                     <!--Skills-->
                            <div id="professionalSkills" class="d-grid gap-2" runat="server">
                                <div runat="server" id="skill1">
                                <asp:label id="skill1label" runat="server">Skill #1</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_Skill1"  runat="server" placeholder="Comfortable using industry-standard security software, like McAfee SIEM and FireEye CMS"></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_Skill1" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_Skill1" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                                </div>
                               <div runat="server" id="skill2">
                                <asp:label id="skill2label" runat="server">Skill #2</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_Skill2"  runat="server" placeholder="Practice debugging with OllyDbg and WinDbg"></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_Skill2" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_Skill2" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                                </div>
                                <div runat="server" id="skill3">
                                <asp:label id="skill3label" runat="server">Skill #3</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_Skill3"  runat="server" placeholder="Fluent in SQL, able to manage large datasets with Microsoft SQL"></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_Skill3" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_Skill3" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                                </div>
                                <div id="skill4" runat="server">
                                <asp:label id="skill4label" runat="server">Skill #4</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_Skill4"  runat="server" placeholder="Troubleshoot and resolve basic hardware/software issues as an IT help desk volunteer"></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_Skill4" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_Skill4" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                                </div>
                                <div runat="server" id="skill5">
                                <asp:label id="skill5label" runat="server">Skill #5</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_Skill5"  runat="server" placeholder="Answer IT-related questions on Reddit by researching to find the most up-to-date solutions"></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_Skill5" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_Skill5" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                                </div>
                                <div runat="server" id="skill6">
                                <asp:label id="skill6label" runat="server">Skill #6</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_Skill6"  runat="server" placeholder="Participated in a collegiate troubleshooting contest, placing 2nd overall"></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_Skill6" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_Skill6" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                                </div>

                                <div runat="server" id="skill7">
                                <asp:label id="skill7label" runat="server">Skill #7</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_Skill7"  runat="server" placeholder="Resolve student tech issues in person and via phone, email, and text message"></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_Skill7" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_Skill7" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                                </div>

                                <div runat="server" id="skill8">
                                <asp:label id="skill8label" runat="server">Skill #8</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_Skill8"  runat="server" placeholder="Outgoing and friendly, regularly hosting meet & greet parties for incoming freshmen"></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_Skill8" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_Skill8" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                                </div>

                                <div runat="server" id="skill9">
                                <asp:label id="skill9label" runat="server">Skill #9</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_Skill9"  runat="server" placeholder="Part-time cashier experience at various fast-food restaurants"></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_Skill9" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_Skill9" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                                </div>

                            </div>
                         <div ID="workExperienceTitleRow" class="row" runat="server">
                                <div ID="workExperienceTitleColumn" class="col" runat="server">
                                    <hr />
                                    <center>
                                        <span ID="workExperienceTitle" class ="badge text-bg-light" runat="server">Work Experience</span>
                                    </center>
                                </div>
                            </div>
                            

                    <div id="job1block" runat="server">
                            <div id="job1info" class="d-grid gap-2" runat="server">
                                <asp:label ID="lblTE_Job1" runat="server" Font-Bold="true" Text="Job #1"></asp:label>
                                <asp:label ID="lblTE_Company1" runat="server">Company Name</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_Company1" runat="server" placeholder="Company" ></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_Company1" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_Company1" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                                
                                <div id="job1location" runat="server">
                                <asp:label ID="lblTE_Company1City" runat="server">Location</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_Company1City" runat="server" placeholder="Company City" ></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_Company1City" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_Company1City" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                                </div>

                                <asp:label ID="lblTE_TimeWorked" runat="server">Time Worked</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_TimeWorked" runat="server" placeholder="Time Worked" ></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_TimeWorked" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_TimeWorked" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                                <asp:label ID="lblTE_JobTitle1" runat="server">Job Title</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_JobTitle1" runat="server" placeholder="Job Title" ></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_JobTitle1" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_JobTitle1" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                                
                                <asp:label ID="lblTE_Job1Responsibilities1" runat="server">Job Duty #1</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_Job1Responsibilities1" runat="server" placeholder="Job Duty"></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_Job1Responsibilities1" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_Job1Responsibilities1" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                                
                                <asp:label ID="lblTE_Job1Responsibilities2" runat="server">Job Duty #2</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_Job1Responsibilities2" runat="server" placeholder="Job Duty"></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_Job1Responsibilities2" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_Job1Responsibilities2" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                            
                            
                                <asp:label ID="lblTE_Job1Responsibilities3" runat="server">Job Duty #3</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_Job1Responsibilities3" runat="server" placeholder="Job Duty"></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_Job1Responsibilities3" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_Job1Responsibilities3" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                            </div>
                    </div>

                    <div id="job2block" runat="server"><br />
                            <div id="job2info" class="d-grid gap-2" runat="server">
                                <asp:label id="job2label" runat="server" Font-Bold="true">Job #2</asp:label>
                                <asp:label ID="lblTE_Company2"  runat="server" >Company Name</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_Company2" runat="server" placeholder="Company" ></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_Company2" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_Company2" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                                
                                <div id ="job2location" runat="server">
                                <asp:label ID="lblTE_Company2City" runat="server" >Location</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_Company2City" runat="server" placeholder="Company City"></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_Company2City" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_Company2City" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                                </div>
                                
                                 <asp:label ID="lblTE_TimeWorked2"  runat="server" >Time Worked</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_TimeWorked2" runat="server" placeholder="Time Worked" ></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_TimeWorked2" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_TimeWorked2" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                                <asp:label ID="lblTE_JobTitle2"  runat="server" >Job Title</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_JobTitle2" runat="server" placeholder="Job Title" ></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_JobTitle2" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_JobTitle2" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                                
                                <asp:label ID="lblTE_Job2Responsibilities1" runat="server">Job Duty #1</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_Job2Responsibilities1" runat="server" placeholder="Job Duty"></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_Job2Responsibilities1" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_Job2Responsibilities1" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                                
                                <asp:label ID="lblTE_Job2Responsibilities2" runat="server">Job Duty #2</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_Job2Responsibilities2" runat="server" placeholder="Job Duty"></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_Job2Responsibilities2" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_Job2Responsibilities2" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>

                                <asp:label ID="lblTE_Job2Responsibilities3" runat="server">Job Duty #3</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_Job2Responsibilities3" runat="server" placeholder="Job Duty"></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_Job2Responsibilities3" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_Job2Responsibilities3" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>

                            </div></div>

                           <div id="job3block" runat="server"><br />
                            <div id="job3info" class="d-grid gap-2" runat="server">
                                <asp:label id="job3label" runat="server" Font-Bold="true">Job #3</asp:label>
                                <asp:label ID="lblTE_Company3"  runat="server" >Company Name</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_Company3" runat="server" placeholder="Company" ></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_Company3" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_Company3" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                                <div id="job3location" runat="server">
                                 <asp:label ID="lblTE_Company3City" runat="server" >Location</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_Company3City" runat="server" placeholder="Company City"></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_Company3City" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_Company3City" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                                </div>
                                <asp:label ID="lblTE_TimeWorked3"  runat="server" >Time Worked</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_Timeworked3" runat="server" placeholder="Time Worked" ></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_TimeWorked3" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_TimeWorked3" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                                <asp:label ID="lblTE_JobTitle3"  runat="server" >Job Title</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_JobTitle3" runat="server" placeholder="Job Title" ></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_JobTitle3" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_JobTitle3" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                                
                                 <asp:label ID="lblTE_Job3Responsibilities1" runat="server">Job Duty #1</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_Job3Responsibilities1" runat="server" placeholder="Job Duty"></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_Job3Responsibilities1" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_Job3Responsibilities1" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                                
                                <asp:label ID="lblTE_Job3Responsibilities2" runat="server">Job Duty #2</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_Job3Responsibilities2" runat="server" placeholder="Job Duty"></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_Job3Responsibilities2" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_Job3Responsibilities2" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>

                                <asp:label ID="lblTE_Job3Responsibilities3" runat="server">Job Duty #3</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_Job3Responsibilities3" runat="server" placeholder="Job Duty"></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_Job3Responsibilities3" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_Job3Responsibilities3" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>


                            </div></div>

                            <div id="educationtitlerow" class="row" runat="server">
                                <div id="educationtitlecolumn" class="col" runat="server">
                                    <hr />
                                    <center>
                                        <span id="educationtitle" class ="badge text-bg-light" runat="server">Education</span>
                                    </center>
                                </div>
                            </div>
                    <!--Education-->
                            <div id="education1block" class="d-grid gap-2" runat="server">
                                <asp:label id="school1label" runat="server" Font-Bold="true">School #1</asp:label>
                                <asp:label ID="lblTE_School" runat="server">School Name</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_School" runat="server" placeholder="School"></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_School" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_School" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                                <div id="school1location" runat="server">
                                <asp:label ID="lblTE_SchoolCity" runat="server" >Location</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_SchoolCity" runat="server" placeholder="School City"></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_SchoolCity" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_SchoolCity" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                                </div>
                                <asp:label ID="lblTE_GradDate" runat="server">Date Graduated</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_GradDate" runat="server" placeholder="May, 2023"></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_GradDate" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_GradDate" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                                
                              <div id="GPAblock" runat="server">
                                <asp:label ID="lblTE_GPA" runat="server">GPA</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_GPA" runat="server" placeholder="GPA: 3.7/4.0"></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_GPA" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_GPA" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                              </div>
                              <div id ="extracurricularsblock" runat="server">
                              <asp:label ID="lblTE_Extracaricular1" runat="server">Extracurricular #1 Title</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_Extracaricular1" runat="server" placeholder="IT help desk volunteer"></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_Extracaricular1" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_Extracaricular1" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>

                               <div id="extracurricular1details" runat="server">
                              <asp:label ID="lblTE_Extracaricular1Detail" runat="server">Extracurricular #1 Description</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_Extracaricular1Detail" runat="server" placeholder="Assisted students with hardware/software repairs and installing/updating firmware and antivirus programs"></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_Extracaricular1Detail" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_Extracaricular1Detail" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                                   </div>
                                   
                              <asp:label ID="lblTE_Extracaricular2" runat="server">Extracurricular #2 Title</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_Extracaricular2" runat="server" placeholder="IT Club president"></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_Extracaricular2" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_Extracaricular2" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                                        
                              <div id="extracurricular2details" runat="server">
                              <asp:label ID="lblTE_Extracaricular2Detail" runat="server">Extracurricular #2 Description</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_Extracaricular2Detail" runat="server" placeholder="Organized meetings and led member recruitment efforts"></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_Extracaricular2Detail" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_Extracaricular2Detail" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                              </div>
                              </div>
                               <div id="degree" runat="server">
                                <asp:label ID="lblTE_Degree" runat="server">Degree</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_Degree" runat="server" placeholder="B.S. Information Technology"></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_Degree" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_Degree" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                              </div>
                           </div>

                           <div id="additionalskillstitlerow" class="row" runat="server">
                                <div id="additionalskillstitlecolumn" class="col" runat="server">
                                    <hr />
                                    <center>
                                        <span id="additionalskillstitle" class ="badge text-bg-light" runat="server">Additional Skills</span>
                                    </center>
                                </div>
                            </div>
                             <!--Additional Skills-->
                            <div id="additionalskillsblock" class="d-grid gap-2" runat="server">
                                <asp:label id="additionalskill1label" runat="server">Skill #1</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_AddSkill1" runat="server" placeholder="Skill"></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_AddSkill1" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_AddSkill1" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                            <asp:label id="additionalskill2label" runat="server">Skill #2</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_AddSkill2" runat="server" placeholder="Skill"></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_AddSkill2" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_AddSkill2" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>

                            </div><!--grid-->
                            
                             <div id="awardsandcertstitlerow" class="row" runat="server">
                                <div id="awardsandcertstitlecolumn" class="col" runat="server">
                                    <hr />
                                    <center>
                                        <span id="awardsandcertstitle" class ="badge text-bg-light" runat="server">Awards & Certifications</span>
                                    </center>
                                </div>
                            </div>
                             <!--Additional Skills-->
                            <div id="awardsandcertsblock" class="d-grid gap-2" runat="server">
                                <asp:label id="awardcert1label" runat="server">Award/Certification #1</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_AwCert1" runat="server" placeholder="Award/Certification"></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_AwCert1" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_AwCert1" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                            
                                <asp:label id="awardcert2label" runat="server">Award/Certification #2</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_AwCert2" runat="server" placeholder="Award/Certification"></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_AwCert2" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_AwCert2" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>
                            
                                <asp:label id="awardcert3label" runat="server">Award/Certification #3</asp:label>
                                <asp:TextBox CssClass="form-control" ID="txtTE_AwCert3" runat="server" placeholder="Award/Certification"></asp:TextBox>
                                <asp:RequiredFieldValidator class ="badge text-bg-danger" ID="rfvTE_AwCert3" runat="server" ErrorMessage="Required field!" Display="Dynamic" ControlToValidate="txtTE_AwCert3" ValidationGroup="Template_Editor"></asp:RequiredFieldValidator>

                            </div><!--grid-->

                        <div id="downloadbuttonrow" class="row" runat="server"><br />
                             <div id="downloadbuttoncolumn" class="d-grid gap-2" runat="server">
                                  <hr />
                                    <center>
                                   <asp:Button ID="btnDownload"  class="btn btn-primary" runat="server" style="background-color:#a29bfe;border-color:#a29bfe;" OnClick="btnDownload_Click" Text="Download Resume" ValidationGroup="Template_Editor" />
                                   </center>
                             </div>
                         </div>
                    </div><!--card--> 
               </div>
                        
                <a id="backbutton" style="color: #a29bfe;" href="TemplateSelection.aspx" ><< Back to Template Selection </a><br><br />
                </div>
              
               </div>

          </div>
</asp:Content>

                

