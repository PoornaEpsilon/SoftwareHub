using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoftwareHub.Models;
using Microsoft.EntityFrameworkCore;

namespace SoftwareHub.Controllers
{
    public class RegisterController : Controller
    {
        private readonly ApplicationDBContext _db;

        public RegisterController( ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Test()
        {
            var displayData = _db.register.ToList();
            return View(displayData);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(Register reg)
        {
            if (ModelState.IsValid)
            {
                _db.Add(reg);
                await _db.SaveChangesAsync();
                return RedirectToAction("Test");
            }
            return View(reg);
        }
    }
}
