using GestaoRHWPF.DAL;
using GestaoRHWPF.Models;
using System.Windows;

namespace GestaoRHWPF.Views.Solicitar
{
    /// <summary>
    /// Interaction logic for frmListarSolicitacoes.xaml
    /// </summary>
    public partial class frmListarSolicitacoes : Window
    {
        public frmListarSolicitacoes()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dtaSolicitacoes.ItemsSource = SolicitacaoDAO.Listar();
            Solicitacao solicitacao = new Solicitacao();

            dynamic item = new
            {
                Matricula = solicitacao.Funcionario.Matricula,
                Custodia = solicitacao.Caixa.Custodia,
                CriadoEm = solicitacao.CriadoEm
            };
        }
    }
}
