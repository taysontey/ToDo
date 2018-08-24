using System.Collections.Generic;
using ToDo.Dominio.Entidades;

namespace ToDo.Testes.Integrados.Mocks
{
    public class TarefaMock
    {
        public static readonly Tarefa Tarefa = new Tarefa
        {
            Nome = "TesteNome_1",
            Descricao = "TesteDescricao_1"
        };

        static readonly IEnumerable<Tarefa> Tarefas = new List<Tarefa>
        {
            new Tarefa
            {
                Nome = "TesteNome_2",
                Descricao = "TesteDescricao_2"
            },
            new Tarefa
            {
                Nome = "TesteNome_3",
                Descricao = "TesteDescricao_3"
            },
            new Tarefa
            {
                Nome = "TesteNome_4",
                Descricao = "TesteDescricao_4"
            }
        };
    }
}
