using ToDo.AcessoDados.Repositorio;
using ToDo.AcessoDados.Repositorio.Interfaces;
using ToDo.Dominio.Entidades;

namespace ToDo.Negocio.Operacao
{
    public class OperacaoSubTarefa : OperacaoBase<SubTarefa>
    {
        private IRepositorioSubTarefa _repositorioSubTarefa;

        public OperacaoSubTarefa()
        {
            _repositorioSubTarefa = new RepositorioSubTarefa();
        }
    }
}
