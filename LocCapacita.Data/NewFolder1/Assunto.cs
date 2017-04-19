namespace LocCapacita.Data.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Assunto")]
    public partial class Assunto
    {
        [Key]
        public int IdAsstn { get; set; }

        [Required]
        [StringLength(50)]
        public string NomeAssnt { get; set; }

        [Required]
        [StringLength(500)]
        public string DescrAssnt { get; set; }

        public DateTime DtCad { get; set; }

        public virtual AssuntoAvalc AssuntoAvalc { get; set; }
    }
}
