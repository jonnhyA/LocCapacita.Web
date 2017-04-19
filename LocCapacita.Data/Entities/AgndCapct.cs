namespace LocCapacita.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AgndCapct")]
    public partial class AgndCapct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AgndCapct()
        {
            Avalc = new HashSet<Avalc>();
            PrflInscrito = new HashSet<PrflInscrito>();
        }

        [Key]
        public int IdAgndCapct { get; set; }

        public int IdDetlheCapct { get; set; }

        public int TpoCapct { get; set; }

        public int IdPrflInstrutor { get; set; }

        public int IdLocal { get; set; }

        public DateTime DtInit { get; set; }

        public DateTime DtFim { get; set; }

        public TimeSpan HrInit { get; set; }

        public TimeSpan HrFim { get; set; }

        public bool Cetficado { get; set; }

        public bool PrepCerticacao { get; set; }

        public int IdPrfl { get; set; }

        public int CargaHr { get; set; }

        public virtual DetlheCapct DetlheCapct { get; set; }

        public virtual Prfl Prfl { get; set; }

        public virtual Prfl Prfl1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Avalc> Avalc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrflInscrito> PrflInscrito { get; set; }
    }
}
