namespace LocCapacita.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Empresa")]
    public partial class Empresa
    {
        [Key]
        public int IdEmpr { get; set; }

        public int IdPrfl { get; set; }

        [Required]
        [StringLength(12)]
        public string CNPJ { get; set; }

        [Required]
        [StringLength(100)]
        public string NomeFantasia { get; set; }

        [StringLength(100)]
        public string RazaoSocial { get; set; }

        public virtual Prfl Prfl { get; set; }
    }
}
