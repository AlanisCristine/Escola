using Escola.Entidade;
using Escola.Service;
using Escola.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoService _service;

        public AlunoController(IAlunoService aluno)
        {
            _service = aluno;
        }

        [HttpPost("Adicionar-aluno")]
        public void AdicionarAluno(Aluno aluno)
        {
            _service.Adicionar(aluno);
        }
        [HttpGet("listar-aluno")]
        public List<Aluno> ListarAluno()
        {
            return _service.Listar();
        }

        [HttpPut("editar-usuario")]
        public void EditarUsuario(Aluno a)
        {
            _service.Editar(a);
        }
        [HttpDelete("deletar-usuario")]
        public void DeletarUsuario(int id)
        {
            _service.Remover(id);
        }

    }
}
