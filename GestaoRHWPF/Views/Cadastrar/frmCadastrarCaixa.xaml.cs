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
            if (!string.IsNullOrWhiteSpace(txtNumeroCaixa.Text) || !string.IsNullOrWhiteSpace(txtCustodia.Text))
            {
                Caixa caixa = new Caixa
                {
                    NumeroCaixa = txtNumeroCaixa.Text,
                    Custodia = txtCustodia.Text,
                };

                if (CaixaDAO.BuscarPorNumeroCaixa(caixa.NumeroCaixa) != null)
                {

                    MessageBox.Show("Caixa com número já existe", "Cadastro de Caixas", MessageBoxButton.OK, MessageBoxImage.Error);
                    LimparFormulario();

                }
                else
                {
                    if (CaixaDAO.BuscarPorCustodia(caixa.Custodia) != null)
                    {
                        MessageBox.Show("Caixa no setor, posição, altura, já existe", "Cadastro de Caixas", MessageBoxButton.OK, MessageBoxImage.Error);
                        LimparFormulario();
                    }
                    else
                    {
                        CaixaDAO.Cadastrar(caixa);
                        MessageBox.Show("Caixa cadastrada com sucesso!", "Cadastro de Caixas", MessageBoxButton.OK, MessageBoxImage.Information);
                        LimparFormulario();
                    }
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
            txtCustodia.Clear();
            txtCriadoEm.Clear();
            txtNumeroCaixa.Focus();
        }

    }
}
