using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebsiteDeneme.Concrete;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebsiteDeneme.Controllers
{
    public class DenemeController : Controller
    {
        private readonly Context _context;
        public DenemeController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var values = _context.Categories.ToList();
            return View(values);
        }
    }
}

