using Mapster;
using NUnit.Framework;
using System.Linq;
using ToDo.Dominio.Entidades;
using ToDo.Testes.Unitarios.Mock;
using ToDo.WebAPI.Model;

namespace ToDo.Testes.Unitarios.MapperTestes
{
    [TestFixture]
    public class TarefaMapperTestes
    {
        [Test]
        public void QuandoMapearTarefaParaTarefaDTODeveRetornarPropriedadesComMesmoValor()
        {
            var tarefaDTO = TarefaMock.Tarefa.Adapt<TarefaDTO>();

            Assert.AreEqual(TarefaMock.Tarefa.Id, tarefaDTO.Id);
            Assert.AreEqual(TarefaMock.Tarefa.Nome, tarefaDTO.Nome);
            Assert.AreEqual(TarefaMock.Tarefa.Descricao, tarefaDTO.Descricao);
            Assert.AreEqual(TarefaMock.Tarefa.Concluida, tarefaDTO.Concluida);
            Assert.IsTrue(tarefaDTO.Subtarefas.Any());
        }

        [Test]
        public void QuandoMapearTarefaDTOParaTarefaDeveRetornarPropriedadesComMesmoValor()
        {
            var tarefa = TarefaDTOMock.Tarefa.Adapt<Tarefa>();

            Assert.AreEqual(TarefaDTOMock.Tarefa.Id, tarefa.Id);
            Assert.AreEqual(TarefaDTOMock.Tarefa.Nome, tarefa.Nome);
            Assert.AreEqual(TarefaDTOMock.Tarefa.Descricao, tarefa.Descricao);
            Assert.AreEqual(TarefaDTOMock.Tarefa.Concluida, tarefa.Concluida);
            Assert.IsTrue(tarefa.Subtarefas.Any());
        }
    }
}
