#pragma checksum "C:\Users\efrun\Source\Repos\KanitPesinde\KanitPesindeProject\Views\DetectiveStory\DetectiveStory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57a339a844fa86838e26e2fc371ccda42ac8b949"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DetectiveStory_DetectiveStory), @"mvc.1.0.view", @"/Views/DetectiveStory/DetectiveStory.cshtml")]
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
#line 1 "C:\Users\efrun\Source\Repos\KanitPesinde\KanitPesindeProject\Views\_ViewImports.cshtml"
using KanitPesindeProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\efrun\Source\Repos\KanitPesinde\KanitPesindeProject\Views\_ViewImports.cshtml"
using KanitPesindeProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57a339a844fa86838e26e2fc371ccda42ac8b949", @"/Views/DetectiveStory/DetectiveStory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9493e873dd4de4a6a6f713fe7793d8ac1bfb60a5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_DetectiveStory_DetectiveStory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\efrun\Source\Repos\KanitPesinde\KanitPesindeProject\Views\DetectiveStory\DetectiveStory.cshtml"
  
    ViewData["Title"] = "DetectiveStory";
    Layout = "~/Views/Shared/_KanitPesindeLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\efrun\Source\Repos\KanitPesinde\KanitPesindeProject\Views\DetectiveStory\DetectiveStory.cshtml"
Write(await Component.InvokeAsync("DetectiveStoryList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
