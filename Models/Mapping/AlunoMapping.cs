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

            builder.Property(a => a.Nome)
                   .HasMaxLength(50)
                   .HasColumnType("nvarchar")
                   .IsRequired();

            builder.Property(a => a.Idade)
                   .IsRequired();

            builder.Property(a => a.DataDeAniversario)
                   .IsRequired()
                   .HasColumnType("nvarchar");

            builder.Property(a => a.TipoSanguineo)
                   .IsRequired();
        }
    }
}
