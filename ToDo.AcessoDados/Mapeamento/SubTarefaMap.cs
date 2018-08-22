using System.Data.Entity.ModelConfiguration;
using ToDo.Dominio.Entidades;

namespace ToDo.AcessoDados.Mapeamento
{
    public class SubTarefaMap : EntityTypeConfiguration<SubTarefa>
    {
        public SubTarefaMap()
        {
            ToTable("SUBTAREFA");

            HasKey(s => s.Id);

            Property(s => s.Id)
                .HasColumnName("ID")
                .IsRequired();

            Property(s => s.Nome)
               .HasColumnName("NOME")
               .HasMaxLength(64)
               .IsRequired();

            Property(s => s.Concluida)
               .HasColumnName("CONCLUIDA")
               .IsRequired();

            #region Relacionamentos

            Property(s => s.IdTarefa)
               .HasColumnName("IDTAREFA")
               .IsRequired();

            HasRequired(s => s.Tarefa)
                .WithMany(t => t.SubTarefas)
                .HasForeignKey(s => s.IdTarefa);

            #endregion
        }
    }
}
