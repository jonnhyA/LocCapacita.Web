using System;
using System.Collections.Generic;

namespace LocCapacita.Domain.Models
{
    public partial class Pessoa
    {
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public Nullable<int> Idade { get; set; }
        public int IdPrfl { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public virtual Prfl Prfl { get; set; }
    }
}
