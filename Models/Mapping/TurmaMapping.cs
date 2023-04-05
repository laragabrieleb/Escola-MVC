using EscolaMVC.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EscolaMVC.Models.Mapping
{
    public class TurmaMapping : IEntityTypeConfiguration<Turma>
    {
        public void Configure(EntityTypeBuilder<Turma> builder)
        {
            builder.ToTable("Turmas");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Turno)
                   .IsRequired();

            builder.HasMany(t => t.Alunos)
                   .WithOne(t => t.Turma)
                   .HasForeignKey(t => t.IdTurma);

        }
    }
}
