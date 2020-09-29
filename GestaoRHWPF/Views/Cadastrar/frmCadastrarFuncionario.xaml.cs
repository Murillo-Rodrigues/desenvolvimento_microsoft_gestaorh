using GestaoRHWPF.DAL;
using GestaoRHWPF.Models;
using System.Windows;

namespace GestaoRHWPF.Views.Cadastrar
{
    /// <summary>
    /// Interaction logic for frmCadastrarFuncionario.xaml
    /// </summary>
    public partial class frmCadastrarFuncionario : Window
    {
        public frmCadastrarFuncionario()
        {
            InitializeComponent();
            txtNome.Focus();
        }

        private void btnCadastrarFuncionario_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNome.Text))
            {
                Funcionario funcionario = new Funcionario
                {
                    Nome = txtNome.Text,
                    Matricula = txtMatricula.Text,
                    Cpf = txtCpf.Text
                };

                if (FuncionarioDAO.Cadastrar(funcionario))
                {
                    MessageBox.Show("Funcionário cadastrado com sucesso!", "Cadastro de Funcionários", MessageBoxButton.OK, MessageBoxImage.Information);
                    LimparFormulario();
                }
                else
                {
                    MessageBox.Show("Este funcionário já existe!", "Cadastro de Funcionários", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha o nome!", "Cadastro de Funcionários", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void LimparFormulario()
        {
            txtId.Clear();
            txtNome.Clear();
            txtMatricula.Clear();
            txtCpf.Clear();
            txtCriadoEm.Clear();
            txtNome.Focus();
        }
    }
}
