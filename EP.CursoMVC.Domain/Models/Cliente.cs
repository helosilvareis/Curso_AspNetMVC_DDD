using System;
using System.Collections.Generic;

namespace EP.CursoMVC.Domain.Models
{
    public class Cliente
    {
        public Cliente()
        {
            ID = Guid.NewGuid();
        }
        public Guid ID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public bool Excluido { get; set; }
        public virtual ICollection<Endereco> Enderecos { get; set; }
    }
}
