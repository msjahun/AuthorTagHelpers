using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthorTagHelpersAsp_dot_net_core.Models;
using Microsoft.AspNetCore.Mvc;

namespace AuthorTagHelpersAsp_dot_net_core.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(LoginViewModel vm)
        {
            if (ModelState.IsValid)
            {




                return RedirectToAction("Index", "Home");


            }


            return View(vm);
        }

    }
}