namespace ToDo.Dominio.Entidades
{
    public class Subtarefa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Concluida { get; set; }

        #region Relacionamentos

        public int IdTarefa { get; set; }
        public Tarefa Tarefa { get; set; }

        #endregion
    }
}
