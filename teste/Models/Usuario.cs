using System;
using System.Collections.Generic;

namespace teste.Models
{
    public partial class Usuario
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
