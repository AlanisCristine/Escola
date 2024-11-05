using Escola.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Service.Interfaces
{
    public interface IAlunoService
    {
        public void Adicionar(Aluno aluno);
        public List<Aluno> Listar();
    }
}
