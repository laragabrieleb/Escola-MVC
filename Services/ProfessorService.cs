using EscolaMVC.Data;
using EscolaMVC.Models.Entities;

namespace EscolaMVC.Services
{
    public class ProfessorService
    {
        private readonly MeuContexto meuContexto;

        public ProfessorService(MeuContexto meuContexto)
        {
            this.meuContexto = meuContexto;
        }

        public async Task Create(Professor professor)
        {
            meuContexto.Add(professor);
            await meuContexto.SaveChangesAsync();
        }
    }
}
