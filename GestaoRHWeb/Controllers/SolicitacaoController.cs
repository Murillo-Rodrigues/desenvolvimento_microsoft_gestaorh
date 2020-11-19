using GestaoRHWeb.DAL;
using Microsoft.AspNetCore.Mvc;

namespace GestaoRHWeb.Controllers
{
    public class SolicitacaoController : Controller
    {

        private readonly SolicitacaoDAO _solicitacaoDAO;

        public SolicitacaoController(SolicitacaoDAO solicitacaoDAO) => _solicitacaoDAO = solicitacaoDAO;

        public IActionResult Index()
        {
            return View();
        }


    }
}
