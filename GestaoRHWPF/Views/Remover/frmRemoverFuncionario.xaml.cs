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
            if (!string.IsNullOrEmpty(txtMatricula.Text))
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
                        MessageBox.Show("Não é possivel remover um funcionário com prontuários vinculados   !", "Remoção de Funcionários",
                            MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("O funcionário não existe!", "Remoção de Funcionários",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
            else
            {
                MessageBox.Show("Preencha o campo MATRÍCULA!", "Remoção de Funcionários",
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
