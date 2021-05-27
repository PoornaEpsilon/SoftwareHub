using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PaymentWithPayPalRestAPI.PayPalHelper;
using SoftwareHub.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace SoftwareHub.Controllers
{
    public class CartController : Controller
    {
        private readonly ApplicationDbContext _db;
        public IConfiguration configuration { get; }

        public CartController(ApplicationDbContext db, IConfiguration _configuration)
        {
            _db = db;
            configuration = _configuration;
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

        [HttpPost]
        [Route("Checkout")]
        public IActionResult Checkout(double total)
        {
            var payPalAPI = new PayPalAPI(configuration);
            string url = payPalAPI.GetRedirectURLToPayPal(total, "USD");

            return Redirect(url);
        }

        /*[Route("success")]*/
        public async Task<IActionResult> Success([FromQuery(Name = "paymentId")] string paymentId, [FromQuery(Name = "PayerID")] string payerID)
        {
            var payPalAPI = new PayPalAPI(configuration);
            PayPalPaymentExecutedResponse result = await payPalAPI.executedPayment(paymentId, payerID);

            Debug.WriteLine("Transaction Details");
            /*Debug.WriteLine("cart: " + result.cart);
            Debug.WriteLine("create_time: " + result.create_time.ToLongDateString());
            Debug.WriteLine("id: " + result.id);
            Debug.WriteLine("intent: " + result.intent);
            Debug.WriteLine("links 0-href: " + result.links[0].href);
            Debug.WriteLine("links 0-method: " + result.links[0].method);
            Debug.WriteLine("links 0-rel: " + result.links[0].rel);

            Debug.WriteLine("payer_info-first_name: " + result.payer.Payer_info.first_name);
            Debug.WriteLine("payer_info-last_name: " + result.payer.Payer_info.last_name);
            Debug.WriteLine("payer_info-email: " + result.payer.Payer_info.email);
            Debug.WriteLine("payer_info-billing_address: " + result.payer.Payer_info.billing_address);
            Debug.WriteLine("payer_info-country_code: " + result.payer.Payer_info.country_code);
            Debug.WriteLine("payer_info-shipping_address: " + result.payer.Payer_info.shipping_address);
            Debug.WriteLine("payer_info-payer_id: " + result.payer.Payer_info.payer_id);
            Debug.WriteLine("state: " + result.state);*/




            ViewBag.result = result;
            return View("Success");
        }
    }
}