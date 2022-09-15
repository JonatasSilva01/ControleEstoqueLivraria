using ControleEstoqueLivraria.DATA.Models;
using ControleEstoqueLivraria.DATA.Services;
using Microsoft.AspNetCore.Mvc;

namespace ControleEmprestimoLivraria.WEB.Controllers
{
    public class LivrosController : Controller
    {
        private LivroServices onLivroServices = new LivroServices();

        public IActionResult Index()
        {
            List<Livro> onListLivros = onLivroServices.onRepositoryLivro.SelecionarTodos();
            return View(onListLivros);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Livro model)
        {
            if (!ModelState.IsValid) return View(); // verifica se o modelo é valido ou não

            onLivroServices.onRepositoryLivro.Incluir(model);

            return RedirectToAction("Index"); // redireciona para pagina Index
        }

        public IActionResult Details(int id)
        {
            Livro oLivro = onLivroServices.onRepositoryLivro.Selecionar_Pk(id);
            return View(oLivro);
        }

        public IActionResult Edit(int id)
        {
            Livro oLivro = onLivroServices.onRepositoryLivro.Selecionar_Pk(id);
            return View(oLivro);
        }

        [HttpPost]
        public IActionResult Edit(Livro model)
        {
            Livro livro = onLivroServices.onRepositoryLivro.Alterar(model);

            int id = livro.Id;

            return RedirectToAction("Details", new { id });
        }
        
        public IActionResult Delete(int id)
        {
            onLivroServices.onRepositoryLivro.Excluir(id);
            return RedirectToAction("Index");
        }

    }
}
