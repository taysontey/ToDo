using FluentValidation;

namespace ToDo.WebAPI.Model.Validator
{
    public class SubtarefaDTOValidator : AbstractValidator<SubtarefaDTO>
    {
        public SubtarefaDTOValidator()
        {
            RuleFor(x => x.Nome)
                .NotEmpty().WithMessage("O campo nome é obrigatório.")
                .MaximumLength(32).WithMessage("O tamanho máximo do campo nome é de 32.");
        }
    }
}