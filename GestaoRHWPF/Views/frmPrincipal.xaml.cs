using GestaoRHWPF.Views.Buscar;
using GestaoRHWPF.Views.Cadastrar;
using GestaoRHWPF.Views.Remover;
using GestaoRHWPF.Views.Solicitar;
using System.Windows;

namespace GestaoRHWPF.Views
{
    /// <summary>
    /// Interaction logic for frmPrincipal.xaml
    /// </summary>
    public partial class frmPrincipal : Window
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void menuSair_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "GestaoRH WPF", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void menuCadastrarFuncionario_Click(object sender, RoutedEventArgs e)
        {
            frmCadastrarFuncionario frmcadastrarfuncionario = new frmCadastrarFuncionario();
            frmcadastrarfuncionario.Show();
        }

        private void menuBuscarFuncionario_Click(object sender, RoutedEventArgs e)
        {
            frmBuscarFuncionario frmbuscarfuncionario = new frmBuscarFuncionario();
            frmbuscarfuncionario.Show();
        }

        private void menuRemoverFuncionario_Click(object sender, RoutedEventArgs e)
        {
            frmRemoverFuncionario frmremoverfuncionario = new frmRemoverFuncionario();
            frmremoverfuncionario.Show();
        }

        private void menuCadastrarCaixa_Click(object sender, RoutedEventArgs e)
        {
            frmCadastrarCaixa frmcadastrarcaixa = new frmCadastrarCaixa();
            frmcadastrarcaixa.Show();
        }

        private void menuBuscarCaixa_Click(object sender, RoutedEventArgs e)
        {
            frmBuscarCaixa frmbuscarcaixa = new frmBuscarCaixa();
            frmbuscarcaixa.Show();
        }

        private void menuRemoverCaixa_Click(object sender, RoutedEventArgs e)
        {
            frmRemoverCaixa frmremovercaixa = new frmRemoverCaixa();
            frmremovercaixa.Show();
        }

        private void menuCadastrarProntuario_Click(object sender, RoutedEventArgs e)
        {
            frmCadastrarProntuario frmcadastrarprontuario = new frmCadastrarProntuario();
            frmcadastrarprontuario.Show();
        }

        private void menuBuscarProntuario_Click(object sender, RoutedEventArgs e)
        {
            frmBuscarProntuario frmbuscarprontuario = new frmBuscarProntuario();
            frmbuscarprontuario.Show();
        }

        private void menuRemoverProntuario_Click(object sender, RoutedEventArgs e)
        {
            frmRemoverProntuario frmremoverprontuario = new frmRemoverProntuario();
            frmremoverprontuario.Show();
        }

        private void menuSolicitarProntuario_Click(object sender, RoutedEventArgs e)
        {
            frmSolicitarProntuario frmsolicitarprontuario = new frmSolicitarProntuario();
            frmsolicitarprontuario.Show();
        }

        private void btnCadastrarFuncionario_Click(object sender, RoutedEventArgs e)
        {
            menuCadastrarFuncionario_Click(sender, e);
        }

        private void btnListarFuncionario_Click(object sender, RoutedEventArgs e)
        {
            menuBuscarFuncionario_Click(sender, e);
        }

        private void btnRemoverFuncionario_Click(object sender, RoutedEventArgs e)
        {
            menuRemoverFuncionario_Click(sender, e);
        }
    }
}
