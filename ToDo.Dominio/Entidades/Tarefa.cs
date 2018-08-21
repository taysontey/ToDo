using System.Collections.Generic;

namespace ToDo.Dominio.Entidades
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Concluida { get; set; }

        public IEnumerable<SubTarefa> SubTarefas { get; set; }
    }
}
