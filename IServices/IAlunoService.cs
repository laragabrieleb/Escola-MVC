using EscolaMVC.Models.Entities;

namespace EscolaMVC.IServices
{
    public interface IAlunoService
    {
        Task Create(Aluno aluno);

        /// <summary>
        /// buscando todos os registros da tabela alunos e convertendo em uma lista assíncrona
        /// </summary>
        /// <returns>Lista de alunos</returns>
        Task<List<Aluno>> List();
    }
}
