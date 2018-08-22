using System.Data.Entity.ModelConfiguration;
using ToDo.Dominio.Entidades;

namespace ToDo.AcessoDados.Mapeamento
{
    public class TarefaMap : EntityTypeConfiguration<Tarefa>
    {
        public TarefaMap()
        {
            ToTable("TAREFA");

            HasKey(t => t.Id);

            Property(t => t.Id)
                .HasColumnName("ID")
                .IsRequired();

            Property(t => t.Nome)
               .HasColumnName("NOME")
               .HasMaxLength(64)
               .IsRequired();

            Property(t => t.Descricao)
               .HasColumnName("DESCRICAO")
               .HasMaxLength(2000)
               .IsRequired();

            Property(t => t.Concluida)
               .HasColumnName("CONCLUIDA")
               .IsRequired();
        }
    }
}
