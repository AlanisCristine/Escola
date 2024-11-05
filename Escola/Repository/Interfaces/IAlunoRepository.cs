using Escola.Entidade;

namespace Escola.Repository.Interfaces
{
    public interface IAlunoRepository
    {
        public void Adicionar(Aluno aluno);
        public List<Aluno> Listar();
        public void Remover(int id);
        public void Editar(Aluno usuario);
        public Aluno BuscarPorId(int id);
    }
}
