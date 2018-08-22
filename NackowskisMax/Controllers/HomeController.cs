using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NackowskisMax.BusinessLogic;
using NackowskisMax.Models;
using NackowskisMax.Utility.Http;

namespace NackowskisMax.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRestClient _restClient;
        private readonly AuctionFacade _auctionFacade;
        public HomeController(IRestClient restClient, AuctionFacade auctionFacade)
        {
            _restClient = restClient;
            _auctionFacade = auctionFacade;
        }

        public async Task<IActionResult> Index() {
            //string url = http://nackowskis.azurewebsites.net/api/Auktion/1
            var items = await _restClient.GetAsync<AuctionItem>("http://nackowskis.azurewebsites.net/api/Auktion/1/2067");
          
            return Json(items);
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
