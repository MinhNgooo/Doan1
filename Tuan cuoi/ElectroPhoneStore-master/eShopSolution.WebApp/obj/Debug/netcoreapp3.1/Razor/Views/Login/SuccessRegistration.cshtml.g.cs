#pragma checksum "D:\đồ án\ElectroPhoneStore-master\eShopSolution.WebApp\Views\Login\SuccessRegistration.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "71846336237c42924026641aaec5acb149217ea2c63e0912d80ca409fa355fcb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_SuccessRegistration), @"mvc.1.0.view", @"/Views/Login/SuccessRegistration.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"71846336237c42924026641aaec5acb149217ea2c63e0912d80ca409fa355fcb", @"/Views/Login/SuccessRegistration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"2ac346e7f22a99f4e21b841fb0137a6d01b672005d66796efbaace03d054480c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Login_SuccessRegistration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>

        /******************************************
    35. Login page
    ******************************************/
        .account-login {
            display: inline-block;
            width: 100%;
        }

            .account-login h4 {
                font-weight: 600;
                font-size: 15px;
            }

        .register-benefits h5 {
            font-weight: 600;
            font-size: 13px;
        }

        .box-authentication {
            display: inline-block;
            width: 48%;
            float: left;
        }

            .box-authentication > h3 {
                margin-bottom: 15px;
            }

            .box-authentication label {
                margin-top: 10px;
                margin-bottom: 2px;
            }

            .box-authentication .forgot-pass {
                margin-top: 15px;
            }

            .box-authentication input, .box-authentication textarea {
                border-radius: 3px;
                border: 1px solid #e8e6e2");
            WriteLiteral(@";
                -webkit-box-shadow: inherit;
                box-shadow: inherit;
                width: 50%;
            }

            .box-authentication .button {
                margin-top: 15px;
            }

        button.button {
            display: inline-block;
            border: 0;
            background: #444;
            padding: 6px 16px;
            font-size: 12px;
            border: 1px solid #444;
            font-weight: 500;
            text-align: center;
            white-space: nowrap;
            color: #fff;
            font-weight: normal;
            transition: all 0.3s linear;
            -moz-transition: all 0.3s linear;
            -webkit-transition: all 0.3s linear;
            border-radius: 3px;
        }

            button.button:hover {
                background: #e83f33;
                border: 1px solid #e83f33;
                transition: all 0.3s linear;
                -moz-transition: all 0.3s linear;
                -webkit-transition: all 0.3s linear;
    ");
            WriteLiteral(@"            color: #fff
            }

        button span {
            text-transform: uppercase;
            font-weight: 500;
            letter-spacing: 0.5px;
        }

        .box-authentication .required {
            color: #ff0000;
            padding-left: 3px;
        }

        .box-authentication .inline input {
            width: auto;
        }

        .register-benefits {
            margin-top: 12px;
        }
</style>

<!-- BREADCRUMB -->
<div id=""breadcrumb"" class=""section"">
    <!-- container -->
    <div class=""container"">
        <!-- row -->
        <div class=""row"">
            <div class=""col-md-12"">
                <ul class=""breadcrumb-tree"">
                    <li><a href=""/"">Trang chủ</a></li>
                    <li class=""active"">Đăng ký</li>
                </ul>
            </div>
        </div>
        <!-- /row -->
    </div>
    <!-- /container -->
</div>
<!-- /BREADCRUMB -->
<!-- Main Container -->
<section class=""main-container col1-layout"">
    <div class=""main cont");
            WriteLiteral(@"ainer"">
        <div class=""page-content"">
            <div class=""alert alert-success"" role=""alert"">
                Đăng ký thành công !
            </div>
            <p>
                Mời quý khách kiểm tra email để nhận link xác nhận tài khoản.
            </p>
        </div>
    </div>
</section>
<!-- Main Container End -->

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
