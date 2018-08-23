using System.Collections.Generic;
using ToDo.Dominio.Entidades;

namespace ToDo.Testes.Integrados.Mocks
{
    public class TarefaMock
    {
        static readonly IEnumerable<Tarefa> Tarefas = new List<Tarefa>
        {
            new Tarefa
            {
                Nome = "NUnitTesteNome",
                Descricao = "NunitTesteDescricao"
            }
        };
    }
}
