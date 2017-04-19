namespace LocCapacita.Data.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Busca")]
    public partial class Busca
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdBusca { get; set; }
    }
}
