using NUnit.Framework;
using System.Linq;
using ToDo.Dominio.Entidades;
using ToDo.Negocio.Operacao;
using ToDo.Testes.Integrados.Mocks;

namespace ToDo.Testes.Integrados.OperacaoTestes
{
    [TestFixture]
    public class OperacaoTarefaTestes : OperacaoBaseTestes
    {
        [Test, TestCaseSource(typeof(TarefaMock), "Tarefas")]
        public void QuantoSalvarTarefaDeveRetornarSucesso(Tarefa tarefa)
        {
            var sucesso = OperacaoTarefa.Salvar(tarefa);
            Assert.IsTrue(sucesso, "Erro ao salvar tarefa.");
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

        [Test]
        public void QuandoObterPorFiltroDeveRetornarTarefas()
        {
            var tarefas = OperacaoTarefa.ObterPorFiltro(TarefaMock.Tarefa.Nome);
            Assert.IsNotNull(tarefas.Any(), "Nenhuma tarefa encontrada.");
        }

        [Test]
        public void QuandoExcluirTarefaDeveRetornarSucesso()
        {
            var sucesso = OperacaoTarefa.Excluir(TarefaMock.Tarefa.Id);
            Assert.IsTrue(sucesso, "Erro ao excluir tarefa.");
        }
    }
}
