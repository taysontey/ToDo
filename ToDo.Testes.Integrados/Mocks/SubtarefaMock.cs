using ToDo.Dominio.Entidades;

namespace ToDo.Testes.Integrados.Mocks
{
    public class SubtarefaMock
    {
        public static readonly Subtarefa Subtarefa = new Subtarefa
        {
            Nome = "TesteNome"
        };

        public static void AdicionarIdTarefa()
        {
            Subtarefa.IdTarefa = TarefaMock.Tarefa.Id;
        }
    }
}
