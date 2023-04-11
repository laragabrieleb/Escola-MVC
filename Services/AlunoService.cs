using EscolaMVC.Data;
using EscolaMVC.IServices;
using EscolaMVC.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EscolaMVC.Services
{
    public class AlunoService : IAlunoService
    {
        private readonly MeuContexto meuContexto;

        public AlunoService(MeuContexto meuContexto)
        {
            this.meuContexto = meuContexto;
        }

        public async Task Create(Aluno aluno)
        {
            //adicionar um aluno ao banco de dados e salvar alteração
            meuContexto.Add(aluno);
            await meuContexto.SaveChangesAsync();
        }

        public async Task<List<Aluno>> List()
        {
            return await meuContexto.Aluno.ToListAsync();
        }
    }
}
