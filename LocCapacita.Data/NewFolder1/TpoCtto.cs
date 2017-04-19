namespace LocCapacita.Data.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TpoCtto")]
    public partial class TpoCtto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TpoCtto()
        {
            Contato = new HashSet<Contato>();
        }

        [Key]
        public int IdTpoCtto { get; set; }

        [Required]
        [StringLength(150)]
        public string NomeCtto { get; set; }

        public DateTime DtCad { get; set; }

        public DateTime? DtFimCad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contato> Contato { get; set; }
    }
}
