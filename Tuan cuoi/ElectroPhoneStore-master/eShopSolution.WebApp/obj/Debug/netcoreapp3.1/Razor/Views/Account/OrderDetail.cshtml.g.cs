#pragma checksum "D:\đồ án\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Account\OrderDetail.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "cd8006799e42726cce6ad97a906b7a18bcf9981f201ecf64f090c22e032b4dfe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_OrderDetail), @"mvc.1.0.view", @"/Views/Account/OrderDetail.cshtml")]
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
#line 1 "D:\đồ án\ElectroPhoneStore-master\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using eShopSolution.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\đồ án\ElectroPhoneStore-master\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using eShopSolution.WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\đồ án\ElectroPhoneStore-master\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\đồ án\ElectroPhoneStore-master\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using Westwind.AspNetCore.Markdown;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\đồ án\ElectroPhoneStore-master\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\đồ án\ElectroPhoneStore-master\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\đồ án\ElectroPhoneStore-master\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\đồ án\ElectroPhoneStore-master\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using eShopSolution.Utilities.Constants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\đồ án\ElectroPhoneStore-master\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using eShopSolution.ViewModels.Sales;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\đồ án\ElectroPhoneStore-master\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using eShopSolution.WebApp.Controllers.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"cd8006799e42726cce6ad97a906b7a18bcf9981f201ecf64f090c22e032b4dfe", @"/Views/Account/OrderDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"2ac346e7f22a99f4e21b841fb0137a6d01b672005d66796efbaace03d054480c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_OrderDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<!-- BREADCRUMB -->
<div id=""breadcrumb"" class=""section"">
    <!-- container -->
    <div class=""container"">
        <!-- row -->
        <div class=""row"">
            <div class=""col-md-12"">
                <ul class=""breadcrumb-tree"">
                    <li><a href=""/"">Trang chủ</a></li>
                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd8006799e42726cce6ad97a906b7a18bcf9981f201ecf64f090c22e032b4dfe5828", async() => {
                WriteLiteral("Tài khoản");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                    <li class=""active"">Chi tiết đơn hàng</li>
                </ul>
            </div>
        </div>
        <!-- /row -->
    </div>
    <!-- /container -->
</div>
<!-- /BREADCRUMB -->

<div class=""main container"">
    <div class=""row"">
        <div class=""col-main col-sm-12 col-xs-12"">
            <div class=""my-account"">
              
                <div class=""row"">
                    <div class=""col-xs-12 col-md-6 col-sm-6"">
                        <div class=""page-title"">
                            <h2>Thông tin đơn hàng</h2>
                        </div>
                        <table class=""table table-bordered cart_summary table-striped"">
                            <tr>
                                <td class=""order-number"">ID</td>
                                <td data-title=""Order Number"">");
#nullable restore
#line 36 "D:\đồ án\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Account\OrderDetail.cshtml"
                                                         Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            </tr>\n                            <tr>\n                                <td class=\"order-number\">Ngày đặt hàng</td>\n                                <td data-title=\"Order Date\">");
#nullable restore
#line 40 "D:\đồ án\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Account\OrderDetail.cshtml"
                                                       Write(Model.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            </tr>\n                            <tr>\n                                <td class=\"order-number\">Trạng thái đơn hàng</td>\n                                <td data-title=\"Order Status\">\n");
#nullable restore
#line 45 "D:\đồ án\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Account\OrderDetail.cshtml"
                                      
                                        var status = "";
                                        var statusEnum = (int)Model.Status;
                                        switch (statusEnum)
                                        {
                                            case 1:
                                                status = "Đang chờ duyệt";
                                                break;
                                            case 2:
                                                status = "Đã duyệt";
                                                break;
                                            case 3:
                                                status = "Đang giao";
                                                break;
                                            case 4:
                                                status = "Đã giao";
                                                break;
                                            case 5:
                                                status = "Đã huỷ";
                                                break;
                                            default:
                                                status = "...";
                                                break;
                                        }
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <i>");
#nullable restore
#line 70 "D:\đồ án\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Account\OrderDetail.cshtml"
                                  Write(status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\n                                </td>\n                            </tr>\n                            <tr>\n                                <td class=\"order-number\">Giá trị đơn hàng</td>\n                                <td>");
#nullable restore
#line 75 "D:\đồ án\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Account\OrderDetail.cshtml"
                               Write(Model.Price.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <span>&#8363;</span></td>
                            </tr>
                        </table>
                    </div>
                    <div class=""col-xs-12 col-md-6 col-sm-6"">
                        <div class=""page-title"">
                            <h2>Thông tin giao hàng</h2>
                        </div>

                        <table class=""table table-bordered cart_summary"">
                            <tr>
                                <td>Tên người nhận</td>
                                <td>");
#nullable restore
#line 87 "D:\đồ án\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Account\OrderDetail.cshtml"
                               Write(Model.ShipName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            </tr>\n                            <tr>\n                                <td>Số điện thoại nhận hàng</td>\n                                <td>");
#nullable restore
#line 91 "D:\đồ án\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Account\OrderDetail.cshtml"
                               Write(Model.ShipPhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            </tr>\n                            <tr>\n                                <td>Địa chỉ nhận hàng</td>\n                                <td>");
#nullable restore
#line 95 "D:\đồ án\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Account\OrderDetail.cshtml"
                               Write(Model.ShipAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            </tr>

                        </table>
                    </div>
                </div>
                    <div class=""row"">
                       
                    </div>
                    <div class=""row"">
                        <div class=""col-xs-12 col-md-12 col-sm-12"">
                            <div class=""page-title"">
                                <h2>Sản phẩm đã mua</h2>
                            </div>
                            <table class=""table table-bordered cart_summary"">
                                <thead>
                                    <tr>
                                        <th class=""text-center"">
                                            ID
                                        </th>
                                        <th class=""text-center"">
                                            Ảnh đại diện
                                        </th>
                                        <th class=""text-center"">
          ");
            WriteLiteral(@"                                  Tên
                                        </th>
                                        <th class=""text-center"">
                                            Giá bán
                                        </th>
                                        <th class=""text-center"">
                                            Số lượng mua
                                        </th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 130 "D:\đồ án\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Account\OrderDetail.cshtml"
                                     foreach (var item in Model.OrderDetails)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\n                                            <td class=\"text-center\">\n                                                ");
#nullable restore
#line 134 "D:\đồ án\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Account\OrderDetail.cshtml"
                                           Write(Html.DisplayFor(item => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            </td>\n                                            <td class=\"text-center\">\n                                                <img style=\"width:100px;height:100px\"");
            BeginWriteAttribute("src", " src=\"", 6469, "\"", 6528, 1);
#nullable restore
#line 137 "D:\đồ án\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Account\OrderDetail.cshtml"
WriteAttributeValue("", 6475, Configuration["BaseAddress"] + item.ThumbnailImage, 6475, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" />\n                                            </td>\n                                            <td class=\"text-center\">\n                                                ");
#nullable restore
#line 140 "D:\đồ án\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Account\OrderDetail.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            </td>\n\n                                            <td class=\"text-center\">\n                                                ");
#nullable restore
#line 144 "D:\đồ án\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Account\OrderDetail.cshtml"
                                           Write(item.Price.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>&#8363;</span>\n                                            </td>\n                                            <td class=\"text-center\">\n                                                ");
#nullable restore
#line 147 "D:\đồ án\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Account\OrderDetail.cshtml"
                                           Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            </td>\n                                        </tr>\n");
#nullable restore
#line 150 "D:\đồ án\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Account\OrderDetail.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\n                            </table>\n                        </div>\n                    </div>\n                </div>\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591