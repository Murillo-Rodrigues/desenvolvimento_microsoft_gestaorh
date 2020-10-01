using GestaoRHWPF.DAL;
using GestaoRHWPF.Models;
using System.Windows;

namespace GestaoRHWPF.Views.Buscar
{
    /// <summary>
    /// Interaction logic for frmBuscarFuncionario.xaml
    /// </summary>
    public partial class frmBuscarFuncionario : Window
    {
        public frmBuscarFuncionario()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dtaFuncionarios.ItemsSource = FuncionarioDAO.Listar();
            Funcionario funcionario = new Funcionario();

            dynamic item = new
            {
                Matricula = funcionario.Matricula,
                Nome = funcionario.Nome,
                Cpf = funcionario.Cpf
            };
        }

    }
}
