using System;
using System.Collections.Generic;

namespace LocCapacita.Data.Models
{
    public partial class Empresa
    {
        public int IdEmpr { get; set; }
        public int IdPrfl { get; set; }
        public string CNPJ { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public virtual Prfl Prfl { get; set; }
    }
}
