#pragma checksum "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\SalesRecord\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7b589a1e1a01a67f50823c0a7b2980b2aaf22f43eabd4760f575c808ca5c728c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SalesRecord_Index), @"mvc.1.0.view", @"/Views/SalesRecord/Index.cshtml")]
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
#line 1 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\SalesRecord\Index.cshtml"
using eShopSolution.ViewModels.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"7b589a1e1a01a67f50823c0a7b2980b2aaf22f43eabd4760f575c808ca5c728c", @"/Views/SalesRecord/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e4e8da686d995cfb018fc8e1b42e7e908f24a53a5e369b9e98447295c33b25a7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_SalesRecord_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedResult<eShopSolution.ViewModels.Catalog.Products.ProductViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\SalesRecord\Index.cshtml"
  
    ViewData["Title"] = "Danh sách sản phẩm";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-bordered"">
    <thead>
        <tr>
            <th class=""text-center"">
                ID
            </th>
            <th class=""text-center"">
                Ảnh đại diện
            </th>
            <th>
                Tên
            </th>
            <th class=""text-center"">
                Giá bán
            </th>
            <th class=""text-center"">
                Số lượng tồn
            </th>
            <th class=""text-center"">
                Thao tác
            </th>
        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 34 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\SalesRecord\Index.cshtml"
         foreach (var item in Model.Items)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n         \r\n                <td class=\"text-center\">\r\n                    ");
#nullable restore
#line 39 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\SalesRecord\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Stock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n           \r\n            </tr>\r\n");
#nullable restore
#line 43 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\SalesRecord\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedResult<eShopSolution.ViewModels.Catalog.Products.ProductViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
