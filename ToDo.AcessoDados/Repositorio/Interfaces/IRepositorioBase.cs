using System.Collections.Generic;

namespace ToDo.AcessoDados.Repositorio.Interfaces
{
    public interface IRepositorioBase<T>
        where T : class
    {
        bool Salvar(T obj);
        bool Atualizar(T obj);
        bool Excluir(int id);
        IEnumerable<T> ObterTodos();
        T ObterPorId(int id);
    }
}
