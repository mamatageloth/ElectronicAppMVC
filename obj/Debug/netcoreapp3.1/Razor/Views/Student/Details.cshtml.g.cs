#pragma checksum "D:\My Doc\Batches\BN4751_ASPNETCORE\ElectronicsAppMVC\Views\Student\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "041e6370df94b3d3a6b882cf3e7b161e839ca12d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Details), @"mvc.1.0.view", @"/Views/Student/Details.cshtml")]
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
#nullable restore
#line 1 "D:\My Doc\Batches\BN4751_ASPNETCORE\ElectronicsAppMVC\Views\_ViewImports.cshtml"
using ElectronicsAppMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\My Doc\Batches\BN4751_ASPNETCORE\ElectronicsAppMVC\Views\_ViewImports.cshtml"
using ElectronicsAppMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"041e6370df94b3d3a6b882cf3e7b161e839ca12d", @"/Views/Student/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f779de3adeeba6a0c5956272ed0717a224b9c00", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ElectronicsAppMVC.Models.Student>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 2 "D:\My Doc\Batches\BN4751_ASPNETCORE\ElectronicsAppMVC\Views\Student\Details.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Student Details</h1>\r\n<table class=\"table table-bordered table-striped table-warning\">\r\n    <tr>\r\n        <th>");
#nullable restore
#line 10 "D:\My Doc\Batches\BN4751_ASPNETCORE\ElectronicsAppMVC\Views\Student\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 11 "D:\My Doc\Batches\BN4751_ASPNETCORE\ElectronicsAppMVC\Views\Student\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 12 "D:\My Doc\Batches\BN4751_ASPNETCORE\ElectronicsAppMVC\Views\Student\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 13 "D:\My Doc\Batches\BN4751_ASPNETCORE\ElectronicsAppMVC\Views\Student\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 14 "D:\My Doc\Batches\BN4751_ASPNETCORE\ElectronicsAppMVC\Views\Student\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 15 "D:\My Doc\Batches\BN4751_ASPNETCORE\ElectronicsAppMVC\Views\Student\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 16 "D:\My Doc\Batches\BN4751_ASPNETCORE\ElectronicsAppMVC\Views\Student\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n    </tr>\r\n");
#nullable restore
#line 18 "D:\My Doc\Batches\BN4751_ASPNETCORE\ElectronicsAppMVC\Views\Student\Details.cshtml"
     foreach (var data in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 21 "D:\My Doc\Batches\BN4751_ASPNETCORE\ElectronicsAppMVC\Views\Student\Details.cshtml"
   Write(Html.DisplayFor(model => data.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 22 "D:\My Doc\Batches\BN4751_ASPNETCORE\ElectronicsAppMVC\Views\Student\Details.cshtml"
   Write(Html.DisplayFor(model => data.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 23 "D:\My Doc\Batches\BN4751_ASPNETCORE\ElectronicsAppMVC\Views\Student\Details.cshtml"
   Write(Html.DisplayFor(model => data.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 24 "D:\My Doc\Batches\BN4751_ASPNETCORE\ElectronicsAppMVC\Views\Student\Details.cshtml"
   Write(Html.DisplayFor(model => data.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 25 "D:\My Doc\Batches\BN4751_ASPNETCORE\ElectronicsAppMVC\Views\Student\Details.cshtml"
   Write(Html.DisplayFor(model => data.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 26 "D:\My Doc\Batches\BN4751_ASPNETCORE\ElectronicsAppMVC\Views\Student\Details.cshtml"
   Write(Html.DisplayFor(model => data.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "041e6370df94b3d3a6b882cf3e7b161e839ca12d7285", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1075, "~/Student/", 1075, 10, true);
#nullable restore
#line 27 "D:\My Doc\Batches\BN4751_ASPNETCORE\ElectronicsAppMVC\Views\Student\Details.cshtml"
AddHtmlAttributeValue("", 1085, Html.DisplayFor(model=>data.Image), 1085, 35, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n</tr>\r\n");
#nullable restore
#line 29 "D:\My Doc\Batches\BN4751_ASPNETCORE\ElectronicsAppMVC\Views\Student\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ElectronicsAppMVC.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
