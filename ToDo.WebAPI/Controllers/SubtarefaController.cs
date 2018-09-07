using System;
using System.Web.Http;
using ToDo.Dominio.Entidades;
using ToDo.Negocio.Operacao;
using ToDo.WebAPI.Model;
using ToDo.WebAPI.Model.Validator;

namespace ToDo.WebAPI.Controllers
{
    public class SubtarefaController : BaseController<SubtarefaDTO, Subtarefa, SubtarefaDTOValidator>
    {
        [HttpGet] // api/{controller}
        public IHttpActionResult ObterPorIdTarefa(int idTarefa)
        {
            try
            {
                var retorno = OperacaoSubtarefa.ObterPorIdTarefa(idTarefa);
                return Ok(retorno);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        private OperacaoSubtarefa _operacaoSubtarefa;
        public OperacaoSubtarefa OperacaoSubtarefa
        {
            get => _operacaoSubtarefa ?? (_operacaoSubtarefa = new OperacaoSubtarefa());
            set => _operacaoSubtarefa = value;
        }
    }
}
