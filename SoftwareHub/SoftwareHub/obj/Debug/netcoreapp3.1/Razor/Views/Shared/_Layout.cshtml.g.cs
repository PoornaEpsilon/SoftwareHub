#pragma checksum "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3dab8abb433377b61ba4d0a112f18133beb8cdf3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dab8abb433377b61ba4d0a112f18133beb8cdf3", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9c3d39286131762fc08ed4d83557f99b81edb08", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:50px;width:150px;margin-top:15px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Signup", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdminLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dab8abb433377b61ba4d0a112f18133beb8cdf37872", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
#nullable restore
#line 7 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</title>



    <!-- Bootstrap -->
    <link type=""text/css"" rel=""stylesheet"" href=""/css/bootstrap.min.css"" />

    <!-- Google font -->
    <link href=""https://fonts.googleapis.com/css?family=Montserrat:400,500,700"" rel=""stylesheet"">
    <!-- Slick -->
    <link type=""text/css"" rel=""stylesheet"" href=""/css/slick.css"" />
    <link type=""text/css"" rel=""stylesheet"" href=""/css/slick-theme.css"" />

    <!-- nouislider -->
    <link type=""text/css"" rel=""stylesheet"" href=""/css/nouislider.min.css"" />

    <!-- Font Awesome Icon -->
    <link rel=""stylesheet"" href=""/css/font-awesome.min.css"">

    <!-- Custom stlylesheet -->
    <link type=""text/css"" rel=""stylesheet"" href=""/css/style.css"" />

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dab8abb433377b61ba4d0a112f18133beb8cdf310042", async() => {
                WriteLiteral(@"
    <!-- HEADER -->
    <header>
        <!-- TOP HEADER -->
        <!-- <div id=""top-header"">
            <div class=""container"">
                <ul class=""header-links pull-left"">
                    <li><a href=""#""><i class=""fa fa-phone""></i> +021-95-51-84</a></li>
                    <li><a href=""#""><i class=""fa fa-envelope-o""></i> email@email.com</a></li>
                    <li><a href=""#""><i class=""fa fa-map-marker""></i> 1734 Stonecoal Road</a></li>
                </ul>
                <ul class=""header-links pull-right"">
                    <li><a href=""#""><i class=""fa fa-dollar""></i> USD</a></li>
                    <li><a href=""#""><i class=""fa fa-user-o""></i> My Account</a></li>
                </ul>
            </div>
        </div> -->
        <!-- /TOP HEADER -->
        <!-- MAIN HEADER -->
        <div id=""header"">
            <!-- container -->
            <div class=""container"">
                <!-- row -->
                <div class=""row"">
                    <!--");
                WriteLiteral(" LOGO -->\r\n                    <div class=\"col-md-3\">\r\n                        <div class=\"header-logo\">\r\n                            <a href=\"#\" class=\"logo\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3dab8abb433377b61ba4d0a112f18133beb8cdf311600", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </a>
                        </div>
                    </div>
                    <!-- /LOGO -->
                    <!-- SEARCH BAR -->

                    <div class=""col-md-6"">
                        <div class=""header-search"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dab8abb433377b61ba4d0a112f18133beb8cdf313162", async() => {
                    WriteLiteral("\r\n                                <select class=\"input-select\">\r\n                                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dab8abb433377b61ba4d0a112f18133beb8cdf313532", async() => {
                        WriteLiteral("All Categories");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dab8abb433377b61ba4d0a112f18133beb8cdf314864", async() => {
                        WriteLiteral("Category 01");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dab8abb433377b61ba4d0a112f18133beb8cdf316193", async() => {
                        WriteLiteral("Category 02");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                </select>\r\n                                <input class=\"input\" placeholder=\"Search here\">\r\n                                <button style=\"padding:4.8px\" class=\"search-btn\">Search</button>\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </div>
                    </div>
                    <!-- /SEARCH BAR -->
                    <!-- ACCOUNT -->
                    <div class=""col-md-3 clearfix"">
                        <div class=""header-ctn"">
                            <!-- Wishlist -->
                            <!-- <div>
                                <a href=""#"">
                                    <i class=""fa fa-heart-o""></i>
                                    <span>Your Wishlist</span>
                                    <div class=""qty"">2</div>
                                </a>
                            </div> -->
                            <!-- /Wishlist -->
                            <div>
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dab8abb433377b61ba4d0a112f18133beb8cdf319550", async() => {
                    WriteLiteral("\r\n                                    <i class=\"fa fa-user-plus\"></i>\r\n                                    <span>SignUp</span>\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </div>
                            <!-- Cart -->
                            <!-- <div class=""dropdown"">
                                <a class=""dropdown-toggle"" data-toggle=""dropdown"" aria-expanded=""true"">
                                    <i class=""fa fa-shopping-cart""></i>
                                    <span>Your Cart</span>
                                    <div class=""qty"">3</div>
                                </a>
                                <div class=""cart-dropdown"">
                                    <div class=""cart-list"">
                                        <div class=""product-widget"">
                                            <div class=""product-img"">
                                                <img src=""/img/product01.png"" alt="""">
                                            </div>
                                            <div class=""product-body"">
                                                <h3 class=""product-name""><");
                WriteLiteral(@"a href=""#"">product name goes here</a></h3>
                                                <h4 class=""product-price""><span class=""qty"">1x</span>$980.00</h4>
                                            </div>
                                            <button class=""delete""><i class=""fa fa-close""></i></button>
                                        </div>

                                        <div class=""product-widget"">
                                            <div class=""product-img"">
                                                <img src=""/img/product02.png"" alt="""">
                                            </div>
                                            <div class=""product-body"">
                                                <h3 class=""product-name""><a href=""#"">product name goes here</a></h3>
                                                <h4 class=""product-price""><span class=""qty"">3x</span>$980.00</h4>
                                            </div>
                     ");
                WriteLiteral(@"                       <button class=""delete""><i class=""fa fa-close""></i></button>
                                        </div>
                                    </div>
                                    <div class=""cart-summary"">
                                        <small>3 Item(s) selected</small>
                                        <h5>SUBTOTAL: $2940.00</h5>
                                    </div>
                                    <div class=""cart-btns"">
                                        <a href=""#"">View Cart</a>
                                        <a href=""#"">Checkout  <i class=""fa fa-arrow-circle-right""></i></a>
                                    </div>
                                </div>
                            </div> -->
                            <!-- /Cart -->

                            <div>
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dab8abb433377b61ba4d0a112f18133beb8cdf324529", async() => {
                    WriteLiteral("\r\n                                    <i class=\"fa fa-sign-in\"></i>\r\n                                    <span>Login</span>\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </div>

                            <!-- Menu Toogle -->
                            <div class=""menu-toggle"">
                                <a href=""#"">
                                    <i class=""fa fa-bars""></i>
                                    <span>Menu</span>
                                </a>
                            </div>
                            <!-- /Menu Toogle -->
                        </div>
                    </div>
                    <!-- /ACCOUNT -->
                </div>
                <!-- row -->
            </div>
            <!-- container -->
        </div>
        <!-- /MAIN HEADER -->
    </header>
    <!-- /HEADER -->
    <!-- NAVIGATION -->
    <nav id=""navigation"">
        <!-- container -->
        <div class=""container"">
            <!-- responsive-nav -->
            <div id=""responsive-nav"">
                <!-- NAV -->
                <!-- <ul class=""main-nav nav navbar-nav"">
                    <l");
                WriteLiteral(@"i class=""active""><a href=""#"">Home</a></li>
                    <li><a href=""#"">Products</a></li>
                    <li><a href=""#"">Best Software</a></li>
                    <li><a href=""#"">Categories</a></li>
                    <li><a href=""#"">Category-1</a></li>
                    <li><a href=""#"">Category-2</a></li>
                    <li><a href=""#"">Category-3</a></li>
                    <li><a href=""#"">Category-4</a></li>
                </ul> -->
                <!-- /NAV -->
            </div>
            <!-- /responsive-nav -->
        </div>
        <!-- /container -->
    </nav>
    <!-- /NAVIGATION -->
    <div class=""container"">
        <main role=""main"" class=""pb-3"">
            ");
#nullable restore
#line 230 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </main>
    </div>

    <!-- FOOTER -->
    <footer id=""footer"">
        <!-- top footer -->
        <div class=""section"">
            <!-- container -->
            <div class=""container"">
                <!-- row -->
                <div class=""row"">
                    <div class=""col-md-3 col-xs-6"">
                        <div class=""footer"">
                            <h3 class=""footer-title"">Contact Us</h3>
                            <p>Epsilon</p>
                            <ul class=""footer-links"">
                                <li><a href=""#""><i class=""fa fa-map-marker""></i>Bengaluru</a></li>
                                <li><a href=""#""><i class=""fa fa-phone""></i>+021-95-51-84</a></li>
                                <li><a href=""#""><i class=""fa fa-envelope-o""></i>email@email.com</a></li>
                            </ul>
                        </div>
                    </div>

                    <div class=""col-md-3 col-xs-6"">
                        <di");
                WriteLiteral(@"v class=""footer"">
                            <h3 class=""footer-title"">Categories</h3>
                            <ul class=""footer-links"">
                                <li><a href=""#"">Best Software</a></li>
                                <li><a href=""#"">Cloud</a></li>
                                <li><a href=""#"">Data Science</a></li>
                                <li><a href=""#"">Data Analytics</a></li>
                            </ul>
                        </div>
                    </div>

                    <div class=""clearfix visible-xs""></div>

                    <div class=""col-md-3 col-xs-6"">
                        <div class=""footer"">
                            <h3 class=""footer-title"">Information</h3>
                            <ul class=""footer-links"">
                                <li><a href=""#"">About Us</a></li>
                                <li><a href=""#"">Privacy Policy</a></li>
                                <li><a href=""#"">Terms & Conditions</a></li>");
                WriteLiteral(@"
                            </ul>
                        </div>
                    </div>

                    <div class=""col-md-3 col-xs-6"">
                        <div class=""footer"">
                            <h3 class=""footer-title"">Service</h3>
                            <ul class=""footer-links"">
                                <li><a href=""#"">My Account</a></li>
                                <li><a href=""#"">View Cart</a></li>
                                <li><a href=""#"">Help</a></li>
                            </ul>
                        </div>
                    </div>
                </div>
                <!-- /row -->
            </div>
            <!-- /container -->
        </div>
        <!-- /top footer -->
        <!-- bottom footer -->
        <div id=""bottom-footer"" class=""section"">
            <div class=""container"">
                <!-- row -->
                <div class=""row"">
                    <div class=""col-md-12 text-center"">
              ");
                WriteLiteral(@"          <!-- <ul class=""footer-payments"">
                            <li><a href=""#""><i class=""fa fa-cc-visa""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-credit-card""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-cc-paypal""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-cc-mastercard""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-cc-discover""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-cc-amex""></i></a></li>
                        </ul> -->

                        <span class=""copyright"">
                            <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                            Copyright &copy;
                            <script>document.write(new Date().getFullYear());</script> All rights reserved | Software Hub
                            <!-- Link back to Colorlib can't be removed. Template is li");
                WriteLiteral("censed under CC BY 3.0. -->\r\n                        </span>\r\n                        <div>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dab8abb433377b61ba4d0a112f18133beb8cdf332970", async() => {
                    WriteLiteral("\r\n                                <i class=\"fa fa-sign-in\"></i>\r\n                                <span>Admin Login</span>\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <!-- /row -->
            </div>
            <!-- /container -->
        </div>
        <!-- /bottom footer -->
    </footer>
    <!-- /FOOTER -->
    <!-- jQuery Plugins -->
    <script src=""/js/jquery.min.js""></script>
    <script src=""/js/bootstrap.min.js""></script>
    <script src=""/js/slick.min.js""></script>
    <script src=""/js/nouislider.min.js""></script>
    <script src=""/js/jquery.zoom.min.js""></script>
    <script src=""/js/main.js""></script>
    ");
#nullable restore
#line 338 "C:\Users\poocm\Documents\GitHub\SoftwareHub\SoftwareHub\SoftwareHub\SoftwareHub\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
