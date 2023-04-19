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
        private readonly ITurmaService turmaService;

        private readonly MeuContexto meuContexto;

        public TurmaController(MeuContexto contexto)
        {
            meuContexto = contexto;
        }

        public async Task<IActionResult> ListarTurmas()
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
    }
}
