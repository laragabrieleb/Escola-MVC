using EscolaMVC.IServices;
using EscolaMVC.Models.Entities;
using EscolaMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace EscolaMVC.Controllers
{
    public class ProfessorController : Controller
    {
        private readonly ITurmaService turmaService;
        private readonly ProfessorService professorService;

        public ProfessorController(ProfessorService professorService)
        {
            this.professorService = professorService;
        }
        public async Task<IActionResult> Index()
        {
            
        }
    }
}
