#pragma checksum "/Users/pkrull/Documents/codingDojo/cohorts/tulsa_february_2019/cSharp/DotNetWebDemo/Views/Home/UserPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64e2069d1f51e7302a228b558b475dda842658db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserPage), @"mvc.1.0.view", @"/Views/Home/UserPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/UserPage.cshtml", typeof(AspNetCore.Views_Home_UserPage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64e2069d1f51e7302a228b558b475dda842658db", @"/Views/Home/UserPage.cshtml")]
    public class Views_Home_UserPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 33, true);
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            EndContext();
            BeginContext(33, 202, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a222a90779304d2baf07fc58b1b527c1", async() => {
                BeginContext(39, 189, true);
                WriteLiteral("\n    <meta charset=\"UTF-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\n    <title>Document</title>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(235, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(236, 558, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a357b73af92c47d6833f0ee1b79f8d47", async() => {
                BeginContext(242, 74, true);
                WriteLiteral("\n    <table>\n        <tr>\n            <td>First Name</td>\n            <td>");
                EndContext();
                BeginContext(317, 15, false);
#line 13 "/Users/pkrull/Documents/codingDojo/cohorts/tulsa_february_2019/cSharp/DotNetWebDemo/Views/Home/UserPage.cshtml"
           Write(Model.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(332, 80, true);
                WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>Last Name</td>\n            <td>");
                EndContext();
                BeginContext(413, 14, false);
#line 17 "/Users/pkrull/Documents/codingDojo/cohorts/tulsa_february_2019/cSharp/DotNetWebDemo/Views/Home/UserPage.cshtml"
           Write(Model.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(427, 33, true);
                WriteLiteral("</td>\n        </tr>\n    </table>\n");
                EndContext();
#line 20 "/Users/pkrull/Documents/codingDojo/cohorts/tulsa_february_2019/cSharp/DotNetWebDemo/Views/Home/UserPage.cshtml"
      if(TempData["FirstName"] != null)
    {

#line default
#line hidden
                BeginContext(506, 89, true);
                WriteLiteral("        <table>\n            <tr>\n                <td>First Name</td>\n                <td>");
                EndContext();
                BeginContext(596, 21, false);
#line 25 "/Users/pkrull/Documents/codingDojo/cohorts/tulsa_february_2019/cSharp/DotNetWebDemo/Views/Home/UserPage.cshtml"
               Write(TempData["FirstName"]);

#line default
#line hidden
                EndContext();
                BeginContext(617, 96, true);
                WriteLiteral("</td>\n            </tr>\n            <tr>\n                <td>Last Name</td>\n                <td>");
                EndContext();
                BeginContext(714, 20, false);
#line 29 "/Users/pkrull/Documents/codingDojo/cohorts/tulsa_february_2019/cSharp/DotNetWebDemo/Views/Home/UserPage.cshtml"
               Write(TempData["LastName"]);

#line default
#line hidden
                EndContext();
                BeginContext(734, 41, true);
                WriteLiteral("</td>\n            </tr>\n        </table>\n");
                EndContext();
#line 32 "/Users/pkrull/Documents/codingDojo/cohorts/tulsa_february_2019/cSharp/DotNetWebDemo/Views/Home/UserPage.cshtml"
    }
    

#line default
#line hidden
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(794, 8, true);
            WriteLiteral("\n</html>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
