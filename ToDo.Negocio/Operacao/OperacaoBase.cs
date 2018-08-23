using System.Collections.Generic;
using ToDo.AcessoDados.Repositorio;
using ToDo.AcessoDados.Repositorio.Interfaces;

namespace ToDo.Negocio.Operacao
{
    public class OperacaoBase<T>
        where T : class
    {
        private IRepositorioBase<T> _repositorioBase;

        public OperacaoBase()
        {
            _repositorioBase = new RepositorioBase<T>();
        }

        public virtual bool Salvar(T obj)
        {
            return _repositorioBase.Salvar(obj);
        }

        public virtual bool Atualizar(T obj)
        {
            return _repositorioBase.Atualizar(obj);
        }

        public virtual bool Excluir(T obj)
        {
            return _repositorioBase.Excluir(obj);
        }

        public virtual IEnumerable<T> ObterTodos()
        {
            return _repositorioBase.ObterTodos();
        }

        public virtual T ObterPorId(int id)
        {
            return _repositorioBase.ObterPorId(id);
        }
    }
}
