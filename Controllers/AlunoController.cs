using Microsoft.AspNetCore.Mvc;

namespace EscolaMVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
