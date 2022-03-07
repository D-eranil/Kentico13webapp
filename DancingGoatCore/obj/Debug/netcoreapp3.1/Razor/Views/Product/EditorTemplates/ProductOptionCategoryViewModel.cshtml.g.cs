#pragma checksum "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\Product\EditorTemplates\ProductOptionCategoryViewModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca01bf40b221f92eb6db8080c57d241ad4c55058"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_EditorTemplates_ProductOptionCategoryViewModel), @"mvc.1.0.view", @"/Views/Product/EditorTemplates/ProductOptionCategoryViewModel.cshtml")]
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
#line 1 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\_ViewImports.cshtml"
using DancingGoat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\_ViewImports.cshtml"
using CMS.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\_ViewImports.cshtml"
using Kentico.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\_ViewImports.cshtml"
using Kentico.Content.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\_ViewImports.cshtml"
using Kentico.PageBuilder.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\Product\EditorTemplates\ProductOptionCategoryViewModel.cshtml"
using CMS.Ecommerce;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca01bf40b221f92eb6db8080c57d241ad4c55058", @"/Views/Product/EditorTemplates/ProductOptionCategoryViewModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88d8fa80da67568a3e522497460b5cdcd2065f73", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_EditorTemplates_ProductOptionCategoryViewModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DancingGoat.Models.ProductOptionCategoryViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"form-group\">\r\n    <div class=\"editing-form-label-cell option-category-name control-label\">\r\n        <label>");
#nullable restore
#line 7 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\Product\EditorTemplates\ProductOptionCategoryViewModel.cshtml"
          Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n    </div>\r\n\r\n");
#nullable restore
#line 10 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\Product\EditorTemplates\ProductOptionCategoryViewModel.cshtml"
     if (Model.SelectionType == OptionCategorySelectionTypeEnum.Dropdownlist)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\Product\EditorTemplates\ProductOptionCategoryViewModel.cshtml"
   Write(Html.DropDownListFor(m => m.SelectedOptionId, new SelectList(Model.Options, "SKUID", "SKUName", Model.SelectedOptionId), new { @class = "js-variant-selector" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\Product\EditorTemplates\ProductOptionCategoryViewModel.cshtml"
                                                                                                                                                                         
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\Product\EditorTemplates\ProductOptionCategoryViewModel.cshtml"
     if (Model.SelectionType == OptionCategorySelectionTypeEnum.RadioButtonsVertical)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"js-variant-selector\">\r\n");
#nullable restore
#line 17 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\Product\EditorTemplates\ProductOptionCategoryViewModel.cshtml"
             foreach (var option in Model.Options)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"radio\">\r\n                    ");
#nullable restore
#line 20 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\Product\EditorTemplates\ProductOptionCategoryViewModel.cshtml"
               Write(Html.RadioButtonFor(m => m.SelectedOptionId, option.SKUID, new { id = option.SKUID}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <label");
            BeginWriteAttribute("for", " for=\"", 876, "\"", 895, 1);
#nullable restore
#line 21 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\Product\EditorTemplates\ProductOptionCategoryViewModel.cshtml"
WriteAttributeValue("", 882, option.SKUID, 882, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 21 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\Product\EditorTemplates\ProductOptionCategoryViewModel.cshtml"
                                          Write(option.SKUName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </div>\r\n");
#nullable restore
#line 23 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\Product\EditorTemplates\ProductOptionCategoryViewModel.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 25 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\Product\EditorTemplates\ProductOptionCategoryViewModel.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DancingGoat.Models.ProductOptionCategoryViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
