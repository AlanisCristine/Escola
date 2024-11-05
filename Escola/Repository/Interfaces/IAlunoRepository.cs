using Escola.Entidade;

namespace Escola.Repository.Interfaces
{
    public interface IAlunoRepository
    {
        public void Adicionar(Aluno aluno);
        public List<Aluno> Listar();
    }
}
