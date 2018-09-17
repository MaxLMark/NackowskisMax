using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NackowskisMax.BusinessLogic;
using NackowskisMax.Facade;
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

        public async Task<IActionResult> Delete(int id)
        {
            var auction = await _auctionFacade.GetAuctionAsync(id);
            if (auction == null)
            {
                throw new InvalidOperationException("Can't delete non-existing auction.");
            }
            if (auction.CreatedBy != User.Identity.Name)
            {
                throw new UnauthorizedAccessException("Can't delete auctions that you don't own.");
            }

            await _auctionFacade.DeleteAuction(id);
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> CreateBid(Offer offer)
        {
            offer.Bidder = User.Identity.Name;
            var offerlist = await _auctionFacade.GetAllOffersAsync((int)offer.AuctionId);
            int highestbid = await _auctionFacade.CheckOfferBid(offerlist, offer.Sum);
            await _auctionFacade.CreateOffer(offer);

            return RedirectToAction("Index", "Home");
        }
    }
}