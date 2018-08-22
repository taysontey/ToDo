using System.Collections.Generic;

namespace ToDo.AcessoDados.Repositorio.Interfaces
{
    public interface IRepositorioBase<T>
        where T : class
    {
        void Inserir(T obj);
        void Atualizar(T obj);
        void Excluir(T obj);
        List<T> ObterTodos();
        T ObterPorId(int id);
    }
}
