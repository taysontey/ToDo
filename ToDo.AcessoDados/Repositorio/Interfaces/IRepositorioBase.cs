using System.Collections.Generic;

namespace ToDo.AcessoDados.Repositorio.Interfaces
{
    public interface IRepositorioBase<TEntity>
        where TEntity : class
    {
        bool Salvar(TEntity obj);
        bool Atualizar(TEntity obj);
        bool Excluir(int id);
        IEnumerable<TEntity> ObterTodos();
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterPorFiltro(string filtro);
    }
}
