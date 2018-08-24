using System.Collections.Generic;
using ToDo.Dominio.Entidades;

namespace ToDo.Testes.Integrados.Mocks
{
    public class SubtarefaMock
    {
        public static readonly Subtarefa Subtarefa = new Subtarefa
        {
            Nome = "TesteNome_1"
        };

        static readonly IEnumerable<Subtarefa> Subtarefas = new List<Subtarefa>
        {
            new Subtarefa
            {
                Nome = "TesteNome_2"
            },
            new Subtarefa
            {
                Nome = "TesteNome_3"
            },
            new Subtarefa
            {
                Nome = "TesteNome_4"
            }
        };

        public static void AdicionarTarefa(Subtarefa subtarefa)
        {
            subtarefa.IdTarefa = TarefaMock.Tarefa.Id;
        }
    }
}
