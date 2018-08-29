using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NackowskisMax.BusinessLogic;
using NackowskisMax.Models;

namespace NackowskisMax.Controllers
{
    [Authorize(Roles = "Regular")]
    public class AuctionController : Controller
    {
        private readonly AuctionFacade _auctionFacade;
        public AuctionController(AuctionFacade auctionFacade)
        {
            _auctionFacade = auctionFacade;
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

        public async Task<IActionResult> Delete(int Id)
        {
            await _auctionFacade.DeleteAuction(Id);
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> CreateBid(Offer offer)
        {
            offer.Bidder = User.Identity.Name;

            await _auctionFacade.CreateOffer(offer);
            return RedirectToAction("Index", "Home");
        }
    }
}