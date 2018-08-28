using ToDo.WebAPI.Model;

namespace ToDo.Testes.Unitarios.Mock
{
    public class SubtarefaDTOMock
    {
        public static readonly SubtarefaDTO Subtarefa = new SubtarefaDTO
        {
            Id = 1,
            Nome = "TesteNome_1",
            Concluida = true,
            IdTarefa = 1
        };
    }
}
