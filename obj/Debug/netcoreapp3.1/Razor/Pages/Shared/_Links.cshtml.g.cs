#pragma checksum "C:\Users\Alberto\source\repos\PersonalSite\Pages\Shared\_Links.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47ae099ecfa1744a18d5fbcbf9f86f19bcfa1a6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PersonalSite.Pages.Shared.Pages_Shared__Links), @"mvc.1.0.view", @"/Pages/Shared/_Links.cshtml")]
namespace PersonalSite.Pages.Shared
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
#line 1 "C:\Users\Alberto\source\repos\PersonalSite\Pages\_ViewImports.cshtml"
using PersonalSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alberto\source\repos\PersonalSite\Pages\_ViewImports.cshtml"
using PersonalSite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47ae099ecfa1744a18d5fbcbf9f86f19bcfa1a6a", @"/Pages/Shared/_Links.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e43c402490832e63edb0e6ad0e281f809b1885eb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__Links : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Alberto\source\repos\PersonalSite\Pages\Shared\_Links.cshtml"
 if (ViewData["Title"] == "Home")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a");
            BeginWriteAttribute("href", " href=\"", 61, "\"", 98, 2);
            WriteAttributeValue("", 68, "http://www.linkedin.com/", 68, 24, true);
#nullable restore
#line 5 "C:\Users\Alberto\source\repos\PersonalSite\Pages\Shared\_Links.cshtml"
WriteAttributeValue("", 92, Model, 92, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Resume</a>\r\n");
#nullable restore
#line 6 "C:\Users\Alberto\source\repos\PersonalSite\Pages\Shared\_Links.cshtml"
}
else if (ViewData["Title"] == "Projects")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a");
            BeginWriteAttribute("href", " href=\"", 167, "\"", 202, 2);
            WriteAttributeValue("", 174, "http://www.github.com/", 174, 22, true);
#nullable restore
#line 9 "C:\Users\Alberto\source\repos\PersonalSite\Pages\Shared\_Links.cshtml"
WriteAttributeValue("", 196, Model, 196, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Github profile</a>\r\n");
#nullable restore
#line 10 "C:\Users\Alberto\source\repos\PersonalSite\Pages\Shared\_Links.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591