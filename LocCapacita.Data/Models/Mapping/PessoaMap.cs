using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LocCapacita.Data.Models.Mapping
{
    public class PessoaMap : EntityTypeConfiguration<Pessoa>
    {
        public PessoaMap()
        {
            // Primary Key
            this.HasKey(t => t.IdPessoa);

            // Properties
            this.Property(t => t.IdPessoa)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.SobreNome)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.Senha)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("Pessoa");
            this.Property(t => t.IdPessoa).HasColumnName("IdPessoa");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.SobreNome).HasColumnName("SobreNome");
            this.Property(t => t.Idade).HasColumnName("Idade");
            this.Property(t => t.IdPrfl).HasColumnName("IdPrfl");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Senha).HasColumnName("Senha");

            // Relationships
            this.HasRequired(t => t.Prfl)
                .WithMany(t => t.Pessoas)
                .HasForeignKey(d => d.IdPrfl);

        }
    }
}
