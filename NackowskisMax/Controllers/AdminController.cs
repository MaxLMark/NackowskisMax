using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NackowskisMax.Controllers
{
    public class AdminController : Controller
    {
        public async Task<IActionResult> Delete(string deleteAuction)
        {

            return View();
        }
    }
}