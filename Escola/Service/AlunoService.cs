using Escola.Entidade;
using Escola.Repository;
using Escola.Repository.Interfaces;
using Escola.Service.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Service
{
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepository repository;
        public AlunoService(IAlunoRepository aluno)
        {
            repository = aluno;
        }
        public void Adicionar(Aluno aluno)
        {
            repository.Adicionar(aluno);
        }
        public List<Aluno> Listar()
        {
            return repository.Listar();
        }
        public void Remover(int id)
        {
            repository.Remover(id);
        }
        public Aluno BuscarTimePorId(int id)
        {
            return repository.BuscarPorId(id);
        }
        public void Editar(Aluno editPessoa)
        {
            repository.Editar(editPessoa);
        }

    }
}
