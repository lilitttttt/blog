#pragma checksum "C:\Users\toxg1\OneDrive\Рабочий стол\ycheba\aspnet-blog-main\aspnet_config\Views\Home\DetailsProfilePost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31bf18d6f4db03cc10dda8f1056fb6decb4bd159"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DetailsProfilePost), @"mvc.1.0.view", @"/Views/Home/DetailsProfilePost.cshtml")]
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
#line 1 "C:\Users\toxg1\OneDrive\Рабочий стол\ycheba\aspnet-blog-main\aspnet_config\Views\_ViewImports.cshtml"
using aspnet_config;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\toxg1\OneDrive\Рабочий стол\ycheba\aspnet-blog-main\aspnet_config\Views\_ViewImports.cshtml"
using aspnet_config.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31bf18d6f4db03cc10dda8f1056fb6decb4bd159", @"/Views/Home/DetailsProfilePost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a5a603e0cf7cc24a03cb68a31e0d7c8eb7bebfe", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DetailsProfilePost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<aspnet_config.Models.Post>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profileshow", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\toxg1\OneDrive\Рабочий стол\ycheba\aspnet-blog-main\aspnet_config\Views\Home\DetailsProfilePost.cshtml"
  
    ViewBag.Title = "Post and Profile";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<table class=\"table\">\n");
#nullable restore
#line 7 "C:\Users\toxg1\OneDrive\Рабочий стол\ycheba\aspnet-blog-main\aspnet_config\Views\Home\DetailsProfilePost.cshtml"
     foreach (var item in Model)
    {
        if (item.Owner_Post==TestClass.TestOwner)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 12 "C:\Users\toxg1\OneDrive\Рабочий стол\ycheba\aspnet-blog-main\aspnet_config\Views\Home\DetailsProfilePost.cshtml"
               Write(item.Id_Post);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 13 "C:\Users\toxg1\OneDrive\Рабочий стол\ycheba\aspnet-blog-main\aspnet_config\Views\Home\DetailsProfilePost.cshtml"
               Write(item.Name_Post);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 14 "C:\Users\toxg1\OneDrive\Рабочий стол\ycheba\aspnet-blog-main\aspnet_config\Views\Home\DetailsProfilePost.cshtml"
               Write(item.Text_Post);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 15 "C:\Users\toxg1\OneDrive\Рабочий стол\ycheba\aspnet-blog-main\aspnet_config\Views\Home\DetailsProfilePost.cshtml"
               Write(item.Owner_Post);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 17 "C:\Users\toxg1\OneDrive\Рабочий стол\ycheba\aspnet-blog-main\aspnet_config\Views\Home\DetailsProfilePost.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31bf18d6f4db03cc10dda8f1056fb6decb4bd1595855", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<aspnet_config.Models.Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
