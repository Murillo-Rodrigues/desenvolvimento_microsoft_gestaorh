using GestaoRHWPF.DAL;
using System.Windows;

namespace GestaoRHWPF.Views.Buscar
{
    /// <summary>
    /// Interaction logic for frmBuscarProntuario.xaml
    /// </summary>
    public partial class frmBuscarProntuario : Window
    {
        public frmBuscarProntuario()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dtaProntuarios.ItemsSource = ProntuarioDAO.Listar();
            dtaProntuarios.DisplayMemberPath = "Id";
        }
    }
}
