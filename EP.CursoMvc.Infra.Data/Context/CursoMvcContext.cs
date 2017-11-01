using EP.CursoMVC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace EP.CursoMVC.Infra.Data.Context
{
    public class CursoMvcContext : DbContext
    {
        public CursoMvcContext() //: base("DefaultConnection")
        {
            //Algumas configurações do EF
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
    }
}
