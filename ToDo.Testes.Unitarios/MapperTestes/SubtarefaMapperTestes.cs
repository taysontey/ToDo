using Mapster;
using NUnit.Framework;
using ToDo.Dominio.Entidades;
using ToDo.Testes.Unitarios.Mock;
using ToDo.WebAPI.Model;

namespace ToDo.Testes.Unitarios.MapperTestes
{
    [TestFixture]
    public class SubtarefaMapperTestes
    {
        [Test]
        public void QuandoMapearSubtarefaParaSubtarefaDTODeveRetornarPropriedadesComMesmoValor()
        {
            var subtarefaDTO = SubtarefaMock.Subtarefa.Adapt<SubtarefaDTO>();

            Assert.AreEqual(SubtarefaMock.Subtarefa.Id, subtarefaDTO.Id);
            Assert.AreEqual(SubtarefaMock.Subtarefa.Nome, subtarefaDTO.Nome);
            Assert.AreEqual(SubtarefaMock.Subtarefa.Concluida, subtarefaDTO.Concluida);
            Assert.AreEqual(SubtarefaMock.Subtarefa.IdTarefa, subtarefaDTO.IdTarefa);
        }

        [Test]
        public void QuandoMapearSubtarefaDTOParaSubtarefaDeveRetornarPropriedadesComMesmoValor()
        {
            var subtarefa = SubtarefaDTOMock.Subtarefa.Adapt<Subtarefa>();

            Assert.AreEqual(SubtarefaDTOMock.Subtarefa.Id, subtarefa.Id);
            Assert.AreEqual(SubtarefaDTOMock.Subtarefa.Nome, subtarefa.Nome);
            Assert.AreEqual(SubtarefaDTOMock.Subtarefa.Concluida, subtarefa.Concluida);
            Assert.AreEqual(SubtarefaDTOMock.Subtarefa.IdTarefa, subtarefa.IdTarefa);
        }
    }
}
