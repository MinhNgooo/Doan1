#pragma checksum "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Shared\Components\Pager\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6169b215d9261573b9edf97f10c37e0a9a716df0905e78ac585cde085fa78fda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Pager_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Pager/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6169b215d9261573b9edf97f10c37e0a9a716df0905e78ac585cde085fa78fda", @"/Views/Shared/Components/Pager/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e4e8da686d995cfb018fc8e1b42e7e908f24a53a5e369b9e98447295c33b25a7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Pager_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<eShopSolution.ViewModels.Common.PagedResultBase>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
  
    // Đọc query string trong url xem pageIndex là bao nhiêu
    var urlTemplate = Url.Action() + "?pageIndex={0}";
    var request = ViewContext.HttpContext.Request;

    // Lặp qua tất cả các key của query string
    foreach (var key in request.Query.Keys)
    {
        if (key == "pageIndex")
        {
            // Nếu là pageIndex thì tiếp tục
            continue;
        }

        // nếu không phải page, nghĩa là có chứa các câu query khác thì sẽ cộng các chuỗi vào
        if (request.Query[key].Count > 1)
        {
            foreach (var item in (string[])request.Query[key])
            {
                urlTemplate += "&" + key + "=" + item;
            }
        }
        else
        {
            urlTemplate += "&" + key + "=" + request.Query[key];
        }
    }

    // Tính vị trí bắt đầu và vị trí kết thúc, dù số trang có > 5 thì cũng chỉ hiển thị 5
    var startIndex = Math.Max(Model.PageIndex - 5, 1);
    var finishIndex = Math.Min(Model.PageIndex + 5, Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 35 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
 if (Model.PageCount > 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <style>
        #pagi a {
            color: #007bff;
            text-decoration: none;
            background-color: transparent;
        }

        #pagi a:link {
            color: #007bff
        }

        #pagi a:hover {
            color: #0056b3;
            text-decoration: underline;
        }

        #pagi a:not([href]):not([class]) {
            color: inherit;
            text-decoration: none;
        }

        #pagi a:not([href]):not([class]):hover {
            color: inherit;
            text-decoration: none;
        }

    </style>
    <ul class=""pagination"" id=""pagi"">
");
#nullable restore
#line 66 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
         if (Model.PageIndex != startIndex)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\n                <a class=\"page-link\" title=\"1\"");
            BeginWriteAttribute("href", " href=\"", 1905, "\"", 1944, 1);
#nullable restore
#line 69 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1912, urlTemplate.Replace("{0}", "1"), 1912, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Đầu</a>\n            </li>\n            <li class=\"page-item\">\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2043, "\"", 2109, 1);
#nullable restore
#line 72 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 2050, urlTemplate.Replace("{0}", (Model.PageIndex-1).ToString()), 2050, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Trước</a>\n            </li>\n");
#nullable restore
#line 74 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
        }

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
         for (var i = startIndex; i <= finishIndex; i++)
        {
            if (i == Model.PageIndex)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item active\">\n                    <a class=\"page-link\" href=\"#\">");
#nullable restore
#line 82 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
                                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"sr-only\">(current)</span></a>\n                </li>\n");
#nullable restore
#line 84 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("title", " title=\"", 2571, "\"", 2598, 2);
            WriteAttributeValue("", 2579, "Trang", 2579, 5, true);
#nullable restore
#line 87 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue(" ", 2584, i.ToString(), 2585, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 2599, "\"", 2647, 1);
#nullable restore
#line 87 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 2606, urlTemplate.Replace("{0}", i.ToString()), 2606, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 87 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
                                                                                                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n");
#nullable restore
#line 88 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
         if (Model.PageIndex != finishIndex)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\n                <a class=\"page-link\"");
            BeginWriteAttribute("title", " title=\"", 2811, "\"", 2846, 1);
#nullable restore
#line 93 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 2819, Model.PageCount.ToString(), 2819, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 2847, "\"", 2913, 1);
#nullable restore
#line 93 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 2854, urlTemplate.Replace("{0}", (Model.PageIndex+1).ToString()), 2854, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sau</a>\n            </li>\n            <li class=\"page-item\">\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3012, "\"", 3074, 1);
#nullable restore
#line 96 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 3019, urlTemplate.Replace("{0}", Model.PageCount.ToString()), 3019, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Cuối</a>\n            </li>\n");
#nullable restore
#line 98 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\n");
#nullable restore
#line 100 "D:\thu moi\temple\ElectroPhoneStore-master\ElectroPhoneStore-master\eShopSolution.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<eShopSolution.ViewModels.Common.PagedResultBase> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591