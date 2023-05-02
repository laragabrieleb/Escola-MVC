using EscolaMVC.Data;
using EscolaMVC.IServices;
using EscolaMVC.Models.Entities;
using EscolaMVC.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace EscolaMVC.Controllers
{
    public class TurmaController : Controller
    {
        private readonly MeuContexto meuContexto;
        private readonly ITurmaService turmaService;

        public TurmaController(MeuContexto contexto, ITurmaService turmaService)
        {
            meuContexto = contexto;
            this.turmaService = turmaService;
        }

        public async Task<IActionResult> Create()
        {
            //ToDo - Listar professores
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Turma turma)
        {
            await this.turmaService.Create(turma);

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Index()
        {
            var turmas = await meuContexto.Turma.ToListAsync();
            return View(turmas);
        }

        //lógica para limitar alunos em uma turma
        //public async Task<IActionResult> LimiteAlunos()
        //{
        //    var vagas = await meuContexto.tur
        //    return View(vagas);
        //}
        public async Task<IActionResult> LimiteAlunos()
        {
            var vagas = await this.turmaService.List();

            ViewBag.Turmas = vagas;

            return View();
        }

        //add turma
        public async Task<IActionResult> AddTurma()
        {
            var addTurma = await this.turmaService.List();

            

            return View();
        }
    }
}
