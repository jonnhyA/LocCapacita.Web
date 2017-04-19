namespace LocCapacita.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrflInscrito")]
    public partial class PrflInscrito
    {
        [Key]
        public int IdPrflInscrito { get; set; }

        public int IdPrfl { get; set; }

        public int AgndCapct { get; set; }

        public bool Pago { get; set; }

        public DateTime? DtPago { get; set; }

        public virtual AgndCapct AgndCapct1 { get; set; }

        public virtual Prfl Prfl { get; set; }
    }
}
