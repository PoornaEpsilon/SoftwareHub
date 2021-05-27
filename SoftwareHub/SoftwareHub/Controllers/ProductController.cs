using Microsoft.AspNetCore.Mvc;
using SoftwareHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareHub.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ProductController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Product()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart(Cart cartItem)
        {

            if (ModelState.IsValid)
            {
                _db.Add(cartItem);
                await _db.SaveChangesAsync();
                return RedirectToAction("Product");
            }
            return View("Product");
        }

        public IActionResult AdminHome()
        {
            var productData = _db.product.ToList();
            return View(productData);
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
                return RedirectToAction("AdminHome");
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
                return RedirectToAction("AdminHome");
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
            return RedirectToAction("AdminHome");
        }
    }
}