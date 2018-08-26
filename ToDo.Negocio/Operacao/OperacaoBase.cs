using System.Collections.Generic;
using ToDo.AcessoDados.Repositorio;
using ToDo.AcessoDados.Repositorio.Interfaces;

namespace ToDo.Negocio.Operacao
{
    public class OperacaoBase<TEntity>
        where TEntity : class
    {
        private IRepositorioBase<TEntity> _repositorioBase;

        public OperacaoBase()
        {
            _repositorioBase = new RepositorioBase<TEntity>();
        }

        public virtual bool Salvar(TEntity obj)
        {
            return _repositorioBase.Salvar(obj);
        }

        public virtual bool Atualizar(TEntity obj)
        {
            return _repositorioBase.Atualizar(obj);
        }

        public virtual bool Excluir(int id)
        {
            return _repositorioBase.Excluir(id);
        }

        public virtual IEnumerable<TEntity> ObterTodos()
        {
            return _repositorioBase.ObterTodos();
        }

        public virtual TEntity ObterPorId(int id)
        {
            return _repositorioBase.ObterPorId(id);
        }
    }
}
