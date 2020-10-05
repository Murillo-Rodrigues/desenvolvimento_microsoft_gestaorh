using GestaoRHWPF.DAL;
using GestaoRHWPF.Models;
using System.Windows;

namespace GestaoRHWPF.Views.Remover
{
    /// <summary>
    /// Interaction logic for frmRemoverProntuario.xaml
    /// </summary>
    public partial class frmRemoverProntuario : Window
    {
        Prontuario prontuario = new Prontuario();
        public frmRemoverProntuario()
        {
            InitializeComponent();
            txtMatricula.Focus();
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMatricula.Text))
            {
                prontuario = ProntuarioDAO.BuscarPorMatriculaP(txtMatricula.Text);
                if (prontuario != null)
                {
                    txtId.Text = prontuario.Id.ToString();
                    txtMatricula.Text = prontuario.Funcionario.Matricula;
                    txtNomeFuncionario.Text = prontuario.Funcionario.Nome;
                    txtNumeroCaixa.Text = prontuario.Caixa.NumeroCaixa;
                    txtCustodia.Text = prontuario.Caixa.Custodia;
                    txtCriadoEm.Text = prontuario.CriadoEm.ToString();
                    btnRemover.IsEnabled = true;
                }
                else
                {
                    MessageBox.Show("O prontuário não pôde ser encontrado!", "Remoção de Prontuários",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo MATRÍCULA!", "Remoção de Prontuários",
                       MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnRemover_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMatricula.Text))
            {
                prontuario = ProntuarioDAO.BuscarPorMatriculaP(txtMatricula.Text);

                if (prontuario != null)
                {
                    if (ProntuarioDAO.Remover(prontuario))
                    {
                        MessageBox.Show("Remoção concluída com sucesso!", "Remoção de Prontuários",
                            MessageBoxButton.OK, MessageBoxImage.Information);
                        LimparFormulario();
                        btnRemover.IsEnabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Não é possível remover um prontuário com solicitação aberta!", "Remoção de Prontuários",
                            MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("O prontuário não existe!", "Remoção de Prontuários",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
            else
            {
                MessageBox.Show("Preencha o campo MATRÍCULA!", "Remoção de Prontuários",
                       MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void LimparFormulario()
        {
            txtId.Clear();
            txtMatricula.Clear();
            txtNomeFuncionario.Clear();
            txtNumeroCaixa.Clear();
            txtCustodia.Clear();
            txtCriadoEm.Clear();
            txtMatricula.Focus();
        }
    }
}
