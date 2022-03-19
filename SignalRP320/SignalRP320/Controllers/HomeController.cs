using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SignalRP320.Models;
using SignalRP320.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRP320.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public HomeController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        //public async Task<IActionResult> UserCreate()
        //{
        //    AppUser user1 = new AppUser() { FullName = "Ilkin Bayramov", UserName = "Ilkin" };
        //    AppUser user2 = new AppUser() { FullName = "Elvin Alizadeh", UserName = "Elvin" };
        //    AppUser user3 = new AppUser() { FullName = "Namiq Haydarov", UserName = "Namiq" };
        //    AppUser user4 = new AppUser() { FullName = "Idris Ceferzade", UserName = "Idris" };
        //    AppUser user5 = new AppUser() { FullName = "Aytac Ramazanli", UserName = "Aytac" };

        //    var result1 = await _userManager.CreateAsync(user1, "User@123");
        //    var result2 = await _userManager.CreateAsync(user2, "User@123");
        //    var result3 = await _userManager.CreateAsync(user3, "User@123");
        //    var result4 = await _userManager.CreateAsync(user4, "User@123");
        //    var result5 = await _userManager.CreateAsync(user5, "User@123");

        //    return Content("okey");
        //}

        public async Task<IActionResult> Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM login)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var user =await  _userManager.FindByNameAsync(login.UserName);

            var result =await _signInManager.PasswordSignInAsync(user, login.Password, false, false);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Password or UserName incorrect");
            }


            return RedirectToAction("Chat");
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Chat");
        }
        

        public IActionResult Index()
        {
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
        public IActionResult Chat()
        {
            var models = _userManager.Users.ToList();
            return View(models);
        }
    }
}
