using Microsoft.AspNetCore.Mvc;
using ExampleApp6.Models;


namespace ExampleApp.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository;
        private string message;
        public HomeController(IRepository repo, IConfiguration config)
        {
            repository = repo;
            message = config["MESSAGE"] ?? "Essential Docker";
        }
        public IActionResult Index()
        {
            ViewBag.Message = message;
            return View(repository.Products);
        }
    }
}