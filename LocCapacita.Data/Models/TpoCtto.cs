using System;
using System.Collections.Generic;

namespace LocCapacita.Data.Models
{
    public partial class TpoCtto
    {
        public TpoCtto()
        {
            this.Contatoes = new List<Contato>();
        }

        public int IdTpoCtto { get; set; }
        public string NomeCtto { get; set; }
        public System.DateTime DtCad { get; set; }
        public Nullable<System.DateTime> DtFimCad { get; set; }
        public virtual ICollection<Contato> Contatoes { get; set; }
    }
}
