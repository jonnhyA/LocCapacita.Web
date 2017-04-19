namespace LocCapacita.Data.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AssuntoAvalc")]
    public partial class AssuntoAvalc
    {
        public int? IdAvalcAssnt { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdAsstn { get; set; }

        public int? IdPrfl { get; set; }

        public virtual Assunto Assunto { get; set; }

        public virtual Avalc Avalc { get; set; }
    }
}
