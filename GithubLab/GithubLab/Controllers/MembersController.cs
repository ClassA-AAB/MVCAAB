using Microsoft.AspNetCore.Mvc;

namespace GithubLab.Controllers
{
    public class MembersController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}