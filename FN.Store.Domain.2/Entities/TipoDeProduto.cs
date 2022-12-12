using System.Collections.Generic;

namespace FN.Store.Domain._2.Entities
{
    public class TipoDeProduto : Entity
    {

        
        public string Nome { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
