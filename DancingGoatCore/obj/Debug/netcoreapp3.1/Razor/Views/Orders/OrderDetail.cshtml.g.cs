#pragma checksum "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\Orders\OrderDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "916a66f0abee023f8ee050073502383cf8b2603b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_OrderDetail), @"mvc.1.0.view", @"/Views/Orders/OrderDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"916a66f0abee023f8ee050073502383cf8b2603b", @"/Views/Orders/OrderDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88d8fa80da67568a3e522497460b5cdcd2065f73", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Orders_OrderDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DancingGoat.Models.OrderDetailViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ItemDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\Orders\OrderDetail.cshtml"
  
    ViewBag.Title = HtmlLocalizer["Order Detail"].Value;
    ViewData["PageClass"] = "inverted";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "916a66f0abee023f8ee050073502383cf8b2603b5449", async() => {
                WriteLiteral("&larr; ");
#nullable restore
#line 8 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\Orders\OrderDetail.cshtml"
                                                Write(HtmlLocalizer["back to Your Orders"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<h2>\r\n    ");
#nullable restore
#line 10 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\Orders\OrderDetail.cshtml"
Write(HtmlLocalizer["Order Detail"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 11 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\Orders\OrderDetail.cshtml"
Write(Model.InvoiceNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 11 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\Orders\OrderDetail.cshtml"
                      Write(HtmlLocalizer[Model.StatusName]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h2>\r\n<hr />\r\n<div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n            <h3>");
#nullable restore
#line 17 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\Orders\OrderDetail.cshtml"
           Write(HtmlLocalizer["Billing details"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            ");
#nullable restore
#line 18 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\Orders\OrderDetail.cshtml"
       Write(Html.DisplayFor(m => m.OrderAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <h3>");
#nullable restore
#line 21 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\Orders\OrderDetail.cshtml"
           Write(HtmlLocalizer["Shipping details"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            ");
#nullable restore
#line 22 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\Orders\OrderDetail.cshtml"
       Write(Html.DisplayFor(m => m.OrderAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div>\r\n        <h4>");
#nullable restore
#line 26 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\Orders\OrderDetail.cshtml"
       Write(HtmlLocalizer["Order Items"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <hr />\r\n");
#nullable restore
#line 28 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\Orders\OrderDetail.cshtml"
         foreach (var orderItem in Model.OrderItems)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row order-item\">\r\n                <div class=\"col-md-10\">\r\n");
#nullable restore
#line 32 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\Orders\OrderDetail.cshtml"
                     if (!string.IsNullOrEmpty(orderItem.SKUImagePath))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"order-item-image\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "916a66f0abee023f8ee050073502383cf8b2603b10085", async() => {
                WriteLiteral("\r\n                                <img");
                BeginWriteAttribute("src", " src=\"", 1254, "\"", 1283, 1);
#nullable restore
#line 36 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\Orders\OrderDetail.cshtml"
WriteAttributeValue("", 1260, orderItem.SKUImagePath, 1260, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1284, "\"", 1308, 1);
#nullable restore
#line 36 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\Orders\OrderDetail.cshtml"
WriteAttributeValue("", 1290, orderItem.SKUName, 1290, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 1309, "\"", 1335, 1);
#nullable restore
#line 36 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\Orders\OrderDetail.cshtml"
WriteAttributeValue("", 1317, orderItem.SKUName, 1317, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-skuId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\Orders\OrderDetail.cshtml"
                                                                                      WriteLiteral(orderItem.SKUID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["skuId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-skuId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["skuId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 39 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\Orders\OrderDetail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"order-item-info\">\r\n                        ");
#nullable restore
#line 41 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\Orders\OrderDetail.cshtml"
                   Write(Html.ActionLink(orderItem.SKUName, "ItemDetail", "Checkout", new {skuId = orderItem.SKUID }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"order-item-amount\">\r\n                        <div>\r\n                            <span class=\"strong\">Qty: </span>\r\n                            <span>");
#nullable restore
#line 46 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\Orders\OrderDetail.cshtml"
                             Write(orderItem.UnitCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                        <div>\r\n                            <span class=\"strong\">Unit price: </span>\r\n                            <span>");
#nullable restore
#line 50 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\Orders\OrderDetail.cshtml"
                             Write(Model.FormatPrice(orderItem.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n\r\n                    </div>\r\n\r\n                    ");
#nullable restore
#line 55 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\Orders\OrderDetail.cshtml"
               Write(Html.ValidationMessage(orderItem.UnitPrice.ToString(), new {@class = "red"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n                <div class=\"col-md-2 order-item-subtotal\">\r\n                    <span>");
#nullable restore
#line 59 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\Orders\OrderDetail.cshtml"
                     Write(Model.FormatPrice(orderItem.TotalPriceInMainCurrency));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n            <hr />\r\n");
#nullable restore
#line 63 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\Orders\OrderDetail.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"order-total-price\">\r\n            <div>\r\n                <span class=\"strong\">");
#nullable restore
#line 66 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\Orders\OrderDetail.cshtml"
                                Write(HtmlLocalizer["TOTAL (incl. tax):"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                <span class=\"total-price\">");
#nullable restore
#line 67 "C:\inetpub\wwwroot\Kentico13webapp\DancingGoatCore\Views\Orders\OrderDetail.cshtml"
                                     Write(Model.FormatPrice(Model.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DancingGoat.Models.OrderDetailViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
