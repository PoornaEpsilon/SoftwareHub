#pragma checksum "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bd53ba7c8262aebda93a74245f28841f7902d80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Home), @"mvc.1.0.view", @"/Views/Home/Home.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bd53ba7c8262aebda93a74245f28841f7902d80", @"/Views/Home/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9c3d39286131762fc08ed4d83557f99b81edb08", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SoftwareHub.Models.Product>>
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
#line 3 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\Home.cshtml"
  
    ViewData["Title"] = "SoftwareHub";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\Home.cshtml"
   
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bd53ba7c8262aebda93a74245f28841f7902d804242", async() => {
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
                                <!-- product -->
                                
");
#nullable restore
#line 44 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\Home.cshtml"
                             foreach (var item in Model) {
                                var productIdent = item.ProductId.ToString();
                                var productName = item.ProductName.ToString();
                                var productbasicPrice = item.BasicPrice.ToString();
                                var productstdPrice = item.StandardPrice.ToString();
                                var productentPrice = item.EnterprisePrice.ToString();
                                var productCategory = item.Category.ToString();
                                var productDetail = item.Description.ToString();
                                var productPoc =item.PocName.ToString();
                                var productPocmail = item.PocEmail.ToString();
                                var productPocphone = item.PocPhone.ToString();


#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                <div class=""product"">
                                    <div class=""product-img"">
                                        <img src=""https://th.bing.com/th/id/R40a32bc2171bb9e3fa93f037abd501b8?rik=tRXv57Ej%2bDbvgw&riu=http%3a%2f%2fwww.pngmart.com%2ffiles%2f4%2fCoder-PNG-Transparent-Image-279x279.png&ehk=PCfc0cXYEX7gDIaODdslAXH9DIGwx5YWAlE52L9L8Jw%3d&risl=&pid=ImgRaw""");
                BeginWriteAttribute("alt", " alt=\"", 2460, "\"", 2466, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                        <div class=""product-label"">        
                                        </div>
                                    </div>

                                    <div class=""product-body"">
                                        <p class=""product-category"">
                                             ");
#nullable restore
#line 65 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\Home.cshtml"
                                        Write(Html.DisplayFor(modelItem => item.Category));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                        </p>
                                        <br/>
                                        <br/>
                                        <h2 class=""product-name"">
                                            <a href=""#"">
                                                 ");
#nullable restore
#line 71 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\Home.cshtml"
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

                                        <button 
                                            class=""add-to-cart-btn"" 
                                            id=""btn""");
                BeginWriteAttribute("idp", " \r\n                                            idp=\"", 4197, "\"", 4264, 1);
#nullable restore
#line 88 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\Home.cshtml"
WriteAttributeValue("", 4249, item.ProductId, 4249, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("namep", " \r\n                                            namep=\"", 4265, "\"", 4336, 1);
#nullable restore
#line 89 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\Home.cshtml"
WriteAttributeValue("", 4319, item.ProductName, 4319, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("pricebp", "\r\n                                            pricebp=\"", 4337, "\"", 4408, 1);
#nullable restore
#line 90 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\Home.cshtml"
WriteAttributeValue("", 4392, item.BasicPrice, 4392, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("pricesp", "\r\n                                            pricesp=\"", 4409, "\"", 4483, 1);
#nullable restore
#line 91 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\Home.cshtml"
WriteAttributeValue("", 4464, item.StandardPrice, 4464, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("priceep", "\r\n                                            priceep=\"", 4484, "\"", 4560, 1);
#nullable restore
#line 92 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\Home.cshtml"
WriteAttributeValue("", 4539, item.EnterprisePrice, 4539, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("categoryp", "\r\n                                            categoryp=\"", 4561, "\"", 4632, 1);
#nullable restore
#line 93 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\Home.cshtml"
WriteAttributeValue("", 4618, item.Category, 4618, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("detailp", " \r\n                                            detailp=\"", 4633, "\"", 4706, 1);
#nullable restore
#line 94 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\Home.cshtml"
WriteAttributeValue("", 4689, item.Description, 4689, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("pocp", "\r\n                                            pocp =\"", 4707, "\"", 4771, 1);
#nullable restore
#line 95 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\Home.cshtml"
WriteAttributeValue("", 4760, productPoc, 4760, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("pocemailp", "\r\n                                            pocemailp =\"", 4772, "\"", 4845, 1);
#nullable restore
#line 96 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\Home.cshtml"
WriteAttributeValue("", 4830, productPocmail, 4830, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("pocphonep", "\r\n                                            pocphonep =\"", 4846, "\"", 4920, 1);
#nullable restore
#line 97 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\Home.cshtml"
WriteAttributeValue("", 4904, productPocphone, 4904, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"
                                            onclick=""location.href = '/Product/Product';""
                                            >
                                            View Details
                                        </button>

                                    </div>
                                </div>
");
#nullable restore
#line 105 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\Home.cshtml"
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
                            <div>
     ");
                WriteLiteral(@"                           <h3>10</h3>
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
<!--");
                WriteLiteral(@" SECTION -->
<div class=""section"">
    <!-- container -->
    <div class=""container"">
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
                <");
                WriteLiteral(@"div class=""row"">
                    <div class=""products-tabs"">
                        <!-- tab -->
                        <div id=""tab2"" class=""tab-pane fade in active"">
                            <div class=""products-slick"" data-nav=""#slick-nav-2"">
                                <!-- product -->
");
#nullable restore
#line 196 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\Home.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div class=\"product\">\r\n                                        <div class=\"product-img\">\r\n                                            <img src=\"/img/product06.png\"");
                BeginWriteAttribute("alt", " alt=\"", 8965, "\"", 8971, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                            <div class=""product-label"">
                                                
                                            </div>
                                        </div>

                                        <div class=""product-body"">

                                            <p class=""product-category"">");
#nullable restore
#line 208 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\Home.cshtml"
                                                                   Write(Html.DisplayFor(modelItem => item.Category));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                            <br/>\r\n                                            <br/>\r\n                                            <h2 class=\"product-name\"><a href=\"#\">");
#nullable restore
#line 211 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\Home.cshtml"
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
#line 225 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Home\Home.cshtml"
                                        

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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bd53ba7c8262aebda93a74245f28841f7902d8021614", async() => {
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
