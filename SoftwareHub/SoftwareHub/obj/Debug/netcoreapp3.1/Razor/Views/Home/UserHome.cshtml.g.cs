#pragma checksum "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\UserHome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26e1d902d53c6a47863fcc02e4c083e1a8b11dbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserHome), @"mvc.1.0.view", @"/Views/Home/UserHome.cshtml")]
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
#line 1 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\_ViewImports.cshtml"
using SoftwareHub;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\_ViewImports.cshtml"
using SoftwareHub.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26e1d902d53c6a47863fcc02e4c083e1a8b11dbf", @"/Views/Home/UserHome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9c3d39286131762fc08ed4d83557f99b81edb08", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserHome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SoftwareHub.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/prodstorage.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\UserHome.cshtml"
  
    ViewData["Title"] = "SoftwareHub";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\UserHome.cshtml"
  
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26e1d902d53c6a47863fcc02e4c083e1a8b11dbf4269", async() => {
                WriteLiteral(@"

    <style>
        .product .product-body .product-name {
            text-transform: uppercase;
            font-size: 20px;
            color: #D10024;
        }
    </style>

    <!-- SECTION -->
    <div class=""section"">
        <!-- container -->
        <div class=""container"">
            <!-- row -->
            <div class=""row"">

                <!-- section title -->
                <div class=""col-md-12"">
                    <div class=""section-title"">
                        <h3 class=""title"">Our Products</h3>
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
                WriteLiteral("                                 <!-- product -->\r\n\r\n");
#nullable restore
#line 44 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\UserHome.cshtml"
                                     foreach (var item in Model)
                                    {
                                        var productIdent = item.ProductId.ToString();
                                        var productName = item.ProductName.ToString();
                                        var productbasicPrice = item.BasicPrice.ToString();
                                        var productstdPrice = item.StandardPrice.ToString();
                                        var productentPrice = item.EnterprisePrice.ToString();
                                        var productCategory = item.Category.ToString();
                                        var productDetail = item.Description.ToString();
                                        var productPoc = item.PocName.ToString();
                                        var productPocmail = item.PocEmail.ToString();
                                        var productPocphone = item.PocPhone.ToString();


#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                        <div class=""product"">
                                            <div class=""product-img"">
                                                <img src=""https://th.bing.com/th/id/R40a32bc2171bb9e3fa93f037abd501b8?rik=tRXv57Ej%2bDbvgw&riu=http%3a%2f%2fwww.pngmart.com%2ffiles%2f4%2fCoder-PNG-Transparent-Image-279x279.png&ehk=PCfc0cXYEX7gDIaODdslAXH9DIGwx5YWAlE52L9L8Jw%3d&risl=&pid=ImgRaw""");
                BeginWriteAttribute("alt", " alt=\"", 2689, "\"", 2695, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                                <div class=""product-label"">
                                                </div>
                                            </div>

                                            <div class=""product-body"">
                                                <p class=""product-category"">
                                                    ");
#nullable restore
#line 66 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\UserHome.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Category));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                </p>
                                                <br />
                                                <br />
                                                <h2 class=""product-name"">
                                                    <a href=""#"">
                                                        ");
#nullable restore
#line 72 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\UserHome.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                    </a>
                                                </h2>

                                                <div class=""product-btns"">
                                                    <button class=""add-to-wishlist""><i class=""fa fa-heart-o""></i><span class=""tooltipp"">add to wishlist</span></button>
                                                    <button class=""add-to-compare""><i class=""fa fa-exchange""></i><span class=""tooltipp"">add to compare</span></button>
                                                    <button class=""quick-view""><i class=""fa fa-eye""></i><span class=""tooltipp"">quick view</span></button>
                                                </div>
                                            </div>


                                            <div class=""add-to-cart"">

                                                <button class=""add-to-cart-btn""
                                                        id=""btn""");
                BeginWriteAttribute("idp", "\r\n                                                        idp=\"", 4559, "\"", 4637, 1);
#nullable restore
#line 88 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\UserHome.cshtml"
WriteAttributeValue("", 4622, item.ProductId, 4622, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("namep", "\r\n                                                        namep=\"", 4638, "\"", 4720, 1);
#nullable restore
#line 89 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\UserHome.cshtml"
WriteAttributeValue("", 4703, item.ProductName, 4703, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("pricebp", "\r\n                                                        pricebp=\"", 4721, "\"", 4804, 1);
#nullable restore
#line 90 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\UserHome.cshtml"
WriteAttributeValue("", 4788, item.BasicPrice, 4788, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("pricesp", "\r\n                                                        pricesp=\"", 4805, "\"", 4891, 1);
#nullable restore
#line 91 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\UserHome.cshtml"
WriteAttributeValue("", 4872, item.StandardPrice, 4872, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("priceep", "\r\n                                                        priceep=\"", 4892, "\"", 4980, 1);
#nullable restore
#line 92 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\UserHome.cshtml"
WriteAttributeValue("", 4959, item.EnterprisePrice, 4959, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("categoryp", "\r\n                                                        categoryp=\"", 4981, "\"", 5064, 1);
#nullable restore
#line 93 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\UserHome.cshtml"
WriteAttributeValue("", 5050, item.Category, 5050, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("detailp", "\r\n                                                        detailp=\"", 5065, "\"", 5149, 1);
#nullable restore
#line 94 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\UserHome.cshtml"
WriteAttributeValue("", 5132, item.Description, 5132, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("pocp", "\r\n                                                        pocp=\"", 5150, "\"", 5225, 1);
#nullable restore
#line 95 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\UserHome.cshtml"
WriteAttributeValue("", 5214, productPoc, 5214, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("pocemailp", "\r\n                                                        pocemailp=\"", 5226, "\"", 5310, 1);
#nullable restore
#line 96 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\UserHome.cshtml"
WriteAttributeValue("", 5295, productPocmail, 5295, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("pocphonep", "\r\n                                                        pocphonep=\"", 5311, "\"", 5396, 1);
#nullable restore
#line 97 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\UserHome.cshtml"
WriteAttributeValue("", 5380, productPocphone, 5380, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"
                                                        onclick=""location.href = '/Product/Product';"">
                                                    View Details
                                                </button>

                                            </div>
                                        </div>
");
#nullable restore
#line 104 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\UserHome.cshtml"
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
        </div>
        <!-- /container -->
    </div>
    <!-- /SECTION -->
    <!-- HOT DEAL SECTION -->
    <!--<div id=""hot-deal"" class=""section"">-->
    <!-- container -->
    <!--<div class=""container"">-->
    <!-- row -->
    <!--<div class=""row"">
        <div class=""col-md-12"">
            <div class=""hot-deal"">
                <ul class=""hot-deal-countdown"">
                    <li>
                        <div>
                            <h3>02</h3>
                            <span>Days</span>
                        </div>
                    </li>
                    <li>
                        ");
                WriteLiteral(@"<div>
                            <h3>10</h3>
                            <span>Hours</span>
                        </div>
                    </li>
                    <li>
                        <div>
                            <h3>34</h3>
                            <span>Mins</span>
                        </div>
                    </li>
                    <li>
                        <div>
                            <h3>60</h3>
                            <span>Secs</span>
                        </div>
                    </li>
                </ul>
                <h2 class=""text-uppercase""> Offers this week </h2>
                <p>New Collection Up to 50% OFF</p>
                <a class=""primary-btn cta-btn"" href=""#""> Shop now </a>
            </div>
        </div>
    </div>-->
    <!-- /row -->
    <!--</div>-->
    <!-- /container -->
    <!--</div>-->
    <!-- /HOT DEAL SECTION -->
    <!-- SECTION -->
    <div class=""section"">
        <!-- container -->
   ");
                WriteLiteral(@"     <div class=""container"">
            <!-- row -->
            <div class=""row"">

                <!-- section title -->
                <div class=""col-md-12"">
                    <div class=""section-title"">
                        <h3 class=""title"">Top selling</h3>
                        <div class=""section-nav"">
                            <ul class=""section-tab-nav tab-nav"">
                                <li class=""active""><a data-toggle=""tab"" href=""#tab2"">Category 1</a></li>
                                <li><a data-toggle=""tab"" href=""#tab2"">Category 2</a></li>
                                <li><a data-toggle=""tab"" href=""#tab2"">Category 3</a></li>
                                <li><a data-toggle=""tab"" href=""#tab2"">Category 4</a></li>
                            </ul>
                        </div>
                    </div>
                </div>
                <!-- /section title -->
                <!-- Products tab & slick -->
                <div class=""col-md-12"">
 ");
                WriteLiteral(@"                   <div class=""row"">
                        <div class=""products-tabs"">
                            <!-- tab -->
                            <div id=""tab2"" class=""tab-pane fade in active"">
                                <div class=""products-slick"" data-nav=""#slick-nav-2"">
                                    <!-- product -->
");
#nullable restore
#line 195 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\UserHome.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <div class=\"product\">\r\n                                            <div class=\"product-img\">\r\n                                                <img src=\"/img/product06.png\"");
                BeginWriteAttribute("alt", " alt=\"", 9507, "\"", 9513, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                                <div class=""product-label"">

                                                </div>
                                            </div>

                                            <div class=""product-body"">

                                                <p class=""product-category"">");
#nullable restore
#line 207 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\UserHome.cshtml"
                                                                       Write(Html.DisplayFor(modelItem => item.Category));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                                <br />\r\n                                                <br />\r\n                                                <h2 class=\"product-name\"><a href=\"#\">");
#nullable restore
#line 210 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\UserHome.cshtml"
                                                                                Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</a></h2>


                                                <div class=""product-btns"">
                                                    <button class=""add-to-wishlist""><i class=""fa fa-heart-o""></i><span class=""tooltipp"">add to wishlist</span></button>
                                                    <button class=""add-to-compare""><i class=""fa fa-exchange""></i><span class=""tooltipp"">add to compare</span></button>
                                                    <button class=""quick-view""><i class=""fa fa-eye""></i><span class=""tooltipp"">quick view</span></button>
                                                </div>
                                            </div>

                                            <div class=""add-to-cart"">
                                                <button class=""add-to-cart-btn""> View Details </button>
                                            </div>
                                        </div>
");
#nullable restore
#line 224 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\UserHome.cshtml"


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
        </div>
        <!-- /container -->
    </div>
    <!-- /SECTION -->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26e1d902d53c6a47863fcc02e4c083e1a8b11dbf22243", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SoftwareHub.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591