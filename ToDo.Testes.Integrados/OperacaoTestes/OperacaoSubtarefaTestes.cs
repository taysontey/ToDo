using NUnit.Framework;
using System.Linq;
using ToDo.Negocio.Operacao;
using ToDo.Testes.Integrados.Mocks;

namespace ToDo.Testes.Integrados.OperacaoTestes
{
    [TestFixture]
    public class OperacaoSubtarefaTestes
    {
        private OperacaoSubtarefa _operacaoSubtarefa;
        public OperacaoSubtarefa OperacaoSubtarefa
        {
            get => _operacaoSubtarefa ?? (_operacaoSubtarefa = new OperacaoSubtarefa());
            set => _operacaoSubtarefa = value;
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            var sucesso = OperacaoSubtarefa.Salvar(SubtarefaMock.Subtarefa);
            Assert.IsTrue(sucesso, "Erro ao salvar Subtarefa.");
        }

        [OneTimeTearDown]
        public void Dispose()
        {
            var sucesso = OperacaoSubtarefa.Excluir(SubtarefaMock.Subtarefa);
            Assert.IsTrue(sucesso, "Erro ao excluir Subtarefa.");
        }

        [Test]
        public void QuandoAtualizarTarefaDeveRetornarSucesso()
        {
            var sucesso = OperacaoSubtarefa.Atualizar(SubtarefaMock.Subtarefa);
            Assert.IsTrue(sucesso, "Erro ao atualizar Subtarefa.");
        }

        [Test]
        public void QuandoObterTodosDeveRetornarTarefas()
        {
            var tarefas = OperacaoSubtarefa.ObterTodos();
            Assert.IsTrue(tarefas.Any(), "Nenhuma Subtarefa encontrada.");
        }

        [Test]
        public void QuandoObterPorIdDeveRetornarTarefa()
        {
            var tarefa = OperacaoSubtarefa.ObterPorId(SubtarefaMock.Subtarefa.Id);
            Assert.IsNotNull(tarefa, "Subtarefa não encontrada.");
        }
    }
}
