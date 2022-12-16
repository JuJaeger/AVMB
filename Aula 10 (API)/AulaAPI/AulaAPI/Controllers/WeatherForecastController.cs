using Microsoft.AspNetCore.Mvc;

namespace AulaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class APIController : ControllerBase
    {
        [HttpGet("hello")]
        public string HelloWorld()
        {
            return "Hello World API Net6";
        }

        //Nome
        [HttpGet("nome")]
        public string Nome()
        {
            return "Julia Jaeger";
        }

        //Idade
        [HttpGet("idade")]
        public string Idade()
        {
            return "16";
        }

        //Recebe Nome
        [HttpGet("recebeNome/{nome}")]
        public string RecebeNome([FromRoute] string nome)
        {
            return nome;
        }

        //Maior/Menor de idade
        [HttpPost("maiorIdade/{idade}")]
        public string MaiorIdade(
            [FromBody] string nome,
            [FromRoute] int idade
            )
        {
            if (idade >= 18)
            {
                return "A " + nome + " é maior de idade";
            }
            else
            {
                return "A " + nome + " é menor de idade";
            }
        }
    }
}