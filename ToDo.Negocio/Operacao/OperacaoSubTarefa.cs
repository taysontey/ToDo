using System.Collections.Generic;
using ToDo.AcessoDados.Repositorio;
using ToDo.AcessoDados.Repositorio.Interfaces;
using ToDo.Dominio.Entidades;

namespace ToDo.Negocio.Operacao
{
    public class OperacaoSubtarefa : OperacaoBase<Subtarefa>
    {
        private IRepositorioSubtarefa _repositorioSubtarefa;

        public OperacaoSubtarefa()
        {
            _repositorioSubtarefa = new RepositorioSubtarefa();
        }

        public IEnumerable<Subtarefa> ObterPorIdTarefa(int idTarefa)
        {
            return _repositorioSubtarefa.ObterPorIdTarefa(idTarefa);
        }
    }
}
