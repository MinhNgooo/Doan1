#pragma checksum "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Product\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6ba9e9c1c152b6a48ee447fa9f5c27b7866547318eaa6cc114f6718c734a3125"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
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
#line 1 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\_ViewImports.cshtml"
using eShopSolution.AdminApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\_ViewImports.cshtml"
using eShopSolution.AdminApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6ba9e9c1c152b6a48ee447fa9f5c27b7866547318eaa6cc114f6718c734a3125", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e4e8da686d995cfb018fc8e1b42e7e908f24a53a5e369b9e98447295c33b25a7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<eShopSolution.ViewModels.Catalog.Products.ProductViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Product\Details.cshtml"
  
    ViewData["Title"] = "Chi tiết sản phẩm";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container-fluid\">\n    <h1 class=\"mt-4\">Chi tiết sản phẩm ");
#nullable restore
#line 9 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Product\Details.cshtml"
                                  Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
    <ol class=""breadcrumb mb-4"">
        <li class=""breadcrumb-item""><a style=""color: #0779e4;"" href=""/"">Trang chủ</a></li>
        <li class=""breadcrumb-item active"">Chi tiết sản phẩm</li>
    </ol>
    <div class=""card mb-4"">
        <div class=""card-header"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ba9e9c1c152b6a48ee447fa9f5c27b7866547318eaa6cc114f6718c734a31255585", async() => {
                WriteLiteral("Về danh sách");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"">
                    <tbody>
                        <tr>
                            <td class=""font-weight-bold"">
                                Tên sản phẩm
                            </td>
                            <td>
                                ");
#nullable restore
#line 27 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Product\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td class=""font-weight-bold"">
                                Danh mục
                            </td>
                            <td>
                                ");
#nullable restore
#line 35 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Product\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td class=""font-weight-bold"">
                                Giá tiền
                            </td>
                            <td>
                                ");
#nullable restore
#line 43 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Product\Details.cshtml"
                           Write(Model.Price.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <span>&#8363;</span>
                            </td>
                        </tr>
                        <tr>
                            <td class=""font-weight-bold"">
                                Số lượng
                            </td>
                            <td>
                                ");
#nullable restore
#line 51 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Product\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Stock));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td class=""font-weight-bold"">
                                Thông số kỹ thuật
                            </td>
                            <td>
");
#nullable restore
#line 59 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Product\Details.cshtml"
                                  
                                    // Gán giá trị thuộc tính Description của đối tượng Product vào biến html
                                    string html = @Model.Description;
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
            WriteLiteral("                                <!-- In ra nội dung của bảng -->\n                                ");
#nullable restore
#line 79 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Product\Details.cshtml"
                           Write(Html.Raw(tableHtml));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td class=""font-weight-bold"">
                                Chi tiết sản phẩm
                            </td>
                            <td>
                                <style>
                                    #more {
                                        display: none;
                                    }
                                </style>
                                ");
#nullable restore
#line 92 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Product\Details.cshtml"
                           Write(Html.Raw(Model.Details));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td class=""font-weight-bold"">
                                Ảnh đại diện
                            </td>
                            <td>
                                <img style=""width:150px;height:150px""");
            BeginWriteAttribute("src", " src=\"", 4559, "\"", 4619, 1);
#nullable restore
#line 100 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Product\Details.cshtml"
WriteAttributeValue("", 4565, Configuration["BaseAddress"] + Model.ThumbnailImage, 4565, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Alternate Text"" />
                            </td>
                        </tr>
                        <tr>
                            <td class=""font-weight-bold"">
                                Ảnh đầy đủ
                            </td>
                            <td>
                                <img style=""width:250px;height:250px""");
            BeginWriteAttribute("src", " src=\"", 4975, "\"", 5033, 1);
#nullable restore
#line 108 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Product\Details.cshtml"
WriteAttributeValue("", 4981, Configuration["BaseAddress"] + Model.ProductImage, 4981, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Alternate Text"" />
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>

        </div>
    </div>
</div>
<script>
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
</script>
");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<eShopSolution.ViewModels.Catalog.Products.ProductViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
