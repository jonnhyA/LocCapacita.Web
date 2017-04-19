namespace LocCapacita.Data.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Capct")]
    public partial class Capct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Capct()
        {
            DetlheCapct = new HashSet<DetlheCapct>();
        }

        [Key]
        public int IdCapct { get; set; }

        [Required]
        [StringLength(150)]
        public string NomeCapct { get; set; }

        public int IdPrflCad { get; set; }

        public DateTime DtCad { get; set; }

        public virtual Prfl Prfl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetlheCapct> DetlheCapct { get; set; }
    }
}
