namespace LocCapacita.Data.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DetlheCapct")]
    public partial class DetlheCapct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DetlheCapct()
        {
            AgndCapct = new HashSet<AgndCapct>();
        }

        [Key]
        public int IdDetlheCapct { get; set; }

        public int IdCapct { get; set; }

        public int IdPrflv { get; set; }

        [Required]
        [StringLength(5000)]
        public string DescrCapct { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgndCapct> AgndCapct { get; set; }

        public virtual Capct Capct { get; set; }

        public virtual Prfl Prfl { get; set; }
    }
}
