using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoftwareHub.Models;
namespace SoftwareHub.Controllers
{
    public class LoginController:Controller
    {
        private readonly ApplicationDbContext _db;

        public LoginController(ApplicationDbContext db)
        {
            _db = db;
        }

        db dbop = new db();

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Login([Bind] NewUserClass nu)
        {
            int res = dbop.LoginCheck(nu);
            if(res == 1)
            {
                /*var displayData = _db.product.ToList();
                return View("/Views/Home/UserHome",displayData);*/
                return RedirectToAction("UserHome","Home");
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Signup(NewUserClass nu)
        {
            if (ModelState.IsValid)
            {
                _db.Add(nu);
                await _db.SaveChangesAsync();
                return RedirectToAction("Login");
            }
            return View(nu);
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
