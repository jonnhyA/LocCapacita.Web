namespace LocCapacita.Data.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrflInstrutorPrfl")]
    public partial class PrflInstrutorPrfl
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdPrfl { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdPrflInstrutor { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime DtCad { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime DtFim { get; set; }

        public virtual Prfl Prfl { get; set; }

        public virtual Prfl Prfl1 { get; set; }

        public virtual Prfl Prfl2 { get; set; }
    }
}
