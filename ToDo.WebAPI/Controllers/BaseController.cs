using Mapster;
using System;
using System.Collections.Generic;
using System.Web.Http;
using ToDo.Negocio.Operacao;

namespace ToDo.WebAPI.Controllers
{
    public class BaseController<TDTO, T> : ApiController
        where TDTO : class
        where T : class
    {
        [HttpGet] // api/{controller}
        public IHttpActionResult Get()
        {
            try
            {
                var retorno = OperacaoBase.ObterTodos();
                return Ok(retorno.Adapt<IEnumerable<TDTO>>());
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
                var retorno = OperacaoBase.ObterPorId(id);
                return Ok(retorno.Adapt<TDTO>());
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpPost] // api/{controller}
        public IHttpActionResult Post([FromBody]TDTO dto)
        {
            try
            {
                var sucesso = OperacaoBase.Salvar(dto.Adapt<T>());
                return Ok(sucesso);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpPut] // api/{controller}
        public IHttpActionResult Put([FromBody]TDTO dto)
        {
            try
            {
                var sucesso = OperacaoBase.Atualizar(dto.Adapt<T>());
                return Ok(sucesso);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpDelete] // api/{controller}
        public IHttpActionResult Delete(int id)
        {
            try
            {
                var sucesso = OperacaoBase.Excluir(id);
                return Ok(sucesso);
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
