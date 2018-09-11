using NUnit.Framework;
using ToDo.Testes.Unitarios.Mock;
using ToDo.WebAPI.Model.Validator;

namespace ToDo.Testes.Unitarios.ValidatorTestes
{
    [TestFixture]
    public class SubtarefaDTOValidatorTestes
    {
        private SubtarefaDTOValidator _subtarefaDTOValidator;
        public SubtarefaDTOValidator SubtarefaDTOValidator
        {
            get => _subtarefaDTOValidator ?? (_subtarefaDTOValidator = new SubtarefaDTOValidator());
            set => _subtarefaDTOValidator = value;
        }

        [Test]
        public void QuandoValidarSubtarefaCorretaDeveRetornarSucessoNaValidacao()
        {
            var resultado = SubtarefaDTOValidator.Validate(SubtarefaDTOMock.Subtarefa);
            Assert.IsTrue(resultado.IsValid, "Subtarefa não foi validada corretamente.");
        }

        [Test]
        public void QuandoValidarSubtarefaSemNomeDeveRetornarErroNaValidacao()
        {
            var resultado = SubtarefaDTOValidator.Validate(SubtarefaDTOMock.SubtarefaSemNome);
            Assert.IsFalse(resultado.IsValid, "Subtarefa não foi validada corretamente.");
        }
    }
}
