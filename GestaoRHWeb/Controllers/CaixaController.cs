using GestaoRHWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GestaoRHWeb.Controllers
{
    public class CaixaController : Controller
    {
        private readonly Context _context;

        public CaixaController(Context context)
        {
            _context = context;
        }

        /* ------------------- INDEX ------------------- */
        public async Task<IActionResult> Index()
        {
            return View();
        }


        /* ------------------- CADASTRAR ------------------- */
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Caixa caixa)
        {

            return View(caixa);
        }

        /* ------------------- REMOVER ------------------- */
        [HttpPost]
        public IActionResult Remover(int id)
        {

            return RedirectToAction(nameof(Index));
        }


        /* ------------------- ALTERAR ------------------- */
        public IActionResult Alterar(int id)
        {

            return View();
        }


        [HttpPost]

        public IActionResult Alterar(Caixa caixa)
        {

            return View(caixa);
        }


    }
}
