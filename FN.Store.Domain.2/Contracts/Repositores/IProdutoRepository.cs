using FN.Store.Domain._2.Entities;
using System.Collections.Generic;

namespace FN.Store.Domain._2.Contracts.Repositores
{
    public interface IProdutoRepository: IRepository<Produto>
    {
        IEnumerable<Produto> GetByNameContains(string contains);
    }
}
