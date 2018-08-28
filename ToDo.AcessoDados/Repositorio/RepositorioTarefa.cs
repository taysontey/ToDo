using System;
using System.Linq;
using ToDo.AcessoDados.Repositorio.Interfaces;
using ToDo.Dominio.Entidades;

namespace ToDo.AcessoDados.Repositorio
{
    public class RepositorioTarefa : RepositorioBase<Tarefa>, IRepositorioTarefa
    {
        public double ObterProgressoTarefa(bool concluida)
        {
            try
            {
                return Contexto.Set<Tarefa>().Average(x => x.Concluida == concluida ? 1.0 : 0.0) * 100;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
