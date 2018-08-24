﻿namespace ToDo.WebAPI.Models
{
    public class SubtarefaDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Concluida { get; set; }

        #region Relacionamentos

        public int IdTarefa { get; set; }
        public TarefaDTO Tarefa { get; set; }

        #endregion
    }
}