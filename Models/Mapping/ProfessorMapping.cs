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

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id)
                   .HasValueGenerator<GuidValueGenerator>();

            builder.Property(e => e.Nome)
                   .IsRequired()
                   .HasMaxLength(50)
                   .HasColumnType("nvarchar");

            builder.Property(e => e.Turmas)
                   .IsRequired();
        }
    }
}
