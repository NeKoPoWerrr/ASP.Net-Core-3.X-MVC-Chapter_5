#pragma checksum "E:\program\C sharp\Chapter_5\Chapter_5\Views\ErrorHandler\ErrorMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3b1768c246628a265e0ef8df0749adcef6c502e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ErrorHandler_ErrorMessage), @"mvc.1.0.view", @"/Views/ErrorHandler/ErrorMessage.cshtml")]
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
#line 1 "E:\program\C sharp\Chapter_5\Chapter_5\Views\_ViewImports.cshtml"
using Chapter_5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\program\C sharp\Chapter_5\Chapter_5\Views\_ViewImports.cshtml"
using Chapter_5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3b1768c246628a265e0ef8df0749adcef6c502e", @"/Views/ErrorHandler/ErrorMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7414cd1d0acfdfa46822d028ff45ecae4965c4e4", @"/Views/_ViewImports.cshtml")]
    public class Views_ErrorHandler_ErrorMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>訊息摘要</h2>\r\n\r\n<ul>\r\n    使用者 : ");
#nullable restore
#line 9 "E:\program\C sharp\Chapter_5\Chapter_5\Views\ErrorHandler\ErrorMessage.cshtml"
     Write(TempData["UserName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    時間 : ");
#nullable restore
#line 10 "E:\program\C sharp\Chapter_5\Chapter_5\Views\ErrorHandler\ErrorMessage.cshtml"
    Write(TempData["Time"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    訊息 : ");
#nullable restore
#line 11 "E:\program\C sharp\Chapter_5\Chapter_5\Views\ErrorHandler\ErrorMessage.cshtml"
    Write(TempData["ErrorMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n</ul>訊息 : ");
#nullable restore
#line 12 "E:\program\C sharp\Chapter_5\Chapter_5\Views\ErrorHandler\ErrorMessage.cshtml"
     Write(TempData.Peek("Message"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n");
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
