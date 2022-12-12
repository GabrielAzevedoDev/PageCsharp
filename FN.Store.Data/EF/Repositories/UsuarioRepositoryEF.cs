using FN.Store.Domain._2.Contracts.Repositores;
using FN.Store.Domain._2.Entities;
using System.Linq;

namespace FN.Store.Data.EF.Repositories
{

    public class UsuarioRepositoryEF : RepositoryEF<Usuario>, IUsuarioRepository
    {
        public UsuarioRepositoryEF(FNStoreDataContextEF ctx) : base(ctx)
        {}

        public Usuario Get(string email)
        {
            return _ctx.Usuarios.FirstOrDefault(u=> u.Email.ToLower() == email.ToLower());
        }
    }

}
