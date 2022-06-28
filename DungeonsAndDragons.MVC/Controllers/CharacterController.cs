using DungeonsAndDragons.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DungeonsAndDragons.MVC.Controllers
{
    [Authorize]
    public class CharacterController : Controller
    {
        private readonly ApplicationDbContext _ctx;

        //Dependency Injection
        public CharacterController(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        //Index GET
        public IActionResult Index()
        {
            return View();
        }
    }
}
