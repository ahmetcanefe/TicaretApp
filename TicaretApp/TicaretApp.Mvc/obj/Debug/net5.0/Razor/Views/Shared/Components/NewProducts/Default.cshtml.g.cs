#pragma checksum "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\NewProducts\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb14d37a9477fa3c1cdcbedd88fd4df45f98dc18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_NewProducts_Default), @"mvc.1.0.view", @"/Views/Shared/Components/NewProducts/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb14d37a9477fa3c1cdcbedd88fd4df45f98dc18", @"/Views/Shared/Components/NewProducts/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_NewProducts_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TicaretApp.Entity.Dtos.ProductListDto>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container"">
    <!-- row -->
    <div class=""row"">

        <!-- section title -->
        <div class=""col-md-12"">
            <div class=""section-title"">
                <h3 class=""title"">New Products</h3>
                <div class=""section-nav"">
                    <ul class=""section-tab-nav tab-nav"">
");
#nullable restore
#line 13 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\NewProducts\Default.cshtml"
                         foreach (var category in ViewBag.Categories)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb14d37a9477fa3c1cdcbedd88fd4df45f98dc184631", async() => {
#nullable restore
#line 15 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\NewProducts\Default.cshtml"
                                                                                                             Write(category.Name);

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
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-categoryId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\NewProducts\Default.cshtml"
                                                                                        WriteLiteral(category.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-categoryId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 16 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\NewProducts\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </ul>
                </div>
            </div>
        </div>
        <!-- /section title -->
        <!-- Products tab & slick -->
        <div class=""col-md-12"">
            <div class=""row"">
                <div class=""products-tabs"">
                    <!-- tab -->
                    <div id=""tab1"" class=""tab-pane active"">
                        <div class=""products-slick"" data-nav=""#slick-nav-1"">
");
#nullable restore
#line 29 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\NewProducts\Default.cshtml"
                             foreach (var product in Model.Products)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"product\">\r\n                                    <div class=\"product-img\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cb14d37a9477fa3c1cdcbedd88fd4df45f98dc188506", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1350, "~/img/", 1350, 6, true);
#nullable restore
#line 33 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\NewProducts\Default.cshtml"
AddHtmlAttributeValue("", 1356, product.ImageUrl, 1356, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 33 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\NewProducts\Default.cshtml"
AddHtmlAttributeValue("", 1380, product.Name, 1380, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        <div class=\"product-label\">\r\n");
#nullable restore
#line 35 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\NewProducts\Default.cshtml"
                                             if (product.Discount != null)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"sale\">%");
#nullable restore
#line 37 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\NewProducts\Default.cshtml"
                                                               Write(product.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 38 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\NewProducts\Default.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 40 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\NewProducts\Default.cshtml"
                                             if (product.ModifiedDate >= DateTime.Today.AddDays(-4))
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"new\">NEW</span>\r\n");
#nullable restore
#line 43 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\NewProducts\Default.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </div>\r\n                                    </div>\r\n                                    <div class=\"product-body\">\r\n");
#nullable restore
#line 48 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\NewProducts\Default.cshtml"
                                         foreach (var productCategory in product.ProductCategories)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <p class=\"product-category\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb14d37a9477fa3c1cdcbedd88fd4df45f98dc1812770", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-categoryId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\NewProducts\Default.cshtml"
                                                                                                                                WriteLiteral(productCategory.Category.Name);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-categoryId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n");
#nullable restore
#line 51 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\NewProducts\Default.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <h3 class=\"product-name\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb14d37a9477fa3c1cdcbedd88fd4df45f98dc1815560", async() => {
#nullable restore
#line 53 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\NewProducts\Default.cshtml"
                                                                                                                                              Write(product.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\NewProducts\Default.cshtml"
                                                                                                                          WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 54 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\NewProducts\Default.cshtml"
                                         if (product.Discount != null)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <h4 class=\"product-price\">$");
#nullable restore
#line 56 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\NewProducts\Default.cshtml"
                                                                   Write(product.OldPrice-(product.OldPrice*product.Discount/100));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <del class=\"product-old-price\">$");
#nullable restore
#line 56 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\NewProducts\Default.cshtml"
                                                                                                                                                              Write(product.OldPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</del></h4>\r\n");
#nullable restore
#line 57 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\NewProducts\Default.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <h4 class=\"product-price\">$");
#nullable restore
#line 60 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\NewProducts\Default.cshtml"
                                                                  Write(product.OldPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 61 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\NewProducts\Default.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        <div class=""product-rating"">
                                            <i class=""fa fa-star""></i>
                                            <i class=""fa fa-star""></i>
                                            <i class=""fa fa-star""></i>
                                            <i class=""fa fa-star""></i>
                                            <i class=""fa fa-star""></i>
                                        </div>
                                        <div class=""product-btns"">
                                            <button class=""add-to-wishlist""><i class=""fa fa-heart-o""></i><span class=""tooltipp"">add to wishlist</span></button>
                                            <button class=""add-to-compare""><i class=""fa fa-exchange""></i><span class=""tooltipp"">add to compare</span></button>
                                            <button class=""quick-view""><i class=""fa fa-eye""></i><span class=""tooltipp"">quick view</span></button>
        ");
            WriteLiteral(@"                                </div>
                                    </div>
                                    <div class=""add-to-cart"">
                                        <button class=""add-to-cart-btn""><i class=""fa fa-shopping-cart""></i> add to cart</button>
                                    </div>
                                </div>
");
#nullable restore
#line 80 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\NewProducts\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </div>
                        <div id=""slick-nav-1"" class=""products-slick-nav""></div>
                    </div>
                    <!-- /tab -->
                </div>
            </div>
        </div>
        <!-- Products tab & slick -->
    </div>
    <!-- /row -->
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TicaretApp.Entity.Dtos.ProductListDto> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
