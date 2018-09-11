using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NackowskisMax.Areas.Identity.Pages.Account;
using NackowskisMax.BusinessLogic;
using NackowskisMax.Models;
using NackowskisMax.Utility;

namespace NackowskisMax.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;

        //private const int groupId = 1000;
        private readonly AuctionFacade _auctionFacade;
        public AdminController(AuctionFacade auctionFacade,
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender)
        {
            _auctionFacade = auctionFacade;
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
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
        public IActionResult Statistics()
        {
            return View();
        }
        [Route("Admin/AllAuctions/{*date}")]
        public async Task<IActionResult> AllAuctions(DateTime? date = null)
        {
            var stapleVM = new StapleViewModel();
            var highestBidList = new List<double>();
            var estimateList = new List<double>();

            var auctionItems = await _auctionFacade.GetAllAuctionsAsync();

            if (date.HasValue)
            {
                auctionItems = auctionItems.Where(a => a.StartDate.Month == date.Value.Month).ToArray();
            }

            if (auctionItems.Length == 0)
            {
                stapleVM.WinningBidAvg = 0;
                stapleVM.EstimateAvg = 0;
                stapleVM.Difference = 0;

                return PartialView("_AuctionList", stapleVM);
            }

            foreach (var auction in auctionItems)
            {
                auction.OfferList.AddRange(await _auctionFacade.GetAllOffersAsync((int)auction.Id));
                if (auction.OfferList.Count > 0)
                {
                    estimateList.Add((double)auction.Estimate);
                    highestBidList.Add(OfferUtility.GetHighestBid(auction.OfferList));
                }
            }

            stapleVM.WinningBidAvg = highestBidList.Average();
            stapleVM.EstimateAvg = estimateList.Average();
            stapleVM.Difference = OfferUtility.GetAverageDifference(highestBidList, estimateList);

            return PartialView("_AuctionList", stapleVM);
        }

        [Route("Admin/MyAuctions/{*date}")]
        public async Task<IActionResult> MyAuctions(DateTime? date = null)
        {
            var stapleVM = new StapleViewModel();
            var highestBidList = new List<double>();
            var estimateList = new List<double>();

            var auctionItems = await _auctionFacade.GetAllAuctionsAsync();
            if (date.HasValue)
            {
                
                auctionItems = auctionItems.Where(a => a.StartDate.Month == date.Value.Month).ToArray();
                if (auctionItems.Length == 0)
                {
                    stapleVM.WinningBidAvg = 0;
                    stapleVM.EstimateAvg = 0;
                    stapleVM.Difference = 0;

                    return PartialView("_AuctionList", stapleVM);
                }
                foreach (var auction in auctionItems)
                {
                    if (auction.CreatedBy == User.Identity.Name)
                    {
                        auction.OfferList.AddRange(await _auctionFacade.GetAllOffersAsync((int)auction.Id));
                        estimateList.Add((double)auction.Estimate);
                        if (auction.OfferList.Count > 0)
                        {
                            highestBidList.Add(auction.OfferList.Max(x => x.Sum));
                        }
                    }
                }

                stapleVM.WinningBidAvg = highestBidList.Average();
                stapleVM.EstimateAvg = estimateList.Average();
                stapleVM.Difference = (highestBidList.Average() - estimateList.Average());

            }
            

            return PartialView("_AuctionList", stapleVM);
        }
        public IActionResult CreateAdmin()
        {
            var model = new NewAdminInput();
            return View(model);
        }



        [HttpPost]
        public async Task<IActionResult> CreateAdmin(NewAdminInput newAdmin)
        {
            var user = new IdentityUser { UserName = newAdmin.Email, Email = newAdmin.Email };
            var result = await _userManager.CreateAsync(user, newAdmin.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "Admin");

            }
            return RedirectToAction("Index", "Home");

        }


    }
}