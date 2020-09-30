using GestaoRHWPF.DAL;
using GestaoRHWPF.Models;
using System.Windows;

namespace GestaoRHWPF.Views.Cadastrar
{
    /// <summary>
    /// Interaction logic for frmCadastrarCaixa.xaml
    /// </summary>
    public partial class frmCadastrarCaixa : Window
    {
        public frmCadastrarCaixa()
        {
            InitializeComponent();
            txtNumeroCaixa.Focus();
        }

        private void btnCadastrarCaixa_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNumeroCaixa.Text))
            {
                Caixa caixa = new Caixa
                {
                    NumeroCaixa = txtNumeroCaixa.Text,
                    PosicaoCorredor = txtPosicaoCorredor.Text,
                    PosicaoEstante = txtPosicaoEstante.Text,
                    PosicaoAltura = txtPosicaoAltura.Text
                };

                if (CaixaDAO.Cadastrar(caixa))
                {
                    MessageBox.Show("Cadastro de Caixa realizado com sucesso!", "Cadastro de Caixas",
                                    MessageBoxButton.OK, MessageBoxImage.Information);
                    LimparFormulario();
                }
                else
                {
                    MessageBox.Show("Esta caixa já existe!", "Cadastro de Funcionários", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
            else
            {
                MessageBox.Show("Preencha todos os campos!", "Cadastro de Caixas",
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
