using System;
using System.Linq;
using System.Web.Http;
using ToDo.Dominio.Entidades;
using ToDo.Negocio.Operacao;

namespace ToDo.WebAPI.Controllers
{
    public class TarefaController : ApiController
    {
        [HttpGet] // api/tarefa
        public IHttpActionResult Get()
        {
            try
            {
                var tarefas = OperacaoTarefa.ObterTodos().ToList();
                return Ok(tarefas);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            } 
        }

        [HttpGet] // api/tarefa/{id}
        public IHttpActionResult Get(int id)
        {
            try
            {
                var tarefa = OperacaoTarefa.ObterPorId(id);
                return Ok(tarefa);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }   
        }
        
        [HttpPost] // api/tarefa
        public IHttpActionResult Post([FromBody]Tarefa tarefa)
        {
            try
            {
                var sucesso = OperacaoTarefa.Salvar(tarefa);
                return Ok(tarefa);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            } 
        }

        [HttpPut] // api/tarefa/5
        public IHttpActionResult Put([FromBody]Tarefa tarefa)
        {
            try
            {
                var sucesso = OperacaoTarefa.Atualizar(tarefa);
                return Ok(tarefa);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpDelete] // api/tarefa/
        public IHttpActionResult Delete([FromBody]Tarefa tarefa)
        {
            try
            {
                var sucesso = OperacaoTarefa.Excluir(tarefa);
                return Ok(tarefa);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        private OperacaoTarefa _operacaoTarefa;
        public OperacaoTarefa OperacaoTarefa
        {
            get => _operacaoTarefa ?? (_operacaoTarefa = new OperacaoTarefa());
            set => _operacaoTarefa = value;
        }
    }
}
