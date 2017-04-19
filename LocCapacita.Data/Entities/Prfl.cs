namespace LocCapacita.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Prfl")]
    public partial class Prfl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Prfl()
        {
            AgndCapct = new HashSet<AgndCapct>();
            AgndCapct1 = new HashSet<AgndCapct>();
            Avalc = new HashSet<Avalc>();
            Avalc1 = new HashSet<Avalc>();
            Capct = new HashSet<Capct>();
            Contato = new HashSet<Contato>();
            DetlheCapct = new HashSet<DetlheCapct>();
            Empresa = new HashSet<Empresa>();
            Pessoa = new HashSet<Pessoa>();
            PrflInscrito = new HashSet<PrflInscrito>();
            PrflInstrutorPrfl = new HashSet<PrflInstrutorPrfl>();
            PrflInstrutorPrfl1 = new HashSet<PrflInstrutorPrfl>();
            PrflInstrutorPrfl2 = new HashSet<PrflInstrutorPrfl>();
            PrflTagsCompt = new HashSet<PrflTagsCompt>();
            Representante = new HashSet<Representante>();
            Representante1 = new HashSet<Representante>();
        }

        [Key]
        public int IdPrfl { get; set; }

        [Required]
        [StringLength(100)]
        public string ImgPrfl { get; set; }

        public DateTime DtCadPrfl { get; set; }

        public int TpoPrfl { get; set; }

        [StringLength(5000)]
        public string DescrPrfl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgndCapct> AgndCapct { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgndCapct> AgndCapct1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Avalc> Avalc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Avalc> Avalc1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Capct> Capct { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contato> Contato { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetlheCapct> DetlheCapct { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empresa> Empresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pessoa> Pessoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrflInscrito> PrflInscrito { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrflInstrutorPrfl> PrflInstrutorPrfl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrflInstrutorPrfl> PrflInstrutorPrfl1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrflInstrutorPrfl> PrflInstrutorPrfl2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrflTagsCompt> PrflTagsCompt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Representante> Representante { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Representante> Representante1 { get; set; }
    }
}
