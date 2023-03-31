using EscolaMVC.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace EscolaMVC.Models.Mapping
{
    public class AlunoMapping : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Alunos");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id)
                   .HasValueGenerator<GuidValueGenerator>();

            builder.Property(e => e.Nome)
                   .IsRequired()
                   .HasMaxLength(50)
                   .HasColumnType("nvarchar");

            builder.Property(e => e.Idade)
                   .IsRequired();

            builder.Property(e => e.DataDeAniversario)
                   .IsRequired()
                   .HasColumnType("nvarchar");

            builder.Property(e => e.TipoSanguineo)
                   .IsRequired();
        }
    }
}
