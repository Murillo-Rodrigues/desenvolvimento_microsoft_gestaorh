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
            if (prontuario.FuncionarioId != 0 && prontuario.CaixaId != 0)
            {
                //if (ModelState.IsValid)
                //{
                prontuario.Funcionario = _funcionarioDAO.BuscarPorId(prontuario.FuncionarioId);
                prontuario.Caixa = _caixaDAO.BuscarPorId(prontuario.CaixaId);
                if (_prontuarioDAO.Cadastrar(prontuario))
                {
                    return RedirectToAction("Index", "Funcionario");
                }
                ModelState.AddModelError("", "Não foi possível cadastrar o prontuário!");
                //}
            }
            ModelState.AddModelError("", "Não é possível cadastrar um prontuário com um ou mais dados nulos! Por favor, selecione uma matrícula e uma custódia!");
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
