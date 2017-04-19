namespace LocCapacita.Data.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contato")]
    public partial class Contato
    {
        [Key]
        public int IdCtto { get; set; }

        public int? IdPrfl { get; set; }

        public int IdTpoCtto { get; set; }

        [Required]
        [StringLength(50)]
        public string DescrCtto { get; set; }

        public virtual Prfl Prfl { get; set; }

        public virtual TpoCtto TpoCtto { get; set; }
    }
}
