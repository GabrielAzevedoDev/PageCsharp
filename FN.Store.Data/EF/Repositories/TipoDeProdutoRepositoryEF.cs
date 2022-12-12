using FN.Store.Domain._2.Contracts.Repositores;
using FN.Store.Domain._2.Entities;

namespace FN.Store.Data.EF.Repositories
{
    public class TipoDeProdutoRepositoryEF : RepositoryEF<TipoDeProduto>, ITipoDeProdutoRepository
    {
        public TipoDeProdutoRepositoryEF(FNStoreDataContextEF ctx) : base(ctx)
        {}
    }
}
