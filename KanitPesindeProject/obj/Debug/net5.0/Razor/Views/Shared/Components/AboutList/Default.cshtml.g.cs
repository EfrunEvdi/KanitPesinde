#pragma checksum "C:\Users\SEM\source\repos\KanitPesinde\KanitPesindeProject\Views\Shared\Components\AboutList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cd13bac2594d3142b7b22172b20de010a38adf8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AboutList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AboutList/Default.cshtml")]
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
#line 1 "C:\Users\SEM\source\repos\KanitPesinde\KanitPesindeProject\Views\_ViewImports.cshtml"
using KanitPesindeProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SEM\source\repos\KanitPesinde\KanitPesindeProject\Views\_ViewImports.cshtml"
using KanitPesindeProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\SEM\source\repos\KanitPesinde\KanitPesindeProject\Views\Shared\Components\AboutList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cd13bac2594d3142b7b22172b20de010a38adf8", @"/Views/Shared/Components/AboutList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9493e873dd4de4a6a6f713fe7793d8ac1bfb60a5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_AboutList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<About>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<section class=\"w3l-call-to-action_9\">\r\n    <div class=\"call-w3\">\r\n        <div class=\"container\">\r\n            <div class=\" main-cont-wthree-2\">\r\n                <div class=\"left-contect-calls text-center\">\r\n");
#nullable restore
#line 9 "C:\Users\SEM\source\repos\KanitPesinde\KanitPesindeProject\Views\Shared\Components\AboutList\Default.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h3 class=\"header-name\">");
#nullable restore
#line 11 "C:\Users\SEM\source\repos\KanitPesinde\KanitPesindeProject\Views\Shared\Components\AboutList\Default.cshtml"
                                           Write(item.AboutTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p class=\"tiltle-para\">\r\n                            ");
#nullable restore
#line 13 "C:\Users\SEM\source\repos\KanitPesinde\KanitPesindeProject\Views\Shared\Components\AboutList\Default.cshtml"
                       Write(item.AboutDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n");
#nullable restore
#line 15 "C:\Users\SEM\source\repos\KanitPesinde\KanitPesindeProject\Views\Shared\Components\AboutList\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"call-grids-w3 \">\r\n\r\n");
#nullable restore
#line 18 "C:\Users\SEM\source\repos\KanitPesinde\KanitPesindeProject\Views\Shared\Components\AboutList\Default.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"grids-effect-2\">\r\n                                <span>");
#nullable restore
#line 21 "C:\Users\SEM\source\repos\KanitPesinde\KanitPesindeProject\Views\Shared\Components\AboutList\Default.cshtml"
                                 Write(item.AboutValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <h4>");
#nullable restore
#line 22 "C:\Users\SEM\source\repos\KanitPesinde\KanitPesindeProject\Views\Shared\Components\AboutList\Default.cshtml"
                               Write(item.AboutValueTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            </div>\r\n");
#nullable restore
#line 24 "C:\Users\SEM\source\repos\KanitPesinde\KanitPesindeProject\Views\Shared\Components\AboutList\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<About>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
