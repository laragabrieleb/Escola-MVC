using Microsoft.AspNetCore.Mvc;
using EscolaMVC.Models.Entities;

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
