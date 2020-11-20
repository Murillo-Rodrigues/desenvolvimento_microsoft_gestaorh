using GestaoRHWeb.DAL;
using Microsoft.AspNetCore.Mvc;

namespace GestaoRHWeb.Controllers
{
    public class SolicitacaoController : Controller
    {

        private readonly SolicitacaoDAO _solicitacaoDAO;
        private readonly ProntuarioDAO _prontuarioDAO;
        private readonly ItemSolicitacaoDAO _itemSolicitacaoDAO;

        public SolicitacaoController(SolicitacaoDAO solicitacaoDAO, ProntuarioDAO prontuarioDAO, ItemSolicitacaoDAO itemSolicitacaoDAO)
        {
            _solicitacaoDAO = solicitacaoDAO;
            _prontuarioDAO = prontuarioDAO;
            _itemSolicitacaoDAO = itemSolicitacaoDAO;
        }

        public IActionResult Index()
        {
            return View(_prontuarioDAO.Listar());
        }


    }
}
