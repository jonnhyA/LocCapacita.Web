using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LocCapacita.Data.Models.Mapping
{
    public class EmpresaMap : EntityTypeConfiguration<Empresa>
    {
        public EmpresaMap()
        {
            // Primary Key
            this.HasKey(t => t.IdEmpr);

            // Properties
            this.Property(t => t.CNPJ)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.NomeFantasia)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.RazaoSocial)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Empresa");
            this.Property(t => t.IdEmpr).HasColumnName("IdEmpr");
            this.Property(t => t.IdPrfl).HasColumnName("IdPrfl");
            this.Property(t => t.CNPJ).HasColumnName("CNPJ");
            this.Property(t => t.NomeFantasia).HasColumnName("NomeFantasia");
            this.Property(t => t.RazaoSocial).HasColumnName("RazaoSocial");

            // Relationships
            this.HasRequired(t => t.Prfl)
                .WithMany(t => t.Empresas)
                .HasForeignKey(d => d.IdPrfl);

        }
    }
}
