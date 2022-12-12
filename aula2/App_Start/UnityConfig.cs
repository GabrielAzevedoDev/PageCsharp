using FN.Store.Data.ADO.Repositores;
using FN.Store.Data.EF;
using FN.Store.Data.EF.Repositories;
using FN.Store.Domain._2.Contracts.Repositores;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace aula2
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();


            container.RegisterType<FNStoreDataContextEF>();
            container.RegisterType<IProdutoRepository, ProdutoRepositoryEF>();
            container.RegisterType<ITipoDeProdutoRepository, TipoDeProdutoRepositoryEF>();
            container.RegisterType<IUsuarioRepository, UsuarioRepositoryEF>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}