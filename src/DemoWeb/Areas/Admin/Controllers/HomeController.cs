using DemoWeb.Areas.Admin.Models;
using DemoWebLibrary;
using Microsoft.AspNetCore.Mvc;

namespace DemoWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public readonly ICreateStudent _information;
        public HomeController(ICreateStudent information)
        {
            _information=information;
        }
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(_information);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateStudent information)
        {
            if (ModelState.IsValid)
            {
                await information.StudentCreate();

                return View();
            }
            else
            {
                ViewBag.Massage = "Plese input all required Field";
                return View();
            }

        }
    }
}
