using NUnit.Framework;
using ToDo.Testes.Unitarios.Mock;
using ToDo.WebAPI.Model.Validator;

namespace ToDo.Testes.Unitarios.ValidatorTestes
{
    [TestFixture]
    public class TarefaDTOValidatorTestes
    {
        private TarefaDTOValidator _tarefaDTOValidator;
        public TarefaDTOValidator TarefaDTOValidator
        {
            get =>  _tarefaDTOValidator ?? (_tarefaDTOValidator = new TarefaDTOValidator());
            set => _tarefaDTOValidator = value;
        }

        [Test]
        public void QuandoValidarTarefaCorretaDeveRetornarSucessoNaValidacao()
        {
            var resultado = TarefaDTOValidator.Validate(TarefaDTOMock.Tarefa);
            Assert.IsTrue(resultado.IsValid, "Tarefa não foi validada corretamente.");
        }

        [Test]
        public void QuandoValidarTarefaSemNomeDeveRetornarErroNaValidacao()
        {
            var resultado = TarefaDTOValidator.Validate(TarefaDTOMock.TarefaSemNome);
            Assert.IsFalse(resultado.IsValid, "Tarefa não foi validada corretamente.");
        }

        [Test]
        public void QuandoValidarTarefaComDescricaoMaiorQuePermitidaDeveRetornarErroNaValidacao()
        {
            var resultado = TarefaDTOValidator.Validate(TarefaDTOMock.TarefaComDescricaoMaiorQuePermitida);
            Assert.IsFalse(resultado.IsValid, "Tarefa não foi validada corretamente.");
        }
    }
}
