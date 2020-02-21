using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DocumoWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Home.cshtml");
        }
    }
}