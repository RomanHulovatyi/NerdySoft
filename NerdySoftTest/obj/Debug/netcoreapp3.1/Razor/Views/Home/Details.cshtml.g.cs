#pragma checksum "D:\Test\NerdySoftTest\NerdySoftTest\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eda5d70247fdd0f584b4411ed54b1b85ec9bfb66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "D:\Test\NerdySoftTest\NerdySoftTest\Views\_ViewImports.cshtml"
using NerdySoftTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Test\NerdySoftTest\NerdySoftTest\Views\_ViewImports.cshtml"
using NerdySoftTest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eda5d70247fdd0f584b4411ed54b1b85ec9bfb66", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93ad25b037b19e43f85be214b24336bdf2317c30", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NerdySoftTest.Models.DetailsView>
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Test\NerdySoftTest\NerdySoftTest\Views\Home\Details.cshtml"
  
        ViewBag.Title = Model.Announcement.Title;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>Announcement ");
#nullable restore
#line 6 "D:\Test\NerdySoftTest\NerdySoftTest\Views\Home\Details.cshtml"
                Write(Model.Announcement.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <div>\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>Description</dt>\r\n            <dd>");
#nullable restore
#line 10 "D:\Test\NerdySoftTest\NerdySoftTest\Views\Home\Details.cshtml"
           Write(Model.Announcement.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n            <dt>Added</dt>\r\n            <dd>");
#nullable restore
#line 13 "D:\Test\NerdySoftTest\NerdySoftTest\Views\Home\Details.cshtml"
           Write(Model.Announcement.DateAdded);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        </dl>\r\n        <tr>\r\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eda5d70247fdd0f584b4411ed54b1b85ec9bfb664231", async() => {
                WriteLiteral("<input type=\"submit\" class=\"btn btn-outline-info\" value=\"Edit\" />");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 429, "~/Home/Edit/", 429, 12, true);
#nullable restore
#line 16 "D:\Test\NerdySoftTest\NerdySoftTest\Views\Home\Details.cshtml"
AddHtmlAttributeValue("", 441, Model.Announcement.Id, 441, 22, false);

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
            WriteLiteral("</td>\r\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eda5d70247fdd0f584b4411ed54b1b85ec9bfb665835", async() => {
                WriteLiteral("<input type=\"submit\" class=\"btn btn-outline-danger\" value=\"Delete\" />");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 566, "~/Home/Delete/", 566, 14, true);
#nullable restore
#line 17 "D:\Test\NerdySoftTest\NerdySoftTest\Views\Home\Details.cshtml"
AddHtmlAttributeValue("", 580, Model.Announcement.Id, 580, 22, false);

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
            WriteLiteral("</td>\r\n        </tr>\r\n\r\n        <table class=\"table\">\r\n        <tr>\r\n            <th>List similar of announcements</th>\r\n            <th></th>\r\n");
#nullable restore
#line 24 "D:\Test\NerdySoftTest\NerdySoftTest\Views\Home\Details.cshtml"
             foreach (var u in Model.ListOfAnnouncements)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr><td>");
#nullable restore
#line 26 "D:\Test\NerdySoftTest\NerdySoftTest\Views\Home\Details.cshtml"
               Write(u.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eda5d70247fdd0f584b4411ed54b1b85ec9bfb668063", async() => {
                WriteLiteral("View Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 941, "~/Home/Details/", 941, 15, true);
#nullable restore
#line 26 "D:\Test\NerdySoftTest\NerdySoftTest\Views\Home\Details.cshtml"
AddHtmlAttributeValue("", 956, u.Id, 956, 5, false);

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
            WriteLiteral("</td></tr>\r\n");
#nullable restore
#line 27 "D:\Test\NerdySoftTest\NerdySoftTest\Views\Home\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NerdySoftTest.Models.DetailsView> Html { get; private set; }
    }
}
#pragma warning restore 1591