using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NackowskisMax.BusinessLogic;
using NackowskisMax.Models;

namespace NackowskisMax.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        //private const int groupId = 1000;
        private readonly AuctionFacade _auctionFacade;
        public AdminController(AuctionFacade auctionFacade)
        {
            _auctionFacade = auctionFacade;
        }
        public async Task<IActionResult> Delete(int Id)
        {
            await _auctionFacade.DeleteAuction(Id);
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Create(AuctionItem auction)
        {
            //var auction = new AuctionItem();
            auction.CreatedBy = User.Identity.Name;
            if (ModelState.IsValid)
            {
                await _auctionFacade.CreateAuction(auction);

                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        public async Task<IActionResult> Edit(AuctionItem auction)
        {
            auction.CreatedBy = "testilainen123";

            if (ModelState.IsValid)
            {
                await _auctionFacade.UpdateAuction(auction);

                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        //public IActionResult Edit()
        //{
        //    ViewData["Message"] = "Your application description page.";

        //    return View();
        //}

        //public IActionResult Create()
        //{
        //    ViewData["Message"] = "Your contact page.";

        //    return View();
        //}

        //public IActionResult Delete()
        //{
        //    return View();
        //}
    }
}