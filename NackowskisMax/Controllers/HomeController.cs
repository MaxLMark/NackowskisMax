using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NackowskisMax.Models;
using NackowskisMax.Facade;
using NackowskisMax.Utility.Http;
using NackowskisMax.BusinessLogic;

namespace NackowskisMax.Controllers
{
    public class HomeController : Controller
    {
        private readonly AuctionFacade _auctionFacade;
        public HomeController(AuctionFacade auctionFacade)
        {
            _auctionFacade = auctionFacade;
        }

        public async Task<IActionResult> Index()
        {
            var auctionItems = await _auctionFacade.GetAllAuctionsAsync();
            var auctionItemList = await _auctionFacade.CheckActivity(auctionItems);

            return View(auctionItemList);
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
