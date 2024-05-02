using eShopSolution.AdminApp.Models;
using eShopSolution.ApiIntegration;
using eShopSolution.Utilities.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.AdminApp.Controllers
{
    // Authorize: Sẽ chuyển sang trang User/Login ( định nghĩa trong startup bằng serivces.AddAuthorization )
    // Sau đó phải đăng nhập rồi mới được dùng mấy trang này
    //[Authorize]
    public class HomeController : BaseController
    {
        private readonly IUserApiClient _userApiClient;
        private readonly IProductApiClient _productApiClient;
        private readonly IConfiguration _configuration;
        private readonly ILogger<HomeController> _logger;
        private readonly IOrderApiClient _orderApiClient;

        public HomeController(IProductApiClient productApiClient,
            IConfiguration configuration, ILogger<HomeController> logger,
            IUserApiClient userApiClient, IOrderApiClient orderApiClient
            )
        {
            _orderApiClient = orderApiClient;
            _userApiClient = userApiClient;
            _configuration = configuration;
            _productApiClient = productApiClient;
            _logger = logger;
        }
   
        public async Task<IActionResult> Index()
        {
            // lấy user name đăng nhập
            var user = User.Identity.Name;
            var expireTime = HttpContext.Items["ExpiresUTC"];

            //
            var products = await _productApiClient.GetAll();
            var stockByCategory = await _productApiClient.GetStockByCategory();
            var distinctProductIds = products.Select(p => p.Id).Distinct();
            var totalStock = distinctProductIds.Count();
            ViewBag.TotalStock = totalStock;
            ViewBag.Products = products;
            ViewBag.StockByCategory = stockByCategory;
            //
            var totaluser = await _userApiClient.GetAll();
            var countusers = totaluser.Select(p => p.Id).Count();
            ViewBag.countusers = countusers;
            //
            var totaloder = await _orderApiClient.GetAll();
            var countoders = totaloder.Select(o => o.Id).Count();
            ViewBag.countoders = countoders;
            var totalrevenue = totaloder.Sum(o => o.Price).ToString("#,##0.##");
            ViewBag.totalrevenue = totalrevenue;

            //
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // Trang error
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    

        [HttpPost]
        public IActionResult Language(NavigationViewModel viewModel)
        {
            HttpContext.Session.SetString(SystemConstants.AppSettings.DefaultLanguageId,
                viewModel.CurrentLanguageId);

            return Redirect(viewModel.ReturnUrl);
        }
    }
}