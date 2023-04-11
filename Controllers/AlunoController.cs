using Microsoft.AspNetCore.Mvc;
using EscolaMVC.Models.Entities;
using EscolaMVC.IServices;
using EscolaMVC.Services;

namespace EscolaMVC.Controllers
{
    public class AlunoController : Controller
    {
        private readonly IAlunoService alunoService;

        public AlunoController(IAlunoService alunoService)
        {
            this.alunoService = alunoService;
        }
        public async Task <IActionResult> Index()
        {
            var alunos = await this.alunoService.List();
            return View(alunos);
        }
    }
}
