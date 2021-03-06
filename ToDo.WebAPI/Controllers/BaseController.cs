﻿using FluentValidation;
using Mapster;
using System;
using System.Collections.Generic;
using System.Web.Http;
using ToDo.Negocio.Operacao;

namespace ToDo.WebAPI.Controllers
{
    public class BaseController<TDTO, TEntity, TValidator> : ApiController
        where TDTO : class
        where TEntity : class
        where TValidator : IValidator
    {
        [HttpGet] // api/{controller}
        public IHttpActionResult ObterTodos()
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
        public IHttpActionResult ObterPorId(int id)
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

        [HttpGet] // api/{controller}
        public IHttpActionResult ObterPorFiltro(string filtro)
        {
            try
            {
                var retorno = OperacaoBase.ObterPorFiltro(filtro);
                return Ok(retorno.Adapt<IEnumerable<TDTO>>());
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpPost] // api/{controller}
        public IHttpActionResult Salvar([FromBody]TDTO dto)
        {
            try
            {
                var resultado = ((IValidator)Activator.CreateInstance(typeof(TValidator))).Validate(dto);

                if (resultado.IsValid)
                {
                    var sucesso = OperacaoBase.Salvar(dto.Adapt<TEntity>());
                    return Ok(sucesso);
                }
                else
                    return BadRequest(resultado.ToString());               
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpPut] // api/{controller}
        public IHttpActionResult Atualizar([FromBody]TDTO dto)
        {
            try
            {
                var resultado = ((IValidator)Activator.CreateInstance(typeof(TValidator))).Validate(dto);

                if (resultado.IsValid)
                {
                    var sucesso = OperacaoBase.Atualizar(dto.Adapt<TEntity>());
                    return Ok(sucesso);
                }
                else
                    return BadRequest(resultado.ToString());
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpDelete] // api/{controller}
        public IHttpActionResult Excluir(int id)
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

        private OperacaoBase<TEntity> _operacaoBase;
        public OperacaoBase<TEntity> OperacaoBase
        {
            get => _operacaoBase ?? (_operacaoBase = new OperacaoBase<TEntity>());
            set => _operacaoBase = value;
        }
    }
}
