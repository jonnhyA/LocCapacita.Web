namespace LocCapacita.Data.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Avalc")]
    public partial class Avalc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Avalc()
        {
            AssuntoAvalc = new HashSet<AssuntoAvalc>();
        }

        [Key]
        public int IdAvalc { get; set; }

        public int IdPrflAvalc { get; set; }

        public double Valor { get; set; }

        [StringLength(5000)]
        public string Coment { get; set; }

        public DateTime DtAvalc { get; set; }

        public bool Ativo { get; set; }

        public int? IdAgndCapct { get; set; }

        public int? IdPrfl { get; set; }

        public virtual AgndCapct AgndCapct { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssuntoAvalc> AssuntoAvalc { get; set; }

        public virtual Prfl Prfl { get; set; }

        public virtual Prfl Prfl1 { get; set; }
    }
}
