using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public virtual bool Salvar(T obj)
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

        public virtual bool Atualizar(T obj)
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
                Contexto.Set<T>().Remove(Contexto.Set<T>().Find(id));
                return Convert.ToBoolean(Contexto.SaveChanges());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public virtual IEnumerable<T> ObterTodos()
        {
            try
            {
                return Contexto.Set<T>();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public virtual T ObterPorId(int id)
        {
            try
            {
                return Contexto.Set<T>().Find(id);
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
