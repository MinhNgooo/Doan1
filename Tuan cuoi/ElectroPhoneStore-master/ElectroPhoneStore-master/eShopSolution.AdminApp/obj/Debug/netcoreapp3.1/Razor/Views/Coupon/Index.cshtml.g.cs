#pragma checksum "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Coupon\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ff022c0d423b5a506f872a28d29c6476ab8b203552014444165208e47092b520"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Coupon_Index), @"mvc.1.0.view", @"/Views/Coupon/Index.cshtml")]
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
#nullable restore
#line 1 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Coupon\Index.cshtml"
using eShopSolution.ViewModels.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Coupon\Index.cshtml"
using eShopSolution.ViewModels.Sales;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"ff022c0d423b5a506f872a28d29c6476ab8b203552014444165208e47092b520", @"/Views/Coupon/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e4e8da686d995cfb018fc8e1b42e7e908f24a53a5e369b9e98447295c33b25a7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Coupon_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedResult<CouponViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Coupon", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 5 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Coupon\Index.cshtml"
  
    ViewData["Title"] = "Danh sách khuyến mãi";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <h1 class=""mt-4"">Danh sách khuyến mãi</h1>
    <ol class=""breadcrumb mb-4"">
        <li class=""breadcrumb-item""><a style=""color: #0779e4;"" href=""/"">Trang chủ</a></li>
        <li class=""breadcrumb-item active"">Danh sách khuyến mãi</li>
    </ol>
    <div class=""card mb-12"">
        <div class=""card-header"">
            <div class=""row"">
                <div class=""col-md-7 col-xs-12"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff022c0d423b5a506f872a28d29c6476ab8b203552014444165208e47092b5206732", async() => {
                WriteLiteral("Tạo mới");
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
            WriteLiteral("\n                </div>\n                <div class=\"col-md-5 col-xs-12\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff022c0d423b5a506f872a28d29c6476ab8b203552014444165208e47092b5208295", async() => {
                WriteLiteral("\n                        <div class=\"row\">\n                            <div class=\"col-md-9\">\n");
                WriteLiteral("                                <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1096, "\"", 1120, 1);
#nullable restore
#line 27 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Coupon\Index.cshtml"
WriteAttributeValue("", 1104, ViewBag.Keyword, 1104, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""keyword"" class=""form-control"" />
                            </div>
                            <div class=""col-md-3"">
                                <button type=""submit"" class=""btn btn-info""><i class=""fa fa-search"" aria-hidden=""true""></i></button>
                                <button type=""button"" onclick=""window.location.href='/Coupon/Index'"" class=""btn btn-secondary"">Đặt lại</button>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n\n        <div class=\"card-body\">\n");
#nullable restore
#line 40 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Coupon\Index.cshtml"
             if (TempData["CreateCouponSuccessful"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <script>
                    Swal.fire({
                        position: 'top-end',
                        icon: 'success',
                        title: 'Thêm coupon thành công',
                        showConfirmButton: false,
                        timer: 1500
                    })
                </script>
");
#nullable restore
#line 51 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Coupon\Index.cshtml"
            }
            else if (TempData["UpdateCouponSuccessful"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <script>
                    Swal.fire({
                        position: 'top-end',
                        icon: 'success',
                        title: 'Cập nhật coupon thành công',
                        showConfirmButton: false,
                        timer: 1500
                    })
                </script>
");
#nullable restore
#line 63 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Coupon\Index.cshtml"
            }
            else if (TempData["DeleteCouponSuccessful"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <script>
                    Swal.fire({
                        position: 'top-end',
                        icon: 'success',
                        title: 'Xóa coupon thành công',
                        showConfirmButton: false,
                        timer: 1500
                    })
                </script>
");
#nullable restore
#line 75 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Coupon\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""table-responsive"">
                <table class=""table table-bordered"">
                    <thead>
                        <tr>
                            <th class=""text-center"">
                                ID
                            </th>
                            <th>
                                Mã
                            </th>
                            <th class=""text-center"">
                                Số lượng
                            </th>
                            <th class=""text-center"">
                                Phần trăm giảm
                            </th>
                            <th>
                                Thao tác
                            </th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 98 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Coupon\Index.cshtml"
                         foreach (var item in Model.Items)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td class=\"text-center\">\n                                    ");
#nullable restore
#line 102 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Coupon\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
#nullable restore
#line 105 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Coupon\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
#nullable restore
#line 108 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Coupon\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
#nullable restore
#line 111 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Coupon\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Promotion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n                                <td class=\"text-center\">\n                                    <button class=\"btn btn-primary\">");
#nullable restore
#line 114 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Coupon\Index.cshtml"
                                                               Write(Html.ActionLink("Xem chi tiết", "Details", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n                                    <button class=\"btn btn-success\">");
#nullable restore
#line 115 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Coupon\Index.cshtml"
                                                               Write(Html.ActionLink("Cập nhật", "Edit", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n                                    <button class=\"btn btn-danger\">");
#nullable restore
#line 116 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Coupon\Index.cshtml"
                                                              Write(Html.ActionLink("Xóa", "Delete", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n                                </td>\n                            </tr>\n");
#nullable restore
#line 119 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Coupon\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n                </table>\n            </div>\n");
            WriteLiteral("        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedResult<CouponViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
