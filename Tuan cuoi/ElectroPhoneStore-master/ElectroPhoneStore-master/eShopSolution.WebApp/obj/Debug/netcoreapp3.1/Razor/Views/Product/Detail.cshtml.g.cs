#pragma checksum "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Product\Detail.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b28796f8b4fd6c30fc9ac43dd77e93c9faf18387ce525630b27675d219040e70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Detail), @"mvc.1.0.view", @"/Views/Product/Detail.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using eShopSolution.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using eShopSolution.WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using Westwind.AspNetCore.Markdown;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using eShopSolution.Utilities.Constants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using eShopSolution.ViewModels.Sales;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using eShopSolution.WebApp.Controllers.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Product\Detail.cshtml"
using eShopSolution.ViewModels.Catalog.Products;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"b28796f8b4fd6c30fc9ac43dd77e93c9faf18387ce525630b27675d219040e70", @"/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"2ac346e7f22a99f4e21b841fb0137a6d01b672005d66796efbaace03d054480c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDetailViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CommentBox", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Product\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    //Layout = "~/Views/Shared/_Layout.cshtml";
    var culture = CultureInfo.CurrentCulture;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 11 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Product\Detail.cshtml"
  
    //ViewBag.Title = Model.Title;
    var comments = (IEnumerable<ReviewViewModel>)ViewBag.Comments;
    var ratingSum = ViewBag.RatingSum;
    var ratingCount = ViewBag.RatingCount;

    decimal rating = 0;
    if (ratingCount > 0)
    {
        rating = (ratingSum / ratingCount);
    }
    var totalRating = decimal.Parse(rating.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- BREADCRUMB -->
<div id=""breadcrumb"" class=""section"">
    <!-- container -->
    <div class=""container"">
        <!-- row -->
        <div class=""row"">
            <div class=""col-md-12"">
                <ul class=""breadcrumb-tree"">
                    <li><a href=""/"">Trang chủ</a></li>
");
            WriteLiteral("                    <li class=\"active\">");
#nullable restore
#line 35 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                                  Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                </ul>
            </div>
        </div>
        <!-- /row -->
    </div>
    <!-- /container -->
</div>
<!-- /BREADCRUMB -->
<!-- SECTION -->
<div class=""section"">
    <!-- container -->
    <div class=""container"">
        <!-- row -->
        <div class=""row"">
            <!-- Product main img -->
            <div class=""col-md-5 col-md-push-2"">
                <div id=""product-main-img"">
                    <div class=""product-preview"">
                        <img");
            BeginWriteAttribute("src", " src=\"", 1625, "\"", 1691, 1);
#nullable restore
#line 54 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Product\Detail.cshtml"
WriteAttributeValue("", 1631, Configuration["BaseAddress"] + Model.Product.ProductImage, 1631, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1692, "\"", 1698, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                    </div>\n\n                    <div class=\"product-preview\">\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1807, "\"", 1873, 1);
#nullable restore
#line 58 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Product\Detail.cshtml"
WriteAttributeValue("", 1813, Configuration["BaseAddress"] + Model.Product.ProductImage, 1813, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1874, "\"", 1880, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                    </div>\n\n                    <div class=\"product-preview\">\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1989, "\"", 2055, 1);
#nullable restore
#line 62 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Product\Detail.cshtml"
WriteAttributeValue("", 1995, Configuration["BaseAddress"] + Model.Product.ProductImage, 1995, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2056, "\"", 2062, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                    </div>\n\n                    <div class=\"product-preview\">\n                        <img");
            BeginWriteAttribute("src", " src=\"", 2171, "\"", 2237, 1);
#nullable restore
#line 66 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Product\Detail.cshtml"
WriteAttributeValue("", 2177, Configuration["BaseAddress"] + Model.Product.ProductImage, 2177, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2238, "\"", 2244, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                </div>
            </div>
            <!-- /Product main img -->
            <!-- Product thumb imgs -->
            <div class=""col-md-2  col-md-pull-5"">
                <div id=""product-imgs"">
                    <div class=""product-preview"">
                        <img");
            BeginWriteAttribute("src", " src=\"", 2563, "\"", 2629, 1);
#nullable restore
#line 75 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Product\Detail.cshtml"
WriteAttributeValue("", 2569, Configuration["BaseAddress"] + Model.Product.ProductImage, 2569, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2630, "\"", 2636, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                    </div>\n\n                    <div class=\"product-preview\">\n                        <img");
            BeginWriteAttribute("src", " src=\"", 2745, "\"", 2811, 1);
#nullable restore
#line 79 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Product\Detail.cshtml"
WriteAttributeValue("", 2751, Configuration["BaseAddress"] + Model.Product.ProductImage, 2751, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2812, "\"", 2818, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                    </div>\n\n                    <div class=\"product-preview\">\n                        <img");
            BeginWriteAttribute("src", " src=\"", 2927, "\"", 2993, 1);
#nullable restore
#line 83 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Product\Detail.cshtml"
WriteAttributeValue("", 2933, Configuration["BaseAddress"] + Model.Product.ProductImage, 2933, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2994, "\"", 3000, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                    </div>\n\n                    <div class=\"product-preview\">\n                        <img");
            BeginWriteAttribute("src", " src=\"", 3109, "\"", 3175, 1);
#nullable restore
#line 87 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Product\Detail.cshtml"
WriteAttributeValue("", 3115, Configuration["BaseAddress"] + Model.Product.ProductImage, 3115, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3176, "\"", 3182, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                </div>
            </div>
            <!-- /Product thumb imgs -->
            <!-- Product details -->
            <div class=""col-md-5"">
                <div class=""product-details"">
                    <h2 class=""product-name"">");
#nullable restore
#line 95 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                                        Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n\n                    <div>\n                        <h3 class=\"product-price\">");
#nullable restore
#line 98 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                                             Write(Model.Product.Price.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>&#8363;</span> </h3>\n");
#nullable restore
#line 99 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                         if (Model.Product.Stock <= 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"product-available\">Hết hàng</span>\n");
#nullable restore
#line 102 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"product-available\">Còn hàng</span>\n");
#nullable restore
#line 106 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\n\n");
#nullable restore
#line 109 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                     if (Model.Product.Stock == 0)
                    {
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"add-to-cart\" style=\"margin-top:10px\">\n                            <button class=\"add-to-cart-btn\" data-id=\"");
#nullable restore
#line 115 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                                                                Write(Model.Product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i class=\"fa fa-shopping-cart\"></i> thêm vào giỏ hàng</button>\n                        </div>\n");
#nullable restore
#line 117 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <ul class=\"product-links\">\n                        <li>Danh mục:</li>\n                        <li>\n                            ");
#nullable restore
#line 121 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                       Write(Html.ActionLink(Model.Category.Name, "ViewByCategory", "Home", new { cateId = Model.Category.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </li>
                    </ul>
                </div>
            </div>
            <!-- /Product details -->
            <!-- Product tab -->
            <div class=""col-md-12"">
                <div id=""product-tab"">
                    <!-- product tab nav -->
                    <ul class=""tab-nav"">
                        <li class=""active""><a data-toggle=""tab"" href=""#tab1"">Thông số kỹ thuật</a></li>
                        <li><a data-toggle=""tab"" href=""#tab2"">Chi tiết sản phẩm</a></li>
                        <li><a data-toggle=""tab"" href=""#tab3"">Đánh giá</a></li>
                    </ul>
                    <!-- /product tab nav -->
                    <!-- product tab content -->
                    <div class=""tab-content"">
                        <!-- tab1  -->
                        <div id=""tab1"" class=""tab-pane fade in active"">
                            <div class=""row"">
                                <div class=""col-md-12"">
");
#nullable restore
#line 143 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                                      
                                        // Gán giá trị thuộc tính Description của đối tượng Product vào biến html
                                        string html = @Model.Product.Description;
                                        // Khai báo một biến string mới để chứa nội dung HTML của bảng
                                        string tableHtml = "<table class=\"table table-bordered table-striped\">";

                                        // Tách chuỗi html thành các dòng riêng biệt
                                        string[] lines = html.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

                                        // Duyệt qua từng dòng trong chuỗi html
                                        foreach (var line in lines)
                                        {
                                            // Thêm mỗi dòng vào bảng HTML
                                            tableHtml += "<tr><td>" + line + "</td></tr>";
                                        }

                                        // Đóng thẻ bảng
                                        tableHtml += "</table>";
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <!-- In ra nội dung của bảng -->\n                                    ");
#nullable restore
#line 163 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                               Write(Html.Raw(tableHtml));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>

                        <!-- /tab1  -->
                        <!-- tab2  -->
                        <div id=""tab2"" class=""tab-pane fade in"">
                            <div class=""row"">
                                <style>
                                    #more {
                                        display: none;
                                    }
                                </style>
                                <div class=""col-md-12"">
                                    ");
#nullable restore
#line 178 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                               Write(Html.Raw(Model.Product.Details));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                        <!-- /tab2  -->
                        <!-- tab3  -->
                        <div id=""tab3"" class=""tab-pane fade in"">
                            <div class=""row"">
");
#nullable restore
#line 186 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                                 foreach (var c in comments)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <hr />\n                                    <div class=\"row\">\n                                        <div class=\"col-md-3\">\n                                            <span style=\"font-weight:bold\">");
#nullable restore
#line 191 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                                                                      Write(c.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <br />\n                                            <i>");
#nullable restore
#line 192 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                                          Write(c.PublishedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\n                                            <br />\n");
#nullable restore
#line 194 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                                             for (var i = 1; i <= c.Rating; i++)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"starGlowN\"></span>\n");
#nullable restore
#line 197 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 198 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                                             for (var i = (c.Rating + 1); i <= 5; i++)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"starFadeN\"></span>\n");
#nullable restore
#line 201 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </div>\n                                        <div class=\"col-md-9\">\n                                            ");
#nullable restore
#line 204 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                                       Write(Html.Raw(c.Comments.Replace("\n", "<br />")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </div>\n                                    </div>\n");
#nullable restore
#line 207 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <hr />\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b28796f8b4fd6c30fc9ac43dd77e93c9faf18387ce525630b27675d219040e7024813", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
                        <!-- /tab3  -->
                    </div>
                    <!-- /product tab content  -->
                </div>
            </div>
            <!-- /product tab -->
        </div>
        <!-- /row -->
    </div>
    <!-- /container -->
</div>
<!-- /SECTION -->
");
            WriteLiteral(@"<script>
    function myFunction() {
        var dots = document.getElementById(""dots"");
        var moreText = document.getElementById(""more"");
        var btnText = document.getElementById(""myBtn"");

        if (dots.style.display === ""none"") {
            dots.style.display = ""inline"";
            btnText.innerHTML = ""Read more"";
            moreText.style.display = ""none"";
        } else {
            dots.style.display = ""none"";
            btnText.innerHTML = ""Read less"";
            moreText.style.display = ""inline"";
        }
    }

    function SCRate() {
    for (var i = 1; i <= ");
#nullable restore
#line 243 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Product\Detail.cshtml"
                    Write(totalRating);

#line default
#line hidden
#nullable disable
            WriteLiteral("; i++) {\n        $(\"#sRate\" + i).attr(\'class\', \'starGlowN\');\n    }\n    }\n    $(function(){\n        SCRate();\n    });\n</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LazZiya.ExpressLocalization.ISharedCultureLocalizer _loc { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.Extensions.Configuration.IConfiguration Configuration { get; private set; } = default!;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDetailViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
