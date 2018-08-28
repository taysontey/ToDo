using NUnit.Framework;
using System.Linq;
using ToDo.Dominio.Entidades;
using ToDo.Negocio.Operacao;
using ToDo.Testes.Integrados.Mocks;

namespace ToDo.Testes.Integrados.OperacaoTestes
{
    [TestFixture]
    public class OperacaoSubtarefaTestes : OperacaoBaseTestes
    {
        [Test, TestCaseSource(typeof(SubtarefaMock), "Subtarefas")]
        public void QuandoSalvarSubtarefaDeveRetornarSucesso(Subtarefa subtarefa)
        {
            SubtarefaMock.AdicionarTarefa(subtarefa);
            var sucesso = OperacaoSubtarefa.Salvar(subtarefa);
            Assert.IsTrue(sucesso, "Erro ao salvar subtarefa.");
        }

        [Test]
        public void QuandoAtualizarSubtarefaDeveRetornarSucesso()
        {
            var sucesso = OperacaoSubtarefa.Atualizar(SubtarefaMock.Subtarefa);
            Assert.IsTrue(sucesso, "Erro ao atualizar subtarefa.");
        }

        [Test]
        public void QuandoObterTodosDeveRetornarSubtarefas()
        {
            var subtarefas = OperacaoSubtarefa.ObterTodos();
            Assert.IsTrue(subtarefas.Any(), "Nenhuma subtarefa encontrada.");
        }

        [Test]
        public void QuandoObterPorIdDeveRetornarSubtarefa()
        {
            var subtarefa = OperacaoSubtarefa.ObterPorId(SubtarefaMock.Subtarefa.Id);
            Assert.IsNotNull(subtarefa, "Subtarefa não encontrada.");
        }

        [Test]
        public void QuandoObterPorFiltroDeveRetornarSubtarefas()
        {
            var subtarefas = OperacaoSubtarefa.ObterPorFiltro(SubtarefaMock.Subtarefa.Nome);
            Assert.IsNotNull(subtarefas.Any(), "Nenhuma subtarefa encontrada.");
        }

        [Test]
        public void QuandoExcluirSubtarefaDeveRetornarSucesso()
        {
            var sucesso = OperacaoSubtarefa.Excluir(SubtarefaMock.Subtarefa.Id);
            Assert.IsTrue(sucesso, "Erro ao excluir subtarefa.");
        }
    }
}
