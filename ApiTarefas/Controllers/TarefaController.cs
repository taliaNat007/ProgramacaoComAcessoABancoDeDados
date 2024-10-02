using Microsoft.AspNetCore.Mvc;

namespace ApiTarefas.Controllers
{
    [ApiController]
    [Route("tarefas")] // define a rota da API
            
    public class TarefaController : Controller
    {
        [HttpGet]
        public ActionResult ListarTarefas()
        {
            var lista = ObterTarefas();
            return Ok(lista);
        }

        [HttpGet ("usuario")]
        public IActionResult Usuario()
        {
            return Ok("fernandesnataliadasilva454@gmail.com");
        }

        [HttpPost]
        public IActionResult CriarTarefa([FromBody] Tarefa item) //[FromBody] notação do 'Http Post'
        {
            var tarefa = new Tarefa();
            tarefa.Id = item.Id;
            tarefa.Descricao = item.Descricao;

            var lista = ObterTarefas();

            lista.Add(tarefa);

            return Ok(lista);
        }
        private  List<Tarefa> ObterTarefas()
        {
            List<Tarefa> lista = new List<Tarefa>(){
                new Tarefa {Id = 1, Descricao = " Estudo API 1"},
                new Tarefa {Id = 2, Descricao = " Estudo API 2"},
                new Tarefa {Id = 3, Descricao = " Estudo API 3"},
                
            };
            lista.Add(new Tarefa { Id = 4, Descricao = "Estudo API 4"});
            lista.Add(new Tarefa { Id = 5, Descricao = "Estudo API 5"});
           

            return lista;
        }

        
    }
}
