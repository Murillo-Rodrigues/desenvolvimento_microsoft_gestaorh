using GestaoRHWPF.DAL;
using GestaoRHWPF.Models;
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
            Prontuario prontuario = new Prontuario();

            dynamic item = new
            {
                Matricula = prontuario.Funcionario.Matricula,
                Custodia = prontuario.Caixa.Custodia,
                CriadoEm = prontuario.CriadoEm
            };

        }
    }
}
