#pragma checksum "C:\Users\toxg1\OneDrive\Рабочий стол\ycheba\aspnet-blog-main\aspnet_config\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1466b32e37807b94c2030f11ab4d0ca3331c86d6"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1466b32e37807b94c2030f11ab4d0ca3331c86d6", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a5a603e0cf7cc24a03cb68a31e0d7c8eb7bebfe", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<aspnet_config.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\toxg1\OneDrive\Рабочий стол\ycheba\aspnet-blog-main\aspnet_config\Views\Home\Details.cshtml"
  
    ViewBag.Title = Model.Login_User;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Пользователь ");
#nullable restore
#line 5 "C:\Users\toxg1\OneDrive\Рабочий стол\ycheba\aspnet-blog-main\aspnet_config\Views\Home\Details.cshtml"
            Write(Model.Login_User);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n<div>\n    <dl class=\"dl-horizontal\">\n        <dt>ID</dt>\n        <dd>");
#nullable restore
#line 9 "C:\Users\toxg1\OneDrive\Рабочий стол\ycheba\aspnet-blog-main\aspnet_config\Views\Home\Details.cshtml"
       Write(Model.Id_User);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n        <dt>Email</dt>\n        <dd>");
#nullable restore
#line 11 "C:\Users\toxg1\OneDrive\Рабочий стол\ycheba\aspnet-blog-main\aspnet_config\Views\Home\Details.cshtml"
       Write(Model.Email_User);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n        <dt>Login</dt>\n        <dd>");
#nullable restore
#line 13 "C:\Users\toxg1\OneDrive\Рабочий стол\ycheba\aspnet-blog-main\aspnet_config\Views\Home\Details.cshtml"
       Write(Model.Login_User);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n    </dl>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<aspnet_config.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
