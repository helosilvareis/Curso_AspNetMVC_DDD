using System;

namespace EP.CursoMVC.Domain.Models
{
    public abstract class Entity
    {
        protected Entity() => Id = Guid.NewGuid();
        public Guid Id { get; set; }
        public abstract bool EhValido();
    }
}
