using System;
using System.Collections.Generic;
using System.Linq;
using ToDo.AcessoDados.Repositorio.Interfaces;
using ToDo.Dominio.Entidades;

namespace ToDo.AcessoDados.Repositorio
{
    public class RepositorioSubtarefa : RepositorioBase<Subtarefa>, IRepositorioSubtarefa
    {
        public IEnumerable<Subtarefa> ObterPorIdTarefa(int idTarefa)
        {
            try
            {
                return Contexto.Set<Subtarefa>().Where(x => x.IdTarefa == idTarefa);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
