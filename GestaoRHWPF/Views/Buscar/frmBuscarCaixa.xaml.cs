using GestaoRHWPF.DAL;
using System.Windows;

namespace GestaoRHWPF.Views.Buscar
{
    /// <summary>
    /// Interaction logic for frmBuscarCaixa.xaml
    /// </summary>
    public partial class frmBuscarCaixa : Window
    {
        public frmBuscarCaixa()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dtaCaixas.ItemsSource = CaixaDAO.Listar();
        }
    }
}
