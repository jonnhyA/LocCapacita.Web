namespace LocCapacita.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AvalcPrfl")]
    public partial class AvalcPrfl
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdAvalcPrfl { get; set; }

        public int IdPrfl { get; set; }

        [StringLength(10)]
        public string IdAsstn { get; set; }
    }
}
