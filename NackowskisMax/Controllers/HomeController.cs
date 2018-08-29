﻿using System;
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
        private readonly AuctionFacade _auctionFacade;
        public HomeController(AuctionFacade auctionFacade)
        {
            _auctionFacade = auctionFacade;
        }

        //public async Task<IActionResult> Index() {
        //    //string url = http://nackowskis.azurewebsites.net/api/Auktion/1
        //    var items = await _restClient.GetAsync<AuctionItem>("http://nackowskis.azurewebsites.net/api/Auktion/1/2067");
          
        //    return Json(items);
        //}
        public async Task<IActionResult> Index()
        {
            var auctionItemList = new List<AuctionItem>();
            var auctionItems = await _auctionFacade.GetAllAuctionsAsync();
            foreach (var item in auctionItems)
            {
                var offerlist = await _auctionFacade.GetAllOffersAsync((int)item.Id);
                if (offerlist.Length>0)
                {
                    foreach (var offer in offerlist)
                    {
                        item.OfferList.Add(offer);
                    }
                }
                
                auctionItemList.Add(item);
            }

            return View(auctionItemList);
        }

        public async Task<IActionResult> Delete(string deleteAuction)
        {
            
            return View();
        }

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
