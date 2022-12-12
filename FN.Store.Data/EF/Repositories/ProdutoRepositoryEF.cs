using FN.Store.Domain._2.Contracts.Repositores;
using FN.Store.Domain._2.Entities;
using System.Collections.Generic;
using System.Linq;

namespace FN.Store.Data.EF.Repositories
{
    public class ProdutoRepositoryEF : RepositoryEF<Produto>, IProdutoRepository
    {
        public ProdutoRepositoryEF(FNStoreDataContextEF ctx) : base(ctx)
        {}

        public IEnumerable<Produto> GetByNameContains(string contains)
        {
            return 
                
                _ctx.Produtos.Where(p => p.Nome.Contains(contains));
        }
    }
}
