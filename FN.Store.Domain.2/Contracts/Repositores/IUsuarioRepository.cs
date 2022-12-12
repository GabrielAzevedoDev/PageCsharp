using FN.Store.Domain._2.Entities;

namespace FN.Store.Domain._2.Contracts.Repositores
{
    public interface IUsuarioRepository: IRepository<Usuario>
    {
        Usuario Get(string email);
    }
}
