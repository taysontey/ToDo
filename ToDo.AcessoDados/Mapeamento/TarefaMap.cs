using System.Data.Entity.ModelConfiguration;
using ToDo.Dominio.Entidades;

namespace ToDo.AcessoDados.Mapeamento
{
    public class TarefaMap : EntityTypeConfiguration<Tarefa>
    {
        public TarefaMap()
        {
            ToTable("Tarefa");

            HasKey(t => t.Id);

            Property(t => t.Id)
                .IsRequired();

            Property(t => t.Nome)
               .HasMaxLength(32)
               .IsRequired();

            Property(t => t.Descricao)
               .HasMaxLength(2000)
               .IsRequired();

            Property(t => t.Concluida)
               .IsRequired();

            HasMany(x => x.Subtarefas)
                .WithRequired()
                .HasForeignKey(x => x.IdTarefa);
        }
    }
}
