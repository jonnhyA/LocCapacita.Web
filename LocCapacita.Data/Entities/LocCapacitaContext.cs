namespace LocCapacita.Data.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LocCapacitaContext : DbContext
    {
        public LocCapacitaContext()
            : base("name=LocCapacitaContext")
        {
        }

        public virtual DbSet<AgndCapct> AgndCapct { get; set; }
        public virtual DbSet<Assunto> Assunto { get; set; }
        public virtual DbSet<Avalc> Avalc { get; set; }
        public virtual DbSet<AvalcPrfl> AvalcPrfl { get; set; }
        public virtual DbSet<Capct> Capct { get; set; }
        public virtual DbSet<Contato> Contato { get; set; }
        public virtual DbSet<DetlheCapct> DetlheCapct { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<Pessoa> Pessoa { get; set; }
        public virtual DbSet<Prfl> Prfl { get; set; }
        public virtual DbSet<PrflInscrito> PrflInscrito { get; set; }
        public virtual DbSet<Representante> Representante { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TagsCompt> TagsCompt { get; set; }
        public virtual DbSet<TpoCtto> TpoCtto { get; set; }
        public virtual DbSet<AcssoSite> AcssoSite { get; set; }
        public virtual DbSet<AssuntoAvalc> AssuntoAvalc { get; set; }
        public virtual DbSet<Busca> Busca { get; set; }
        public virtual DbSet<PrflInstrutorPrfl> PrflInstrutorPrfl { get; set; }
        public virtual DbSet<PrflTagsCompt> PrflTagsCompt { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AgndCapct>()
                .HasMany(e => e.PrflInscrito)
                .WithRequired(e => e.AgndCapct1)
                .HasForeignKey(e => e.AgndCapct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Assunto>()
                .Property(e => e.NomeAssnt)
                .IsUnicode(false);

            modelBuilder.Entity<Assunto>()
                .Property(e => e.DescrAssnt)
                .IsUnicode(false);

            modelBuilder.Entity<Assunto>()
                .HasOptional(e => e.AssuntoAvalc)
                .WithRequired(e => e.Assunto);

            modelBuilder.Entity<Avalc>()
                .Property(e => e.Coment)
                .IsUnicode(false);

            modelBuilder.Entity<Avalc>()
                .HasMany(e => e.AssuntoAvalc)
                .WithOptional(e => e.Avalc)
                .HasForeignKey(e => e.IdAvalcAssnt);

            modelBuilder.Entity<AvalcPrfl>()
                .Property(e => e.IdAsstn)
                .IsFixedLength();

            modelBuilder.Entity<Capct>()
                .Property(e => e.NomeCapct)
                .IsUnicode(false);

            modelBuilder.Entity<Capct>()
                .HasMany(e => e.DetlheCapct)
                .WithRequired(e => e.Capct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contato>()
                .Property(e => e.DescrCtto)
                .IsUnicode(false);

            modelBuilder.Entity<DetlheCapct>()
                .Property(e => e.DescrCapct)
                .IsUnicode(false);

            modelBuilder.Entity<DetlheCapct>()
                .HasMany(e => e.AgndCapct)
                .WithRequired(e => e.DetlheCapct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.NomeFantasia)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.RazaoSocial)
                .IsUnicode(false);

            modelBuilder.Entity<Pessoa>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Pessoa>()
                .Property(e => e.SobreNome)
                .IsUnicode(false);

            modelBuilder.Entity<Pessoa>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Pessoa>()
                .Property(e => e.Senha)
                .IsUnicode(false);

            modelBuilder.Entity<Prfl>()
                .Property(e => e.ImgPrfl)
                .IsUnicode(false);

            modelBuilder.Entity<Prfl>()
                .Property(e => e.DescrPrfl)
                .IsUnicode(false);

            modelBuilder.Entity<Prfl>()
                .HasMany(e => e.AgndCapct)
                .WithRequired(e => e.Prfl)
                .HasForeignKey(e => e.IdPrfl)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Prfl>()
                .HasMany(e => e.AgndCapct1)
                .WithRequired(e => e.Prfl1)
                .HasForeignKey(e => e.IdPrflInstrutor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Prfl>()
                .HasMany(e => e.Avalc)
                .WithRequired(e => e.Prfl)
                .HasForeignKey(e => e.IdPrflAvalc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Prfl>()
                .HasMany(e => e.Avalc1)
                .WithOptional(e => e.Prfl1)
                .HasForeignKey(e => e.IdPrfl);

            modelBuilder.Entity<Prfl>()
                .HasMany(e => e.Capct)
                .WithRequired(e => e.Prfl)
                .HasForeignKey(e => e.IdPrflCad)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Prfl>()
                .HasMany(e => e.DetlheCapct)
                .WithRequired(e => e.Prfl)
                .HasForeignKey(e => e.IdPrflv)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Prfl>()
                .HasMany(e => e.Empresa)
                .WithRequired(e => e.Prfl)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Prfl>()
                .HasMany(e => e.Pessoa)
                .WithRequired(e => e.Prfl)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Prfl>()
                .HasMany(e => e.PrflInscrito)
                .WithRequired(e => e.Prfl)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Prfl>()
                .HasMany(e => e.PrflInstrutorPrfl)
                .WithRequired(e => e.Prfl)
                .HasForeignKey(e => e.IdPrfl)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Prfl>()
                .HasMany(e => e.PrflInstrutorPrfl1)
                .WithRequired(e => e.Prfl1)
                .HasForeignKey(e => e.IdPrflInstrutor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Prfl>()
                .HasMany(e => e.PrflInstrutorPrfl2)
                .WithRequired(e => e.Prfl2)
                .HasForeignKey(e => e.IdPrflInstrutor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Prfl>()
                .HasMany(e => e.PrflTagsCompt)
                .WithRequired(e => e.Prfl)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Prfl>()
                .HasMany(e => e.Representante)
                .WithRequired(e => e.Prfl)
                .HasForeignKey(e => e.IdPrflRpstt)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Prfl>()
                .HasMany(e => e.Representante1)
                .WithRequired(e => e.Prfl1)
                .HasForeignKey(e => e.IdPrfl)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TagsCompt>()
                .Property(e => e.NomeCompt)
                .IsUnicode(false);

            modelBuilder.Entity<TagsCompt>()
                .HasMany(e => e.PrflTagsCompt)
                .WithRequired(e => e.TagsCompt)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TpoCtto>()
                .Property(e => e.NomeCtto)
                .IsUnicode(false);

            modelBuilder.Entity<TpoCtto>()
                .HasMany(e => e.Contato)
                .WithRequired(e => e.TpoCtto)
                .WillCascadeOnDelete(false);
        }
    }
}
