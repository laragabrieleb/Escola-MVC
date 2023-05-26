using Microsoft.AspNetCore.Mvc;
using EscolaMVC.Models.Entities;
using EscolaMVC.IServices;
using EscolaMVC.Services;

namespace EscolaMVC.Controllers
{
    public class AlunoController : Controller
    {
        private readonly IAlunoService alunoService;
        private readonly ITurmaService turmaService;

        public AlunoController(IAlunoService alunoService, ITurmaService turmaService)
        {
            this.alunoService = alunoService;
            this.turmaService = turmaService;
        }


        //método usado para obter a lista de alunos 
        public async Task <IActionResult> Index()
        {
            var alunos = await this.alunoService.List();
            return View(alunos);
        }

        public async Task<IActionResult> Create()
        {
            var turmas = await turmaService.List();
            return View(turmas);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Aluno aluno)
        {
            await this.alunoService.Create(aluno);

            return RedirectToAction(nameof(Index));
        }

    }
}
