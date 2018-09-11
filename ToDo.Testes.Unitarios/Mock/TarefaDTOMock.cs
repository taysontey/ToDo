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

        public static readonly TarefaDTO TarefaSemNome = new TarefaDTO
        {
            Id = 1,
            Nome = "",
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

        public static readonly TarefaDTO TarefaComDescricaoMaiorQuePermitida = new TarefaDTO
        {
            Id = 1,
            Nome = "TesteNome_1",
            Descricao = new string('\t', 2001),
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
