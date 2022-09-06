using ControleEstoqueLivraria.DATA.Interfaces;
using ControleEstoqueLivraria.DATA.Models;
using ControleEstoqueLivraria.DATA.Repository;
using ControleEstoqueLivraria.DATA.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ControleEmprestimoLivraria.WEB.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteService onClienteService = new ClienteService();

        public IActionResult Index()
        {
            List<Cliente> onListCliente = onClienteService.onRepositoryCliente.SelecionarTodos();
            return View(onListCliente);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cliente model)
        {
            if (!ModelState.IsValid) return View(); // verifica se o modelo é valido ou não

            onClienteService.onRepositoryCliente.Incluir(model);

            return RedirectToAction("Index"); // redireciona para pagina Index
        }

        public IActionResult Details(int id)
        {
            Cliente oCliente = onClienteService.onRepositoryCliente.Selecionar_Pk(id);
            return View(oCliente);
        }

        public IActionResult Edit(int id)
        {
            Cliente oCliente = onClienteService.onRepositoryCliente.Selecionar_Pk(id);
            return View(oCliente);
        }

        [HttpPost]
        public IActionResult Edit(Cliente model)
        {
            //if (!ModelState.IsValid) return View();

            Cliente oCliente = onClienteService.onRepositoryCliente.Alterar(model);

            int id = oCliente.Id;

            return RedirectToAction("Details", new { id } ); // redirecionando para a pagina de detalhes
        }

        public IActionResult Delete(int id)
        {
            onClienteService.onRepositoryCliente.Excluir(id); // Excluido o dado
            return RedirectToAction("Index");
        }
    }
}
