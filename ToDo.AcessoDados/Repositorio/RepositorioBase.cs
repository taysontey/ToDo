using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ToDo.AcessoDados.Repositorio.Interfaces;

namespace ToDo.AcessoDados.Repositorio
{
    public class RepositorioBase<T> : IRepositorioBase<T>, IDisposable
        where T : class
    {
        protected Contexto Contexto;

        public RepositorioBase()
        {
            Contexto = new Contexto();
        }

        public virtual void Inserir(T obj)
        {
            Contexto.Entry(obj).State = EntityState.Added;
            Contexto.SaveChanges();
        }

        public virtual void Atualizar(T obj)
        {
            Contexto.Entry(obj).State = EntityState.Modified;
            Contexto.SaveChanges();
        }

        public virtual void Excluir(T obj)
        {
            Contexto.Entry(obj).State = EntityState.Deleted;
            Contexto.SaveChanges();
        }

        public virtual List<T> ObterTodos()
        {
            return Contexto.Set<T>().ToList();
        }

        public virtual T ObterPorId(int id)
        {
            return Contexto.Set<T>().Find(id);
        }

        public void Dispose()
        {
            Contexto.Dispose();
        }
    }
}
