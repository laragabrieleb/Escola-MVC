using EscolaMVC.Data;
using EscolaMVC.IServices;
using EscolaMVC.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EscolaMVC.Services
{
    public class TurmaService : ITurmaService
    {
        private readonly MeuContexto meuContexto;

        public TurmaService(MeuContexto meuContexto)
        {
            this.meuContexto = meuContexto;
        }

        public async Task Create(Turma turma)
        {
            //adicionar uma turma ao banco de dados e salvar alteração
            meuContexto.Add(turma);
            await meuContexto.SaveChangesAsync();
        }

        // método que busca todos os registros da tabela turma e convertendo em uma lista assíncrona
        public async Task<List<Turma>> List()
        {
            return await meuContexto.Turma.ToListAsync();
        }



    }
}
