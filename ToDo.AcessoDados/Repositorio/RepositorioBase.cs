using System;
using System.Collections.Generic;
using System.Data.Entity;
using ToDo.AcessoDados.Repositorio.Interfaces;

namespace ToDo.AcessoDados.Repositorio
{
    public class RepositorioBase<TEntity> : IRepositorioBase<TEntity>, IDisposable
        where TEntity : class
    {
        protected Contexto Contexto;

        public RepositorioBase()
        {
            Contexto = new Contexto();
        }

        public virtual bool Salvar(TEntity obj)
        {
            try
            {
                Contexto.Entry(obj).State = EntityState.Added;
                return Convert.ToBoolean(Contexto.SaveChanges());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public virtual bool Atualizar(TEntity obj)
        {
            try
            {
                Contexto.Entry(obj).State = EntityState.Modified;
                return Convert.ToBoolean(Contexto.SaveChanges());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public virtual bool Excluir(int id)
        {
            try
            {
                Contexto.Set<TEntity>().Remove(Contexto.Set<TEntity>().Find(id));
                return Convert.ToBoolean(Contexto.SaveChanges());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public virtual IEnumerable<TEntity> ObterTodos()
        {
            try
            {
                return Contexto.Set<TEntity>();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public virtual TEntity ObterPorId(int id)
        {
            try
            {
                return Contexto.Set<TEntity>().Find(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Dispose()
        {
            Contexto.Dispose();
        }
    }
}
