using ToDo.Dominio.Entidades;

namespace ToDo.AcessoDados.Repositorio.Interfaces
{
    public interface IRepositorioTarefa : IRepositorioBase<Tarefa>
    {
        double ObterProgressoTarefa(bool concluida);
    }
}
