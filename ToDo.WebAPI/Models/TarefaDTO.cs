using System.Collections.Generic;

namespace ToDo.WebAPI.Models
{
    public class TarefaDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Concluida { get; set; }

        public IList<SubtarefaDTO> Subtarefas { get; set; }
    }
}