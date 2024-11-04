using Escola.Entidade;
using Escola.Service;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly AlunoService _service;

        public AlunoController(IConfiguration config)
        {
            _service = new AlunoService(config);
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

    }
}
