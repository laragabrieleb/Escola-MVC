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


        //método usado para obter a lista de alunos e exibir para o usuário
        public async Task <IActionResult> Index()
        {
            var alunos = await this.alunoService.List();
            return View(alunos);
        }

        public async Task<IActionResult> Create()
        {
            //criar um turmaService - ok
            //criar método de listar turmas no turma Service
            //instanciar o TurmaService neste controller (igual fez com alunoService)
            //chamar o método this.turmaService.List() e armazenar em uma ViewBag
            //utilizar a viewbag lá no Create.cshtml
            var turmas = await this.turmaService.List();

            ViewBag.Turmas = turmas;

            return View();
        }

        
        //mostar opção de turma para o aluno
    }
}
