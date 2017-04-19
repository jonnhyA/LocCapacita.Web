namespace LocCapacita.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Representante")]
    public partial class Representante
    {
        [Key]
        public int IdRpstt { get; set; }

        public int IdPrflRpstt { get; set; }

        public int IdPrfl { get; set; }

        public DateTime DtCad { get; set; }

        public DateTime? DtCadFim { get; set; }

        public virtual Prfl Prfl { get; set; }

        public virtual Prfl Prfl1 { get; set; }
    }
}
