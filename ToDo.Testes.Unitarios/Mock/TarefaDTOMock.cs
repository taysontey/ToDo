using System.Collections.Generic;
using ToDo.WebAPI.Model;

namespace ToDo.Testes.Unitarios.Mock
{
    public class TarefaDTOMock
    {
        public static readonly TarefaDTO Tarefa = new TarefaDTO
        {
            Id = 1,
            Nome = "TesteNome_1",
            Descricao = "TesteDescricao_1",
            Concluida = true,
            Subtarefas = new List<SubtarefaDTO>
            {
                new SubtarefaDTO
                {
                    Nome = "TesteNome_1"
                }
            }
        };
    }
}
