using System;

namespace FN.Store.Domain._2.Entities
{
    public class Entity
    {
        public Entity()
        {
            DataCadastro = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
