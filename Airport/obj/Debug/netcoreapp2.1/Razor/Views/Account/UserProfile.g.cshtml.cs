#pragma checksum "D:\University\6semestr\Airport\Airport\Views\Account\UserProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "456056e4816fe7e1e88f1807badd7b8440d2e8c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_UserProfile), @"mvc.1.0.view", @"/Views/Account/UserProfile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/UserProfile.cshtml", typeof(AspNetCore.Views_Account_UserProfile))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\University\6semestr\Airport\Airport\Views\_ViewImports.cshtml"
using Airport;

#line default
#line hidden
#line 2 "D:\University\6semestr\Airport\Airport\Views\_ViewImports.cshtml"
using Airport.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"456056e4816fe7e1e88f1807badd7b8440d2e8c9", @"/Views/Account/UserProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b6c70d2029dfa6ce9f7119ddd8513dcddc69204", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_UserProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Airport.Models.ApplicationUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/views/user/userprofile.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\University\6semestr\Airport\Airport\Views\Account\UserProfile.cshtml"
  
    ViewData["Title"] = "User Profile";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(185, 297, true);
            WriteLiteral(@"
<!-- Main content -->
<section class=""content"">
    <div class=""row"">
        <div class=""col-md-3"">
            <div class=""box box-primary"">
                <div class=""box-body box-profile"">
                    <img id=""profilePicture"" class=""profile-user-img img-responsive img-circle""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 482, "\"", 515, 2);
            WriteAttributeValue("", 488, "../", 488, 3, true);
#line 14 "D:\University\6semestr\Airport\Airport\Views\Account\UserProfile.cshtml"
WriteAttributeValue("", 491, Model.ProfilePictureUrl, 491, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(516, 122, true);
            WriteLiteral(" alt=\"User profile picture\">\r\n                    <h3 class=\"profile-username text-center\"><span class=\"profile-fullName\">");
            EndContext();
            BeginContext(639, 14, false);
#line 15 "D:\University\6semestr\Airport\Airport\Views\Account\UserProfile.cshtml"
                                                                                       Write(Model.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(653, 899, true);
            WriteLiteral(@"</span></h3>
                    <p class=""text-muted text-center"">Active Member</p>

                    <ul class=""list-group list-group-unbordered"">
                        <li class=""list-group-item text-center"">
                            <span class=""btn btn-success fileinput-button"">
                                <i class=""fa fa-camera bg-green""></i>
                                <span>Select file ...</span>
                                <input id=""fileupload"" type=""file"" name=""files"" multiple="""">
                            </span>

                        </li>
                        <li class=""list-group-item"">
                            <div id=""progress"" class=""progress"">
                                <div class=""progress-bar progress-bar-success""></div>
                            </div>
                        </li>

                    </ul>
");
            EndContext();
#line 34 "D:\University\6semestr\Airport\Airport\Views\Account\UserProfile.cshtml"
                     if (Model.IsUser)
                    {
                        //<a href="@Airport.MVC.Pages.TicketCustomer.FullUrl?cust=@customerId" class="btn btn-primary btn-block"><b><i class="fa fa-building"></i> Tickets</b></a>
                    }

#line default
#line hidden
            BeginContext(1818, 916, true);
            WriteLiteral(@"                </div>
            </div>
        </div>

        <div class=""col-md-9"">
            <div class=""nav-tabs-custom"">
                <ul class=""nav nav-tabs"">

                    <li class=""active""><a href=""#editProfile"" data-toggle=""tab"">Edit Profile</a></li>
                    <li><a href=""#changePassword"" data-toggle=""tab"">Change Password</a></li>
                </ul>
                <div class=""tab-content"">

                    <div class=""active tab-pane"" id=""editProfile"">
                        <div class=""small-box bg-green"">
                            <div class=""inner"">
                                <h4>Change Your Personal Profile Data</h4>

                            </div>
                            <div class=""icon"">
                                <i class=""ion ion-person""></i>
                            </div>

                            <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2734, "\"", 2797, 3);
            WriteAttributeValue("", 2744, "ShowPopup(\'", 2744, 11, true);
#line 61 "D:\University\6semestr\Airport\Airport\Views\Account\UserProfile.cshtml"
WriteAttributeValue("", 2755, Url.Action("PersonalProfile","Account"), 2755, 40, false);

#line default
#line hidden
            WriteAttributeValue("", 2795, "\')", 2795, 2, true);
            EndWriteAttribute();
            BeginContext(2798, 660, true);
            WriteLiteral(@" class=""btn small-box-footer"">Open Personal Profile Form <i class=""fa fa-gear""></i></a>
                        </div>
                    </div>
                    <!-- /.tab-pane -->
                    <div class=""tab-pane"" id=""changePassword"">
                        <div class=""small-box bg-green"">
                            <div class=""inner"">
                                <h4>Change Old Password With The New Password</h4>

                            </div>
                            <div class=""icon"">
                                <i class=""ion ion-key""></i>
                            </div>

                            <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3458, "\"", 3519, 3);
            WriteAttributeValue("", 3468, "ShowPopup(\'", 3468, 11, true);
#line 75 "D:\University\6semestr\Airport\Airport\Views\Account\UserProfile.cshtml"
WriteAttributeValue("", 3479, Url.Action("ChangePassword","Manage"), 3479, 38, false);

#line default
#line hidden
            WriteAttributeValue("", 3517, "\')", 3517, 2, true);
            EndWriteAttribute();
            BeginContext(3520, 401, true);
            WriteLiteral(@" class=""btn small-box-footer"">Open Change Password Form <i class=""fa fa-gear""></i></a>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<div class=""modal modal-primary fade"" id=""modalDefault"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">

        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3938, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3945, 52, false);
#line 93 "D:\University\6semestr\Airport\Airport\Views\Account\UserProfile.cshtml"
Write(await Html.PartialAsync("_ValidationScriptsPartial"));

#line default
#line hidden
                EndContext();
                BeginContext(3997, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(4005, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3eb22daf7481485680665b76f09d221e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4059, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Airport.Data.ApplicationDbContext Context { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Airport.Models.ApplicationUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
