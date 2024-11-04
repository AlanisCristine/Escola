using Escola.Entidade;
using Escola.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Service
{
    public class AlunoService
    {
        private readonly AlunoRepository repository;
        public AlunoService(IConfiguration config)
        {
            repository = new AlunoRepository(config);
        }
        public void Adicionar(Aluno aluno)
        {
            repository.Adicionar(aluno);
        }
        public List<Aluno> Listar()
        {
            return repository.Listar();
        }
    }
}
