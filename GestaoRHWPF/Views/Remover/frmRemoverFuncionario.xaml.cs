using GestaoRHWPF.DAL;
using GestaoRHWPF.Models;
using System.Windows;

namespace GestaoRHWPF.Views.Remover
{
    /// <summary>
    /// Interaction logic for frmRemoverFuncionario.xaml
    /// </summary>
    public partial class frmRemoverFuncionario : Window
    {
        Funcionario funcionario = new Funcionario();
        public frmRemoverFuncionario()
        {
            InitializeComponent();
            txtMatricula.Focus();
        }
        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMatricula.Text))
            {
                funcionario = FuncionarioDAO.BuscarPorMatricula(txtMatricula.Text);
                if (funcionario != null)
                {
                    txtId.Text = funcionario.Id.ToString();
                    txtMatricula.Text = funcionario.Matricula;
                    txtNome.Text = funcionario.Nome;
                    txtCpf.Text = funcionario.Cpf;
                    txtCriadoEm.Text = funcionario.CriadoEm.ToString();
                    btnRemover.IsEnabled = true;
                    btnAlterar.IsEnabled = true;

                }
                else
                {
                    MessageBox.Show("O funcionário não pôde ser encontrado!", "Remoção de Funcionários",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo MATRÍCULA!", "Remoção de Funcionários",
                       MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnRemover_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMatricula.Text) || !string.IsNullOrWhiteSpace(txtNome.Text) || !string.IsNullOrWhiteSpace(txtCpf.Text))
            {
                //funcionario = new Funcionario();

                funcionario = FuncionarioDAO.BuscarPorMatricula(txtMatricula.Text);

                if (funcionario != null)
                {

                    if (FuncionarioDAO.Remover(funcionario))
                    {
                        MessageBox.Show("Remoção concluída com sucesso!", "Remoção de Funcionários",
                            MessageBoxButton.OK, MessageBoxImage.Information);
                        LimparFormulario();
                        btnRemover.IsEnabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Não é possivel remover um funcionário com prontuários vinculados!", "Remoção de Funcionários",
                            MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("O funcionário não existe na base!", "Remoção de Funcionários",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
            else
            {
                MessageBox.Show("É necessário preencher todos os campos!", "Remoção de Funcionários",
                       MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnAlterar_Click(object sender, RoutedEventArgs e)
        {
            btnRemover.Visibility = Visibility.Hidden;
            btnConcluir.Visibility = Visibility.Visible;
            txtNome.IsEnabled = true;
            txtCpf.IsEnabled = true;
            btnConcluir.IsEnabled = true;

        }

        private void btnConcluir_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMatricula.Text) && !string.IsNullOrWhiteSpace(txtNome.Text) && !string.IsNullOrWhiteSpace(txtCpf.Text))
            {
                //funcionario = new Funcionario();

                funcionario = FuncionarioDAO.BuscarPorMatricula(txtMatricula.Text);

                if (funcionario != null)
                {
                    funcionario.Matricula = txtMatricula.Text;
                    funcionario.Cpf = txtCpf.Text;
                    funcionario.Nome = txtNome.Text;

                    if (FuncionarioDAO.Alterar(funcionario))
                    {

                        MessageBox.Show("Alteração concluída com sucesso!", "Remoção de Funcionários",
                            MessageBoxButton.OK, MessageBoxImage.Information);

                        btnRemover.IsEnabled = true;
                        btnRemover.Visibility = Visibility.Visible;
                        btnConcluir.Visibility = Visibility.Hidden;
                        txtNome.IsEnabled = false;
                        txtCpf.IsEnabled = false;


                    }
                    else
                    {
                        MessageBox.Show("Não é possivel alterar um funcionário com prontuários vinculados!", "Remoção de Funcionários",
                            MessageBoxButton.OK, MessageBoxImage.Error);
                        LimparFormulario();
                    }
                }
                else
                {
                    MessageBox.Show("O funcionário não existe na base!", "Remoção de Funcionários",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                    LimparFormulario();
                }

            }
            else
            {
                MessageBox.Show("É necessário preencher todos os campos!", "Remoção de Funcionários",
                       MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void LimparFormulario()
        {
            txtId.Clear();
            txtNome.Clear();
            txtMatricula.Clear();
            txtCpf.Clear();
            txtCriadoEm.Clear();
            txtMatricula.Focus();
        }
    }
}
