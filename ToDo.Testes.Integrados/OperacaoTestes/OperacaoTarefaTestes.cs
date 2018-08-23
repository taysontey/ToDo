using NUnit.Framework;
using System.Linq;
using ToDo.Dominio.Entidades;
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

        [Test, TestCaseSource(typeof(TarefaMock), "Tarefas"), Order(1)]
        public void QuandoSalvarTarefaDeveRetornarSucesso(Tarefa tarefa)
        {
            var sucesso = OperacaoTarefa.Salvar(tarefa);
            Assert.IsTrue(sucesso, "Erro ao salvar tarefa.");
        }

        [Test, TestCaseSource(typeof(TarefaMock), "Tarefas"), Order(2)]
        public void QuandoAtualizarTarefaDeveRetornarSucesso(Tarefa tarefa)
        {
            var sucesso = OperacaoTarefa.Atualizar(tarefa);
            Assert.IsTrue(sucesso, "Erro ao atualizar tarefa.");
        }

        [Test, Order(3)]
        public void QuandoObterTodosDeveRetornarTarefas()
        {
            var tarefas = OperacaoTarefa.ObterTodos();
            Assert.IsTrue(tarefas.Any(), "Nenhuma tarefa encontrada.");
        }

        [Test, TestCaseSource(typeof(TarefaMock), "Tarefas"), Order(4)]
        public void QuandoObterPorIdDeveRetornarTarefa(Tarefa tarefa)
        {
            Assert.IsNotNull(OperacaoTarefa.ObterPorId(tarefa.Id), "Tarefa não encontrada.");
        }

        [Test, TestCaseSource(typeof(TarefaMock), "Tarefas"), Order(5)]
        public void QuandoExcluirTarefaDeveRetornarSucesso(Tarefa tarefa)
        {           
            var sucesso = OperacaoTarefa.Excluir(tarefa);
            Assert.IsTrue(sucesso, "Erro ao excluir tarefa.");
        }
    }
}
