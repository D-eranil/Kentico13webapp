#pragma checksum "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Components\ViewComponents\Navigation\Footer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4ea08fce4c3ddfc58d2168bdf8feb7f9cc9f6cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Components_ViewComponents_Navigation_Footer), @"mvc.1.0.view", @"/Components/ViewComponents/Navigation/Footer.cshtml")]
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
#line 1 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Components\_ViewImports.cshtml"
using DancingGoat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Components\_ViewImports.cshtml"
using CMS.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Components\_ViewImports.cshtml"
using Kentico.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Components\_ViewImports.cshtml"
using Kentico.Content.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Components\_ViewImports.cshtml"
using Kentico.PageBuilder.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Components\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Components\ViewComponents\Navigation\Footer.cshtml"
using DancingGoat.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4ea08fce4c3ddfc58d2168bdf8feb7f9cc9f6cb", @"/Components/ViewComponents/Navigation/Footer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3dd21c4f465e83903a12d676a1dd0c01e2783b2", @"/Components/_ViewImports.cshtml")]
    #nullable restore
    public class Components_ViewComponents_Navigation_Footer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MenuItemViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Components\ViewComponents\Navigation\Footer.cshtml"
 if (Model.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3");
            BeginWriteAttribute("class", " class=\"", 99, "\"", 107, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 7 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Components\ViewComponents\Navigation\Footer.cshtml"
            Write(HtmlLocalizer["Navigation"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 8 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Components\ViewComponents\Navigation\Footer.cshtml"

    foreach (var menuItem in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 200, "\"", 220, 1);
#nullable restore
#line 11 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Components\ViewComponents\Navigation\Footer.cshtml"
WriteAttributeValue("", 207, menuItem.Url, 207, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 11 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Components\ViewComponents\Navigation\Footer.cshtml"
                           Write(HtmlLocalizer[menuItem.Caption]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        <br />\r\n");
#nullable restore
#line 13 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Components\ViewComponents\Navigation\Footer.cshtml"
    }
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHtmlLocalizer<SharedResources> HtmlLocalizer { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MenuItemViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
