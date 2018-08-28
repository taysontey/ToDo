using System.Collections.Generic;
using ToDo.Dominio.Entidades;

namespace ToDo.Testes.Unitarios.Mock
{
    public class TarefaMock
    {
        public static readonly Tarefa Tarefa = new Tarefa
        {
            Id = 1,
            Nome = "TesteNome_1",
            Descricao = "TesteDescricao_1",
            Concluida = true,
            Subtarefas = new List<Subtarefa>
            {
                new Subtarefa
                {
                    Nome = "TesteNome_1"
                }
            }
        };
    }
}
