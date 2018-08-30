using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NackowskisMax.Areas.Identity.Pages.Account;
using NackowskisMax.BusinessLogic;
using NackowskisMax.Models;

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