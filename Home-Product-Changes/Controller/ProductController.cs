using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace DatabaseLink.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Product()
        {
            
            return View();
        }
    }
}
