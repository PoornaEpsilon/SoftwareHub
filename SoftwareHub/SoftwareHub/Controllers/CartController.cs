using Microsoft.AspNetCore.Mvc;
using SoftwareHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SoftwareHub.Controllers
{
    public class CartController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CartController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Cart()
        {
            var cartData = _db.cart.ToList();
            return View(cartData);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Cart");
            }

            var getCartDetails = await _db.cart.FindAsync(id);
            return View(getCartDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var getCartDetails = await _db.cart.FindAsync(id);
            _db.Remove(getCartDetails);
            await _db.SaveChangesAsync();
            return RedirectToAction("Cart");
        }
    }
}