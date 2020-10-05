using GestaoRHWPF.DAL;
using GestaoRHWPF.Models;
using GestaoRHWPF.Utils;
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
            txtMatricula.Focus();

        }

        private void btnCadastrarFuncionario_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNome.Text) && !string.IsNullOrWhiteSpace(txtMatricula.Text) && !string.IsNullOrWhiteSpace(txtCpf.Text) && txtMatricula.Text.Length == 5 && txtCpf.Text.Length == 11)
            {
                if (Validacao.ValidarCpf(txtCpf.Text))
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
                        MessageBox.Show("Um funcionário com esta matrícula já existe!", "Cadastro de Funcionários", MessageBoxButton.OK, MessageBoxImage.Error);
                        LimparFormulario();
                    }
                }
                else
                {
                    MessageBox.Show("Este CPF não é válido!", "Cadastro de Funcionários", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos para realizar o cadastro!", "Cadastro de Funcionários", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void LimparFormulario()
        {
            txtNome.Clear();
            txtMatricula.Clear();
            txtCpf.Clear();
            txtMatricula.Focus();
        }

        private void txtNome_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {

        }
    }
}
