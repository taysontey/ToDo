using System.Collections.Generic;
using ToDo.Dominio.Entidades;

namespace ToDo.AcessoDados.Repositorio.Interfaces
{
    public interface IRepositorioSubtarefa : IRepositorioBase<Subtarefa>
    {
        IEnumerable<Subtarefa> ObterPorIdTarefa(int idTarefa);
    }
}
