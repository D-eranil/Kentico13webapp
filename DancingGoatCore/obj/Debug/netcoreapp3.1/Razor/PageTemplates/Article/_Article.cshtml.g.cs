#pragma checksum "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\PageTemplates\Article\_Article.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bade59302572f904b3334ec9dd757a749f8c1f88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.PageTemplates_Article__Article), @"mvc.1.0.view", @"/PageTemplates/Article/_Article.cshtml")]
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
#line 1 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\PageTemplates\_ViewImports.cshtml"
using DancingGoat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\PageTemplates\_ViewImports.cshtml"
using CMS.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\PageTemplates\_ViewImports.cshtml"
using Kentico.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\PageTemplates\_ViewImports.cshtml"
using Kentico.Content.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\PageTemplates\_ViewImports.cshtml"
using Kentico.PageBuilder.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\PageTemplates\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\PageTemplates\Article\_Article.cshtml"
using DancingGoat.PageTemplates;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bade59302572f904b3334ec9dd757a749f8c1f88", @"/PageTemplates/Article/_Article.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3dd21c4f465e83903a12d676a1dd0c01e2783b2", @"/PageTemplates/_ViewImports.cshtml")]
    #nullable restore
    public class PageTemplates_Article__Article : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ComponentViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "PageTemplates/_RelatedArticles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\PageTemplates\Article\_Article.cshtml"
  
    var templateModel = Service.GetTemplateModel();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<article class=\"col-lg-12 article-detail-related-box article-detail-full-width\">\r\n    <div class=\"row equal-height\">\r\n");
#nullable restore
#line 13 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\PageTemplates\Article\_Article.cshtml"
         if (!string.IsNullOrEmpty(templateModel.TeaserPath))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"article-detail-image col-lg-6 col-md-6\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 451, "\"", 482, 1);
#nullable restore
#line 16 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\PageTemplates\Article\_Article.cshtml"
WriteAttributeValue("", 457, templateModel.TeaserPath, 457, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 483, "\"", 509, 1);
#nullable restore
#line 16 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\PageTemplates\Article\_Article.cshtml"
WriteAttributeValue("", 489, templateModel.Title, 489, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 510, "\"", 538, 1);
#nullable restore
#line 16 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\PageTemplates\Article\_Article.cshtml"
WriteAttributeValue("", 518, templateModel.Title, 518, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-responsive\" />\r\n            </div>\r\n            <div class=\"col-lg-1 col-md-1 article-title--padding\">\r\n            </div>\r\n");
#nullable restore
#line 20 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\PageTemplates\Article\_Article.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-lg-5 col-md-5 article-title--align-middle\">\r\n            <h2>");
#nullable restore
#line 22 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\PageTemplates\Article\_Article.cshtml"
           Write(templateModel.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <div class=\"article-detail-datetime\">\r\n                ");
#nullable restore
#line 24 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\PageTemplates\Article\_Article.cshtml"
           Write(templateModel.PublicationDate.ToString("D"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"article-detail-content col-lg-9\">\r\n            ");
#nullable restore
#line 30 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\PageTemplates\Article\_Article.cshtml"
       Write(Html.Kentico().ResolveUrls(templateModel.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</article>\r\n");
#nullable restore
#line 34 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\PageTemplates\Article\_Article.cshtml"
 if (templateModel.RelatedArticles.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bade59302572f904b3334ec9dd757a749f8c1f888167", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 36 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\PageTemplates\Article\_Article.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = templateModel.RelatedArticles;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\PageTemplates\Article\_Article.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ArticlePageTemplateService Service { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ComponentViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
