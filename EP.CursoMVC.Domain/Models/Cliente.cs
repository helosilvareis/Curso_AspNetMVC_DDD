using System;
using System.Collections.Generic;

namespace EP.CursoMVC.Domain.Models
{
    public class Cliente : Entity
    {
        public Cliente() => Enderecos = new List<Endereco>();

        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public bool Excluido { get; set; }
        public virtual ICollection<Endereco> Enderecos { get; set; }
        public void Excluir()
        {
            Ativo = false;
            Excluido = true;            
        }
        public void Ativar()
        {
            Ativo = true;
            Excluido = false;
        }
        public override bool EhValido()
        {
            return true;
        }
        public void AdicionarEndereco(Endereco endereco)
        {
            if (!endereco.EhValido())
                return;

            Enderecos.Add(endereco);
        }
    }
}
