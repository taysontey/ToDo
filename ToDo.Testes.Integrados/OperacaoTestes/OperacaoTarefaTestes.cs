using NUnit.Framework;
using System.Linq;
using ToDo.Negocio.Operacao;
using ToDo.Testes.Integrados.Mocks;

namespace ToDo.Testes.Integrados.OperacaoTestes
{
    [TestFixture]
    public class OperacaoTarefaTestes
    {
        private OperacaoTarefa _operacaoTarefa;
        public OperacaoTarefa OperacaoTarefa
        {
            get => _operacaoTarefa ?? (_operacaoTarefa = new OperacaoTarefa());
            set => _operacaoTarefa = value;
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            var sucesso = OperacaoTarefa.Salvar(TarefaMock.Tarefa);
            Assert.IsTrue(sucesso, "Erro ao salvar tarefa.");
        }

        [OneTimeTearDown]
        public void Dispose()
        {
            var sucesso = OperacaoTarefa.Excluir(TarefaMock.Tarefa);
            Assert.IsTrue(sucesso, "Erro ao excluir tarefa.");
        }

        [Test]
        public void QuandoAtualizarTarefaDeveRetornarSucesso()
        {
            var sucesso = OperacaoTarefa.Atualizar(TarefaMock.Tarefa);
            Assert.IsTrue(sucesso, "Erro ao atualizar tarefa.");
        }

        [Test]
        public void QuandoObterTodosDeveRetornarTarefas()
        {
            var tarefas = OperacaoTarefa.ObterTodos();
            Assert.IsTrue(tarefas.Any(), "Nenhuma tarefa encontrada.");
        }

        [Test]
        public void QuandoObterPorIdDeveRetornarTarefa()
        {
            var tarefa = OperacaoTarefa.ObterPorId(TarefaMock.Tarefa.Id);
            Assert.IsNotNull(tarefa, "Tarefa não encontrada.");
        }
    }
}
