#pragma checksum "C:\Users\User\source\Airport\Airport\Views\Ticket\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "001b4df17f9174d5b3eadc6884d813b12e88200c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ticket_Index), @"mvc.1.0.view", @"/Views/Ticket/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ticket/Index.cshtml", typeof(AspNetCore.Views_Ticket_Index))]
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
#line 1 "C:\Users\User\source\Airport\Airport\Views\_ViewImports.cshtml"
using Airport;

#line default
#line hidden
#line 2 "C:\Users\User\source\Airport\Airport\Views\_ViewImports.cshtml"
using Airport.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"001b4df17f9174d5b3eadc6884d813b12e88200c", @"/Views/Ticket/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b6c70d2029dfa6ce9f7119ddd8513dcddc69204", @"/Views/_ViewImports.cshtml")]
    public class Views_Ticket_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Airport.Models.Ticket>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/views/ticket/index.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\User\source\Airport\Airport\Views\Ticket\Index.cshtml"
  
    ViewData["Title"] = "Flights";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(111, 1329, true);
            WriteLiteral(@"
<section class=""content"">
    <div class=""row"">
        <div class=""col-lg-10"">
            <div class=""box box-primary"">
                <div class=""box-body"">
                    <div class=""row"">
                        <div class=""col-lg-12"" >
                            <table id=""grid"" name=""grid"" class=""table table-striped table-bordered"" >
                                <thead>
                                    <tr>
                                        <th>Departure Date</th>
                                        <th>From</th>
                                        <th>To</th>
                                        <th>User</th>
                                        <th>Seat</th>
                                        <th>Price</th>
                                        <th>Order date</th>
                                        <th width=""40px""></th>
                                    </tr>
                                </thead>
                            </ta");
            WriteLiteral(@"ble>
                        </div>
                    </div>
                </div>

            </div>
        </div>
        <div class=""col-lg-2"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <a class=""btn btn-success"" style=""margin-bottom:10px""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1440, "\"", 1494, 3);
            WriteAttributeValue("", 1450, "ShowPopup(\'", 1450, 11, true);
#line 37 "C:\Users\User\source\Airport\Airport\Views\Ticket\Index.cshtml"
WriteAttributeValue("", 1461, Url.Action("AddEdit","Ticket"), 1461, 31, false);

#line default
#line hidden
            WriteAttributeValue("", 1492, "\')", 1492, 2, true);
            EndWriteAttribute();
            BeginContext(1495, 307, true);
            WriteLiteral(@"><i class=""fa fa-plus""></i> Add New Ticket</a>
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
                BeginContext(1819, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1826, 52, false);
#line 56 "C:\Users\User\source\Airport\Airport\Views\Ticket\Index.cshtml"
Write(await Html.PartialAsync("_ValidationScriptsPartial"));

#line default
#line hidden
                EndContext();
                BeginContext(1878, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1884, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6410cc03abba4052921af6503b02f13c", async() => {
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
                BeginContext(1934, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Airport.Models.Ticket>> Html { get; private set; }
    }
}
#pragma warning restore 1591
