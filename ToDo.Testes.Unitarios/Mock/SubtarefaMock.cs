using ToDo.Dominio.Entidades;

namespace ToDo.Testes.Unitarios.Mock
{
    public class SubtarefaMock
    {
        public static readonly Subtarefa Subtarefa = new Subtarefa
        {
            Id = 1,
            Nome = "TesteNome_1",
            Concluida = true,
            IdTarefa = 1
        };
    }
}
