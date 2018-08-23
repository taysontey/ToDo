using ToDo.Dominio.Entidades;

namespace ToDo.Testes.Integrados.Mocks
{
    public class TarefaMock
    {
        public static readonly Tarefa Tarefa = new Tarefa
        {
            Nome = "TesteNome",
            Descricao = "TesteDescricao"
        };
    }
}
