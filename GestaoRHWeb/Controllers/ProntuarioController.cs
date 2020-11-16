using GestaoRHWeb.DAL;
using GestaoRHWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GestaoRHWeb.Controllers
{
    public class ProntuarioController : Controller
    {
        private readonly FuncionarioDAO _funcionarioDAO;

        private readonly ProntuarioDAO _prontuarioDAO;

        private readonly CaixaDAO _caixaDAO;

        public ProntuarioController(ProntuarioDAO prontuarioDAO, FuncionarioDAO funcionarioDAO, CaixaDAO caixaDAO)
        {
            _prontuarioDAO = prontuarioDAO;
            _funcionarioDAO = funcionarioDAO;
            _caixaDAO = caixaDAO;
        }


        /* ------------------- INDEX ------------------- */
        public IActionResult Index()
        {


            return View();
        }


        /* ------------------- CADASTRAR ------------------- */
        public IActionResult Cadastrar()
        {

            ViewBag.listaMatriculas = new SelectList(_funcionarioDAO.Listar(), "Id", "Matricula");
            ViewBag.listaCustodias = new SelectList(_caixaDAO.Listar(), "Id", "Custodia");

            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Prontuario prontuario)
        {
            ViewBag.listaMatriculas = new SelectList(_funcionarioDAO.Listar(), "Id", "Matricula");
            ViewBag.listaCustodias = new SelectList(_caixaDAO.Listar(), "Id", "Custodia");
            return View(prontuario);
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

        public IActionResult Alterar(Prontuario prontuario)
        {

            return View();
        }

    }
}
