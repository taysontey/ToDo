using NUnit.Framework;
using System.Linq;
using ToDo.Negocio.Operacao;
using ToDo.Testes.Integrados.Mocks;

namespace ToDo.Testes.Integrados.OperacaoTestes
{
    public class OperacaoBaseTestes
    {
        private OperacaoTarefa _operacaoTarefa;
        public OperacaoTarefa OperacaoTarefa
        {
            get => _operacaoTarefa ?? (_operacaoTarefa = new OperacaoTarefa());
            set => _operacaoTarefa = value;
        }

        private OperacaoSubtarefa _operacaoSubtarefa;
        public OperacaoSubtarefa OperacaoSubtarefa
        {
            get => _operacaoSubtarefa ?? (_operacaoSubtarefa = new OperacaoSubtarefa());
            set => _operacaoSubtarefa = value;
        }

        [SetUp]
        public void Initialize()
        {
            OperacaoTarefa.Salvar(TarefaMock.Tarefa);

            SubtarefaMock.AdicionarTarefa(SubtarefaMock.Subtarefa);
            OperacaoSubtarefa.Salvar(SubtarefaMock.Subtarefa);
        }

        [OneTimeTearDown]
        public void Cleanup()
        {
            var subtarefas = OperacaoSubtarefa.ObterTodos().ToList();

            foreach (var subtarefa in subtarefas)
                OperacaoSubtarefa.Excluir(subtarefa.Id);

            var tarefas = OperacaoTarefa.ObterTodos().ToList();

            foreach (var tarefa in tarefas)
                OperacaoTarefa.Excluir(tarefa.Id);
        }
    }
}
