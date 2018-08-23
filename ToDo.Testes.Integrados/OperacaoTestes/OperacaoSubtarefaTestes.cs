using NUnit.Framework;
using System.Linq;
using ToDo.Negocio.Operacao;
using ToDo.Testes.Integrados.Mocks;

namespace ToDo.Testes.Integrados.OperacaoTestes
{
    [TestFixture]
    public class OperacaoSubtarefaTestes
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
            var sucesso = OperacaoTarefa.Salvar(TarefaMock.Tarefa);
            Assert.IsTrue(sucesso, "Erro ao salvar Tarefa.");

            SubtarefaMock.AdicionarIdTarefa();
            sucesso = OperacaoSubtarefa.Salvar(SubtarefaMock.Subtarefa);
            Assert.IsTrue(sucesso, "Erro ao salvar Subtarefa.");
        }

        [TearDown]
        public void Dispose()
        {
            var sucesso = OperacaoSubtarefa.Excluir(SubtarefaMock.Subtarefa);
            Assert.IsTrue(sucesso, "Erro ao excluir Subtarefa.");

            sucesso = OperacaoTarefa.Excluir(TarefaMock.Tarefa);
            Assert.IsTrue(sucesso, "Erro ao excluir Tarefa.");
        }

        [Test]
        public void QuandoAtualizarSubtarefaDeveRetornarSucesso()
        {
            var sucesso = OperacaoSubtarefa.Atualizar(SubtarefaMock.Subtarefa);
            Assert.IsTrue(sucesso, "Erro ao atualizar Subtarefa.");
        }

        [Test]
        public void QuandoObterTodosDeveRetornarSubtarefas()
        {
            var subtarefas = OperacaoSubtarefa.ObterTodos();
            Assert.IsTrue(subtarefas.Any(), "Nenhuma Subtarefa encontrada.");
        }

        [Test]
        public void QuandoObterPorIdDeveRetornarSubtarefa()
        {
            var subtarefa = OperacaoSubtarefa.ObterPorId(SubtarefaMock.Subtarefa.Id);
            Assert.IsNotNull(subtarefa, "Subtarefa não encontrada.");
        }
    }
}
