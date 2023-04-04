using EscolaMVC.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace EscolaMVC.Models.Mapping
{ 
    public class ResponsavelMapping : IEntityTypeConfiguration<Responsavel>
    {
        public void Configure(EntityTypeBuilder<Responsavel> builder)
        {
            builder.ToTable("Responsáveis");

            builder.HasKey(r => r.Id);

            builder.Property(r => r.Id)
                  .HasValueGenerator<GuidValueGenerator>();

            builder.Property(r => r.Nome)
                   .HasMaxLength(50)
                   .HasColumnType("nvarchar")
                   .IsRequired();

            builder.Property(r => r.Endereco)
                   .HasMaxLength(50)
                   .HasColumnType("nvarchar")
                   .IsRequired();

            builder.Property(r => r.Contato)
                   .HasMaxLength(50)
                   .HasColumnType("nvarchar")
                   .IsRequired();
        }
    }
}
