using System;
using System.Collections.Generic;
using System.Text;

namespace EP.CursoMVC.Domain.Models
{
    public class Endereco
    {
        public Endereco()
        {
            ID = Guid.NewGuid();
        }
        public Guid ID { get; set; }

        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public Guid ClienteId { get; set; }

        //Propriedade de navegação
        public Cliente Cliente { get; set; }
    }
}
