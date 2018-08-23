using System.Data.Entity.ModelConfiguration;
using ToDo.Dominio.Entidades;

namespace ToDo.AcessoDados.Mapeamento
{
    public class SubtarefaMap : EntityTypeConfiguration<Subtarefa>
    {
        public SubtarefaMap()
        {
            ToTable("Subtarefa");

            HasKey(s => s.Id);

            Property(s => s.Id)
                .IsRequired();

            Property(s => s.Nome)
               .HasMaxLength(64)
               .IsRequired();

            Property(s => s.Concluida)
               .IsRequired();

            #region Relacionamentos

            Property(s => s.IdTarefa)
               .IsRequired();

            HasRequired(s => s.Tarefa)
                .WithMany(t => t.Subtarefas)
                .HasForeignKey(s => s.IdTarefa);

            #endregion
        }
    }
}
