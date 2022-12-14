#pragma checksum "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\TopSellingProduct\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "300848ca1f527ec87e42a0779682e4637a89ad59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TopSellingProduct_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TopSellingProduct/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"300848ca1f527ec87e42a0779682e4637a89ad59", @"/Views/Shared/Components/TopSellingProduct/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_TopSellingProduct_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TicaretApp.Entity.Dtos.ProductListDto>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container"">
    <!-- row -->
    <div class=""row"">

        <!-- section title -->
        <div class=""col-md-12"">
            <div class=""section-title"">
                <h3 class=""title"">Top selling</h3>
                <div class=""section-nav"">
                    <ul class=""section-tab-nav tab-nav"">
");
#nullable restore
#line 12 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\TopSellingProduct\Default.cshtml"
                         foreach (var category in ViewBag.Categories)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "300848ca1f527ec87e42a0779682e4637a89ad595848", async() => {
#nullable restore
#line 14 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\TopSellingProduct\Default.cshtml"
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
#line 14 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\TopSellingProduct\Default.cshtml"
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
#line 15 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\TopSellingProduct\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </ul>
                </div>
            </div>
        </div>
        <!-- /section title -->
        <!-- Products tab & slick -->
        <div class=""col-md-12"">
            <div class=""row"">
                <div class=""products-tabs"">
                    <!-- tab -->
                    <div id=""tab2"" class=""tab-pane fade in active"">
                        <div class=""products-slick"" data-nav=""#slick-nav-2"">
");
#nullable restore
#line 29 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\TopSellingProduct\Default.cshtml"
                             foreach (var product in Model.Products)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"product\">\r\n                                    <div class=\"product-img\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "300848ca1f527ec87e42a0779682e4637a89ad599757", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1357, "~/img/", 1357, 6, true);
#nullable restore
#line 33 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\TopSellingProduct\Default.cshtml"
AddHtmlAttributeValue("", 1363, product.ImageUrl, 1363, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 33 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\TopSellingProduct\Default.cshtml"
AddHtmlAttributeValue("", 1387, product.Name, 1387, 13, false);

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
#line 35 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\TopSellingProduct\Default.cshtml"
                                             if (product.Discount != null)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"sale\">-");
#nullable restore
#line 37 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\TopSellingProduct\Default.cshtml"
                                                               Write(product.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n");
#nullable restore
#line 38 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\TopSellingProduct\Default.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\TopSellingProduct\Default.cshtml"
                                             if (product.ModifiedDate != DateTime.Today.AddDays(-4))
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"new\">NEW</span>\r\n");
#nullable restore
#line 42 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\TopSellingProduct\Default.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </div>\r\n                                    </div>\r\n                                    <div class=\"product-body\">\r\n");
#nullable restore
#line 47 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\TopSellingProduct\Default.cshtml"
                                         foreach (var productCategory in product.ProductCategories)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <p class=\"product-category\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "300848ca1f527ec87e42a0779682e4637a89ad5914035", async() => {
#nullable restore
#line 49 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\TopSellingProduct\Default.cshtml"
                                                                                                                                                                    Write(productCategory.Category.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
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
#line 49 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\TopSellingProduct\Default.cshtml"
                                                                                                                                WriteLiteral(productCategory.CategoryId);

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
#line 50 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\TopSellingProduct\Default.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <h3 class=\"product-name\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "300848ca1f527ec87e42a0779682e4637a89ad5917251", async() => {
#nullable restore
#line 52 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\TopSellingProduct\Default.cshtml"
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
#line 52 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\TopSellingProduct\Default.cshtml"
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
#line 53 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\TopSellingProduct\Default.cshtml"
                                         if (product.Discount != null)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <h4 class=\"product-price\">$");
#nullable restore
#line 55 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\TopSellingProduct\Default.cshtml"
                                                                   Write(product.OldPrice-(product.OldPrice*product.Discount/100));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <del class=\"product-old-price\">$");
#nullable restore
#line 55 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\TopSellingProduct\Default.cshtml"
                                                                                                                                                              Write(product.OldPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</del></h4>\r\n");
#nullable restore
#line 56 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\TopSellingProduct\Default.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <h4 class=\"product-price\">$");
#nullable restore
#line 59 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\TopSellingProduct\Default.cshtml"
                                                                  Write(product.OldPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 60 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\TopSellingProduct\Default.cshtml"

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
            WriteLiteral("                                </div>\r\n                                    </div>\r\n                                    <div class=\"add-to-cart\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "300848ca1f527ec87e42a0779682e4637a89ad5923487", async() => {
                WriteLiteral("\r\n                                            <input type=\"hidden\" name=\"productId\"");
                BeginWriteAttribute("value", " value=\"", 4679, "\"", 4698, 1);
#nullable restore
#line 78 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\TopSellingProduct\Default.cshtml"
WriteAttributeValue("", 4687, product.Id, 4687, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                            <input type=""hidden"" name=""quantity"" value=""1"" />
                                            <button class=""add-to-cart-btn""><i class=""fa fa-shopping-cart""></i> add to cart</button>
                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 84 "C:\MyProjects\TicaretApp\TicaretApp.Mvc\Views\Shared\Components\TopSellingProduct\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </div>
                        <div id=""slick-nav-2"" class=""products-slick-nav""></div>
                    </div>
                    <!-- /tab -->
                </div>
            </div>
        </div>
        <!-- /Products tab & slick -->
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
