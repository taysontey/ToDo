using FluentValidation;

namespace ToDo.WebAPI.Model.Validator
{
    public class TarefaDTOValidator : AbstractValidator<TarefaDTO>
    {
        public TarefaDTOValidator()
        {
            RuleFor(x => x.Nome)
                .NotEmpty().WithMessage("O campo nome é obrigatório.")
                .MaximumLength(32).WithMessage("O tamanho máximo do campo nome é de 32.");

            RuleFor(x => x.Descricao)
                .MaximumLength(2000).WithMessage("O tamanho máximo do campo descrição é de 2000.");
        }
    }
}