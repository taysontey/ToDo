using System;
using System.Linq;
using System.Web.Http;
using ToDo.Negocio.Operacao;

namespace ToDo.WebAPI.Controllers
{
    public class BaseController<T> : ApiController
        where T : class
    {
        [HttpGet] // api/{controller}
        public IHttpActionResult Get()
        {
            try
            {
                var retorno = OperacaoBase.ObterTodos().ToList();
                return Ok(retorno);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpGet] // api/{controller}/{id}
        public IHttpActionResult Get(int id)
        {
            try
            {
                var tarefa = OperacaoBase.ObterPorId(id);
                return Ok(tarefa);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpPost] // api/{controller}
        public IHttpActionResult Post([FromBody]T obj)
        {
            try
            {
                var sucesso = OperacaoBase.Salvar(obj);
                return Ok(obj);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpPut] // api/{controller}
        public IHttpActionResult Put([FromBody]T obj)
        {
            try
            {
                var sucesso = OperacaoBase.Atualizar(obj);
                return Ok(obj);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpDelete] // api/{controller}
        public IHttpActionResult Delete([FromBody]T obj)
        {
            try
            {
                var sucesso = OperacaoBase.Excluir(obj);
                return Ok(obj);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        private OperacaoBase<T> _operacaoBase;
        public OperacaoBase<T> OperacaoBase
        {
            get => _operacaoBase ?? (_operacaoBase = new OperacaoBase<T>());
            set => _operacaoBase = value;
        }
    }
}
