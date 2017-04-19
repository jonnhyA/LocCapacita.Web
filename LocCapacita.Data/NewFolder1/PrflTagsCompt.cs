namespace LocCapacita.Data.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrflTagsCompt")]
    public partial class PrflTagsCompt
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdPrfl { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdTagsCompt { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime DtCad { get; set; }

        public virtual Prfl Prfl { get; set; }

        public virtual TagsCompt TagsCompt { get; set; }
    }
}
