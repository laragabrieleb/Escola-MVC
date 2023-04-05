using EscolaMVC.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace EscolaMVC.Models.Mapping
{
    public class ProfessorMapping : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.ToTable("Professores");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                   .HasValueGenerator<GuidValueGenerator>();

            builder.Property(p => p.Nome)
                   .HasMaxLength(50)
                   .HasColumnType("nvarchar")
                   .IsRequired();

            builder.HasMany(p => p.Turmas)
                   .WithOne(p => p.Professor)
                   .HasForeignKey(p => p.IdProfessor);
        }
    }
}
