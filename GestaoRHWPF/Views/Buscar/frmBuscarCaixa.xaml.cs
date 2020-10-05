using GestaoRHWPF.DAL;
using GestaoRHWPF.Models;
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
            Caixa caixa = new Caixa();

            dynamic item = new
            {
                NumeroCaixa = caixa.NumeroCaixa,
                Custodia = caixa.Custodia,
                CriadoEm = caixa.CriadoEm
            };
        }
    }
}
