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
               .HasMaxLength(32)
               .IsRequired();

            Property(s => s.Concluida)
               .IsRequired();
        }
    }
}
