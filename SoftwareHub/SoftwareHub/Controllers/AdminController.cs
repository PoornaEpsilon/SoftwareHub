using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoftwareHub.Models;
using Microsoft.AspNetCore.Http;

namespace SoftwareHub.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AdminController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult AdminLogin()
        {
            return View("AdminLogin");
        }

       
        public IActionResult AdminView()
        {
            
            var productData = _db.product.ToList();
            return View(productData);
               
        }

        [HttpPost]
        public IActionResult AdminHome(IFormCollection formData)
        {
            var loginData = _db.login.ToList();

            foreach (var item in loginData)
            {
                if(item.Username.Equals(formData["username"]) && item.Password.Equals(formData["password"]))
                {
                    ViewBag.TestData = formData["test"];
                    var productData = _db.product.ToList();
                    return View("AdminHome", productData);
                }
                else
                {
                    return RedirectToAction("AdminLogin");
                }
            }

            return View("AdminHome");
        }

        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(Product prod)
        {
            if (ModelState.IsValid)
            {
                _db.Add(prod);
                await _db.SaveChangesAsync();
                return RedirectToAction("AdminView");
            }
            return View(prod);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("AdminHome");
            }

            var getProductDetails = await _db.product.FindAsync(id);
            return View(getProductDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Product ap)
        {
            if (ModelState.IsValid)
            {
                _db.Update(ap);
                await _db.SaveChangesAsync();
                return RedirectToAction("AdminView");
            }

            return View(ap);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("AdminHome");
            }

            var getProductDetails = await _db.product.FindAsync(id);
            return View(getProductDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var getProductDetails = await _db.product.FindAsync(id);
            _db.Remove(getProductDetails);
            await _db.SaveChangesAsync();
            return RedirectToAction("AdminView");
        }

    }
}
