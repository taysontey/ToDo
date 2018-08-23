using ToDo.AcessoDados.Repositorio;
using ToDo.AcessoDados.Repositorio.Interfaces;
using ToDo.Dominio.Entidades;

namespace ToDo.Negocio.Operacao
{
    public class OperacaoTarefa : OperacaoBase<Tarefa>
    {
        private IRepositorioTarefa _repositorioTarefa;

        public OperacaoTarefa()
        {
            _repositorioTarefa = new RepositorioTarefa();
        }
    }
}
