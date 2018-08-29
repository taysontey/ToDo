using System;
using System.Web.Http;
using ToDo.Dominio.Entidades;
using ToDo.Negocio.Operacao;
using ToDo.WebAPI.Model;

namespace ToDo.WebAPI.Controllers
{
    public class TarefaController : BaseController<TarefaDTO, Tarefa>
    {
        [HttpGet] // api/{controller}
        public IHttpActionResult ObterProgressoTarefa(bool concluida)
        {
            try
            {
                var retorno = OperacaoTarefa.ObterProgressoTarefa(concluida);
                return Ok(retorno);
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
