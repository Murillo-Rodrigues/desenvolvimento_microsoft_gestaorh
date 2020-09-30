using GestaoRHWPF.Views.Buscar;
using GestaoRHWPF.Views.Cadastrar;
using GestaoRHWPF.Views.Remover;
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
    }
}
