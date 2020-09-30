using GestaoRHWPF.DAL;
using GestaoRHWPF.Models;
using System.Windows;

namespace GestaoRHWPF.Views.Remover
{
    /// <summary>
    /// Interaction logic for frmRemoverCaixa.xaml
    /// </summary>
    public partial class frmRemoverCaixa : Window
    {
        Caixa caixa = new Caixa();
        public frmRemoverCaixa()
        {
            InitializeComponent();
            txtNumeroCaixa.Focus();
        }

        private void btnBuscarCaixa_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNumeroCaixa.Text))
            {
                caixa = CaixaDAO.BuscarPorNumeroCaixa(txtNumeroCaixa.Text);

                if (caixa != null)
                {
                    txtId.Text = caixa.Id.ToString();
                    txtNumeroCaixa.Text = caixa.NumeroCaixa.ToString();
                    txtPosicaoCorredor.Text = caixa.PosicaoCorredor.ToString();
                    txtPosicaoEstante.Text = caixa.PosicaoEstante.ToString();
                    txtPosicaoAltura.Text = caixa.PosicaoAltura.ToString();
                    txtCriadoEm.Text = caixa.CriadoEm.ToString();
                    btnRemoverCaixa.IsEnabled = true;

                }
                else
                {
                    MessageBox.Show("A caixa não pôde ser encontrada!", "Remoção de Caixas",
                       MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo NÚMERO DA CAIXA!", "Remoção de Caixas",
                       MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void btnRemoverCaixa_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNumeroCaixa.Text))
            {
                CaixaDAO.Remover(caixa);
                MessageBox.Show("Remoção concluída com sucesso!", "Remoção de Caixas",
                        MessageBoxButton.OK, MessageBoxImage.Information);
                LimparFormulario();
            }
            else
            {
                MessageBox.Show("Preencha o campo NÚMERO DA CAIXA!", "Remoção de Caixas",
                      MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void LimparFormulario()
        {
            txtId.Clear();
            txtNumeroCaixa.Clear();
            txtPosicaoCorredor.Clear();
            txtPosicaoEstante.Clear();
            txtPosicaoAltura.Clear();
            txtCriadoEm.Clear();
            txtNumeroCaixa.Focus();
        }
    }
}
