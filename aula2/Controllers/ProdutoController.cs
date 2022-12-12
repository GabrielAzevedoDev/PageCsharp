using FN.Store.Domain._2.Contracts.Repositores;
using System.Web.Mvc;
using aula2.ViewModels.Produtos.Index.Maps;
using aula2.ViewModels.Produtos.AddEdit.Maps;
using aula2.ViewModels.Produtos.AddEdit;

namespace aula2.Controllers
{
    [Authorize]
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly ITipoDeProdutoRepository _tipoDeProdutoRepository;

        

        public ProdutoController(
            IProdutoRepository produtoRepository,
            ITipoDeProdutoRepository tipoDeProdutoRepository)
        {
            _produtoRepository = produtoRepository;
            _tipoDeProdutoRepository = tipoDeProdutoRepository;
        }

        
        public ViewResult Index()
        {
            var produtos = _produtoRepository.Get().ToProdutoIndexVM();
            return View(produtos);
        }
        [HttpGet]
        public ViewResult AddEdit(int? id)
        {
            var produto = new ProdutoAddEditVM();

            if(id != null)
            {
                produto = _produtoRepository.Get((int)id).ToProdutoAddEditVM();
            }

            var tipos = _tipoDeProdutoRepository.Get();
            ViewBag.Tipos = tipos;
            return View(produto);
        }



        [HttpPost]
        public ActionResult AddEdit(ProdutoAddEditVM produtoVM)
        {
            var produto = produtoVM.ToProduto();

            if (ModelState.IsValid)
            {

                if (produto.Id == 0)
                {
                    _produtoRepository.Add(produto);
                }
                else
                {
                    _produtoRepository.Edit(produto);
                }

           
                return RedirectToAction("Index");
            }
            var tipos = _tipoDeProdutoRepository.Get();
            ViewBag.Tipos = tipos;

            return View(produto);

           }
        
        public ActionResult DelProd(int id)
        {

            var produto = _produtoRepository.Get(id);
            if(produto == null)
            {
                return HttpNotFound();
            }

            _produtoRepository.Delete(produto);
            return null;
        }

        protected override void Dispose(bool disposing)
        {}

    }
}