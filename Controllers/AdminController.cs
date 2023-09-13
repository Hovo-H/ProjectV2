using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Data.Entities;

namespace WebApplication1.Controllers
{
    public class AdminController : Controller
    {
        private readonly MyShopDataContext _context;
        public AdminController(MyShopDataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddUpdateUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddUpdateUser(User user)
        {
            _context.Add(user);
            _context.SaveChanges();
            return View(user);
        }
    }
}
