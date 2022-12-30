#pragma checksum "C:\Users\SEM\source\repos\KanitPesinde\KanitPesindeProject\Views\Shared\Components\IntroList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58c6aad3ca56d1c510261e59cea6b28fc9d74bc5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_IntroList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/IntroList/Default.cshtml")]
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
#line 1 "C:\Users\SEM\source\repos\KanitPesinde\KanitPesindeProject\Views\Shared\Components\IntroList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58c6aad3ca56d1c510261e59cea6b28fc9d74bc5", @"/Views/Shared/Components/IntroList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9493e873dd4de4a6a6f713fe7793d8ac1bfb60a5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_IntroList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Intro>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"w3l-hero-headers-9\">\r\n    <div class=\"css-slider\">\r\n");
#nullable restore
#line 7 "C:\Users\SEM\source\repos\KanitPesinde\KanitPesindeProject\Views\Shared\Components\IntroList\Default.cshtml"
          
            var headerHtml = "";
         

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\SEM\source\repos\KanitPesinde\KanitPesindeProject\Views\Shared\Components\IntroList\Default.cshtml"
         foreach (var item in Model)
        {
            var itemId = @item.IntroID;
            var className = "";
            var checkedControl = "";
            var imgUrl = ("/KanitPesinde/assets/images/b" + @itemId + ".jpg");

            if(itemId == 1)
            {
                checkedControl = "checked";
            }
         

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input");
            BeginWriteAttribute("id", " id=\"", 551, "\"", 569, 2);
            WriteAttributeValue("", 556, "slide-", 556, 6, true);
#nullable restore
#line 22 "C:\Users\SEM\source\repos\KanitPesinde\KanitPesindeProject\Views\Shared\Components\IntroList\Default.cshtml"
WriteAttributeValue("", 562, itemId, 562, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"radio\" name=\"slides\" ");
#nullable restore
#line 22 "C:\Users\SEM\source\repos\KanitPesinde\KanitPesindeProject\Views\Shared\Components\IntroList\Default.cshtml"
                                                            Write(checkedControl);

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n            <section");
            BeginWriteAttribute("class", " class=\"", 636, "\"", 666, 3);
            WriteAttributeValue("", 644, "slide", 644, 5, true);
            WriteAttributeValue(" ", 649, "slide-", 650, 7, true);
#nullable restore
#line 23 "C:\Users\SEM\source\repos\KanitPesinde\KanitPesindeProject\Views\Shared\Components\IntroList\Default.cshtml"
WriteAttributeValue("", 656, className, 656, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 667, "\"", 704, 3);
            WriteAttributeValue("", 675, "background-image:url(", 675, 21, true);
#nullable restore
#line 23 "C:\Users\SEM\source\repos\KanitPesinde\KanitPesindeProject\Views\Shared\Components\IntroList\Default.cshtml"
WriteAttributeValue("", 696, imgUrl, 696, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 703, ")", 703, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"container\">\r\n                        <div class=\"banner-text\">\r\n                            <h2>");
#nullable restore
#line 26 "C:\Users\SEM\source\repos\KanitPesinde\KanitPesindeProject\Views\Shared\Components\IntroList\Default.cshtml"
                           Write(item.IntroTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <p>\r\n                                ");
#nullable restore
#line 28 "C:\Users\SEM\source\repos\KanitPesinde\KanitPesindeProject\Views\Shared\Components\IntroList\Default.cshtml"
                           Write(item.IntroDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n\r\n                            <a href=\"contact.html\" class=\"btn logo-button top-margin\">Read More</a>\r\n                        </div>\r\n                    </div>\r\n                </section>\r\n");
#nullable restore
#line 35 "C:\Users\SEM\source\repos\KanitPesinde\KanitPesindeProject\Views\Shared\Components\IntroList\Default.cshtml"
            headerHtml += ("<label for='slide-"+@itemId+"' id='slide-"+@itemId+"'></label>");
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <header>\r\n            ");
#nullable restore
#line 39 "C:\Users\SEM\source\repos\KanitPesinde\KanitPesindeProject\Views\Shared\Components\IntroList\Default.cshtml"
       Write(Html.Raw(@headerHtml));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </header>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Intro>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
