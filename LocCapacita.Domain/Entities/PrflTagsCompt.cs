using System;
using System.Collections.Generic;

namespace LocCapacita.Domain.Entities
{
    public partial class PrflTagsCompt
    {
        public int IdPrfl { get; set; }
        public int IdTagsCompt { get; set; }
        public System.DateTime DtCad { get; set; }
        public virtual Prfl Prfl { get; set; }
        public virtual TagsCompt TagsCompt { get; set; }
    }
}
