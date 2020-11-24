using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestaoRHWeb.Models;
using GestaoRHWeb.DAL;

namespace GestaoRHWeb.Controllers
{
    public class SolicitacaoController : Controller
    {
        private readonly SolicitacaoDAO _solicitacaoDAO;
        private readonly FuncionarioDAO _funcionarioDAO;
        private readonly ProntuarioDAO _prontuarioDAO;
        private readonly CaixaDAO _caixaDAO;

        public SolicitacaoController(SolicitacaoDAO solicitacaoDAO, FuncionarioDAO funcionarioDAO, ProntuarioDAO prontuarioDAO, CaixaDAO caixaDAO)
        {
            _solicitacaoDAO = solicitacaoDAO;
            _funcionarioDAO = funcionarioDAO;
            _prontuarioDAO = prontuarioDAO;
            _caixaDAO = caixaDAO;
        }

        // GET: Solicitacao
        public IActionResult Index()
        {
            List<Solicitacao> solicitacoes = _solicitacaoDAO.Listar();
            ViewBag.QuantidadeRegistros = solicitacoes.Count();
            return View(solicitacoes);
        }

        public IActionResult Cadastrar()
        {

            ViewBag.listaMatriculas = new SelectList(_funcionarioDAO.Listar(), "Id", "Matricula");
            ViewBag.listaCustodias = new SelectList(_caixaDAO.Listar(), "Id", "Custodia");

            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Solicitacao solicitacao)
        {
            if (solicitacao.Funcionario.Id != 0 && solicitacao.Caixa.Id != 0)
            {
                //if (ModelState.IsValid)
                //{
                solicitacao.Funcionario = _funcionarioDAO.BuscarPorId(solicitacao.Funcionario.Id);
                solicitacao.Caixa = _caixaDAO.BuscarPorId(solicitacao.Caixa.Id);
                if (_solicitacaoDAO.Cadastrar(solicitacao))
                {
                    return RedirectToAction("Index", "Funcionario");
                }
                ModelState.AddModelError("", "Não foi possível realizar o cadastro da solicitação!");
                //}
            }
            else
            {
                ModelState.AddModelError("", "Não é possível cadastrar uma solicitacao com um ou mais dados nulos! Por favor, selecione uma matrícula e uma custódia!");
            }
            ViewBag.listaMatriculas = new SelectList(_funcionarioDAO.Listar(), "Id", "Matricula");
            ViewBag.listaCustodias = new SelectList(_caixaDAO.Listar(), "Id", "Custodia");

            return View(solicitacao);
        }

    }
}
